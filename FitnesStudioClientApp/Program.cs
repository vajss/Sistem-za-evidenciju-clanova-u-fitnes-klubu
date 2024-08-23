using FitnesStudioClientApp.UIControllers;
using System;
using System.Runtime.Remoting;
using System.Windows.Forms;

namespace FitnesStudioClientApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            while (true)
            {
                try
                {
                    MainCoordinator.Instance.OpenLoginForm();
                    Application.Run();
                }
                catch (ServerException se)
                {
                    MessageBox.Show(se.Message);
                }
            }
        }
    }
}
