using System;
using System.ServiceProcess;
using System.Windows.Forms;

namespace LaravelQueueService
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            if (Environment.UserInteractive)
            {
                StartForm();
            }
            else
            {
                StartService();
            }
        }

        [STAThread]
        static void StartForm()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        static void StartService()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new LaravelQueueService()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
