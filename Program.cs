using System;
using System.Threading;
using System.Windows.Forms;
using StretchCeilingsApp.Utility;

namespace StretchCeilingsApp
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
            await LogWriter.WriteAsync(DateTime.Now, e.Exception.Message);
        }
    }
}
