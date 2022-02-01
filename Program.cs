using System;
using System.Threading;
using System.Windows.Forms;
using StretchCeilings.Helpers;
using StretchCeilings.Helpers.Enums;

namespace StretchCeilings
{
    public static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += Exception;
            Application.Run(new LoginForm());
        }

        private static async void Exception(object sender, ThreadExceptionEventArgs e)
        {
            await LoggingHelper.WriteAsync(DateTime.Now, e.Exception.Message, LogLevel.ERROR);
        }
    }
}
