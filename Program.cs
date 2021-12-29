using stretch_ceilings_app.Utility;
using System;
using System.Threading;
using System.Windows.Forms;

namespace stretch_ceilings_app
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += new ThreadExceptionEventHandler(Exception);
            Application.Run(new LoginForm());
        }

        private static void Exception(object sender, ThreadExceptionEventArgs e)
        {
            LogWriter.Write(DateTime.Now, e.Exception.Message);
        }
    }
}
