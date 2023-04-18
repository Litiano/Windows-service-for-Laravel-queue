using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LaravelQueueService
{
    internal class Logger
    {
        protected StreamWriter streamWriter;
        protected Properties.Settings config = Properties.Settings.Default;
        protected string currentFilePath;
        protected static Logger logger;

        ~Logger()
        {
            CloseFileSecurely();
        }

        protected void CloseFileSecurely()
        {
            try
            {
                if (streamWriter != null)
                {
                    streamWriter.Close();
                }
            } catch {}
            streamWriter = null;
        }

        protected static void Init()
        {
            if (logger == null)
            {
                logger = new Logger();
            }

            if (logger.currentFilePath != logger.GetFilePath())
            {
                logger.CloseFileSecurely();

                logger.currentFilePath = logger.GetFilePath();
                logger.streamWriter = new StreamWriter(logger.currentFilePath, true);
            }
        }
        protected static void Log(string message, string level = "info")
        {
            Init();
            if (message == null || message.Length == 0)
            {
                return;
            }
            string dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fffK");
            message = $"[{dateTime}][{level}]: {message}";
            logger.streamWriter?.WriteLine(message);
            logger.streamWriter?.Flush();
        }

        public static void Info(string message)
        {

            Log(message, "info");
        }

        public static void Warn(string message)
        {
            Log(message, "warn");
        }

        public static void Error(string message)
        {
            Log(message, "error");
        }

        protected string GetFilePath()
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            Properties.Settings config = Properties.Settings.Default;
            string basePath = $"{config.laravel_base_path}/storage/logs";
            if (!Directory.Exists(basePath))
            {
                basePath = "./";
            }

            return $"{basePath}/windows-service-{config.service_name}-{date}.log";
        }
    }
}
