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
                    MainController.Instance.OpenLoginForm();
                    Application.Run();
                }
                catch (ServerException se)
                {
                    MessageBox.Show($"Izgubljena konekcija sa serverom. Prijavite se ponovo. \n\n Greška: {se.Message}", "Izgubljena konekcija sa serverom" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
