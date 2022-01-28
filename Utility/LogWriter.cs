﻿using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace StretchCeilingsApp.Utility
{
    public static class LogWriter
    {
        private static readonly string _logFilePath;
        private const string _fileName = "App.log";

        static LogWriter()
        {
            var exeDirInfo = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);

            _logFilePath = $@"{exeDirInfo?.Parent?.Parent?.FullName}\{_fileName}";
        }

        public static async Task WriteAsync(DateTime time, string message)
        {
            using (var writer = new StreamWriter(_logFilePath, true, Encoding.UTF8))
            {
                await writer.WriteLineAsync($"{time}: {message}");
            }
        }
    }
}
