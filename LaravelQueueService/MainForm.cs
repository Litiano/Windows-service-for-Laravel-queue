using System;
using System.Configuration.Install;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.ServiceProcess;
using System.Threading;
using System.Windows.Forms;

namespace LaravelQueueService
{
    public partial class MainForm : Form
    {
        readonly Properties.Settings config = Properties.Settings.Default;
        public MainForm()
        {
            InitializeComponent();

            UpdateView();

            Thread t = new Thread(new ThreadStart(UpdateRunningStatus))
            {
                IsBackground = true
            };
            t.Start();
        }

        delegate void UpdateRunningStatusTextCallback(string text);

        private void UpdateRunningStatus()
        {
            while (true)
            {
                string text = "-";
                ServiceController ctl = FindService();
                if (ctl != null)
                {
                    text = ctl.Status.ToString();
                }
                UpdateRunningStatusTextCallback d = new UpdateRunningStatusTextCallback(SetRunningStatusText);
                Invoke(d, new object[] { text });
                
                Thread.Sleep(1_000);
            }
        }

        private void SetRunningStatusText(string text)
        {
            serviceStatusLabel.Text = text;
        }

        private void UpdateView()
        {
            installButton.Enabled = !IsInstalled() && IsAdministrator();
            uninstallButton.Enabled = IsInstalled() && IsAdministrator();
            adminAlert.Visible = !IsAdministrator();
            comandLabel.Text = $"{config.php_path} {config.laravel_base_path}/artisan queue:work {config.queue_connection} {config.queue_work_arguments}";
            versionLabel.Text = "Version: " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void InstallButtonClick(object sender, EventArgs e)
        {
            try
            {
                LaravelQueueService.Validate();
                Cursor = Cursors.WaitCursor;
                installButton.Enabled = false;
                ManagedInstallerClass.InstallHelper(new string[] { Assembly.GetExecutingAssembly().Location });

                Process process = new Process();
                process.StartInfo.FileName = "sc";
                process.StartInfo.Arguments = $"failure {config.service_name} reset=0 actions=restart/60000/restart/60000/restart/600000";
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.Start();
                process.WaitForExit();

                MessageBox.Show("Service installed successfully!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Erro");
            }
            finally
            {
                Cursor = Cursors.Arrow;
                UpdateView();
            }
        }

        private void UninstallButtonClick(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                uninstallButton.Enabled = false;
                ManagedInstallerClass.InstallHelper(new string[] { "/u", Assembly.GetExecutingAssembly().Location });
                MessageBox.Show("Service uninstalled successfully!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
            finally
            {
                Cursor = Cursors.Arrow;
                UpdateView();
            }
        }

        public static bool IsAdministrator()
        {
            return (new WindowsPrincipal(WindowsIdentity.GetCurrent())).IsInRole(WindowsBuiltInRole.Administrator);
        }

        private ServiceController FindService()
        {
            return ServiceController.GetServices().FirstOrDefault(s => s.ServiceName == config.service_name);
        }

        private bool IsInstalled()
        {
            return FindService() != null;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://packagist.org/packages/litiano/windows-service-for-laravel-queue");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Litiano/");
        }
    }
}
