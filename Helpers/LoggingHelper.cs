using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using StretchCeilings.Helpers.Enums;

namespace StretchCeilings.Helpers
{
    public static class LoggingHelper
    {
        private static readonly string _filePath;
        private const string _fileName = "App.log";

        static LoggingHelper()
        {
            var exeDirInfo = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);

            _filePath = $@"{exeDirInfo.Parent?.Parent?.FullName}\{_fileName}";
        }

        public static async Task WriteAsync(DateTime time, string message, LogLevel level)
        {
            using (var writer = new StreamWriter(_filePath, true, Encoding.UTF8))
            {
                await writer.WriteLineAsync($"[{time}] : [{level}] {message}");
            }
        }
    }
}
