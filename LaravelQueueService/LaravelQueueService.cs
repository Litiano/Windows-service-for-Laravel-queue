using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Threading;
using System.Timers;

namespace LaravelQueueService
{
    public partial class LaravelQueueService : ServiceBase
    {
        public Process PhpProcess { get; private set; }
        private static readonly Properties.Settings config = Properties.Settings.Default;

        public LaravelQueueService()
        {
            InitializeComponent();
            Logger.Info("LaravelQueueService()");
        }

        protected override void OnStart(string[] args)
        {
            Logger.Info("On Start begin.");
            try
            {
                Validate();
            } catch (Exception e)
            {
                Logger.Error(e.Message);
                throw e;
            }
           
            StartQueueWorkThread();

            Logger.Info("On Start end.");
        }

        protected void StartQueueWorkThread()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                /* run your code here */
                Logger.Info("Starting PHP process...");

                string[] arguments = {
                    $"{config.laravel_base_path}/artisan",
                    "windows:service:queue:work",
                    config.queue_connection,
                    $"--windowsServiceName={config.service_name}",
                    config.queue_work_arguments,
                };

                PhpProcess = CreateBackgroungProcess(config.php_path, string.Join(" ", arguments));
                PhpProcess.Start();
                Logger.Info($"Running {config.php_path} {arguments}");
                Logger.Info("PHP process started with PID: " + PhpProcess.Id);
                LogMemoryUsage();
                StartMemoryVerifyThread();

                while (!PhpProcess.HasExited)
                {
                    Logger.Info(PhpProcess.StandardOutput.ReadLine());
                    // OnStop end this thread
                }

                Logger.Info(PhpProcess.StandardOutput.ReadToEnd());// read last output
                if (PhpProcess.ExitCode != 0)
                {
                    string errorMsg = $"[ERROR] PHP process (PDI {PhpProcess.Id}) exited unexpectedly with code: {PhpProcess.ExitCode}";
                    Logger.Error(errorMsg);
                    throw new Exception(errorMsg);
                }
                Logger.Info($"PHP process (PID {PhpProcess.Id}) exited on Thread, with code: {PhpProcess.ExitCode}");

                Stop();

            }).Start();
        }

        protected override void OnStop()
        {
            Logger.Info("OnStop");
            if(!PhpProcess.HasExited)
            {
                LogMemoryUsage();
                Logger.Info("Sending command windows:service:queue:restart...");
                string[] arguments =
                {
                    config.php_path,
                    $"{config.laravel_base_path}/artisan",
                    $"windows:service:queue:restart",
                    $"--windowsServiceName={config.service_name}",
                };
                Process process = CreateBackgroungProcess(config.php_path, string.Join("", arguments));
                process.Start();
                process.WaitForExit();
                Logger.Info(process.StandardOutput.ReadToEnd());
                Logger.Info("Waiting PHP process to finish...");
                while (!PhpProcess.HasExited) 
                {
                    // prevent high processing
                    Thread.Sleep(500);
                }
                Logger.Info("PHP process exited with code: " + PhpProcess.ExitCode);
                Logger.Info(PhpProcess.StandardOutput.ReadToEnd()); // read last output
            }
        }

        private Process CreateBackgroungProcess(string fileName, string arguments = "")
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = fileName,
                Arguments = arguments,
                RedirectStandardOutput = true,
                UseShellExecute = false
            };
            process.StartInfo = startInfo;

            return process;
        }

        protected override void OnShutdown()
        {
            Logger.Info("OnShutdown");
            base.OnShutdown();
            OnStop();
        }

        protected void StartMemoryVerifyThread()
        {
            System.Timers.Timer timer = new System.Timers.Timer(TimeSpan.FromMinutes(5).TotalMilliseconds)
            {
                AutoReset = true
            };
            timer.Elapsed += new ElapsedEventHandler((object sender, ElapsedEventArgs args) => LogMemoryUsage());
            timer.Start();
        }

        protected void LogMemoryUsage()
        {
            if (!PhpProcess.HasExited)
            {
                PhpProcess.Refresh();
                long physicalMemoryUsage = (PhpProcess.WorkingSet64 / 1_024) / 1_024;
                Logger.Info($"PHP process (PID {PhpProcess.Id}) memory usage {physicalMemoryUsage}MB");
                // @todo restart service if memory usage is >= xMB (add to config).
            }
        }

        public static bool Validate()
        {
            if(!File.Exists(config.php_path)) {
                throw new Exception($"PHP path ({config.php_path}) is invalid!");
            }
            if (!Directory.Exists(config.laravel_base_path))
            {
                throw new Exception($"laravel_base_path ({config.laravel_base_path}) is invalid.");
            }
            if (!Directory.Exists($"{config.laravel_base_path}/storage/logs"))
            {
                throw new Exception($"Log dir ({config.laravel_base_path}/storage/logs) is invalid.");
            }
            if (!File.Exists($"{config.laravel_base_path}/artisan")) {
                throw new Exception($"Artisan path ({config.php_path}) is invalid!");
            }
            return true;
        }
    }
}
