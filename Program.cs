using System;
using System.Threading;
using System.Windows.Forms;

namespace StretchCeilings
{
    public static class Program
    {
        private static log4net.ILog Log => Helpers.LogHelper.GetLogger();

        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += Exception;
            Application.Run(new Views.LoginForm());
        }

        private static void Exception(object sender, ThreadExceptionEventArgs ex)
        {
            Log.Error(ex.Exception.Message);
        }
    }
}
