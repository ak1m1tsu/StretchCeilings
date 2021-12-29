using System;
using System.IO;
using System.Text;

namespace stretch_ceilings_app.Utility
{
    public sealed class LogWriter
    {
        private static string _logFilePath;
        private static string _fileName = "app.log";

        static LogWriter()
        {
            var exeDirInfo = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);

            _logFilePath = $@"{exeDirInfo.Parent.Parent.FullName}\{_fileName}";
        }

        public async static void Write(DateTime time, string message)
        {
            using (StreamWriter writer = new StreamWriter(_logFilePath, true, Encoding.UTF8))
            {
                await writer.WriteLineAsync($"{time}: {message}");
            }
        }
    }
}
