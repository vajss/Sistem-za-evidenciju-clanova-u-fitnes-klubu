using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnesStudioClientApp.UIControllers
{
    public class MainController
    {

        private readonly MainViewCoordinator mainController = new MainViewCoordinator();
        private readonly LoginController loginController = new LoginController();
        private readonly RegisterController registerController = new RegisterController();
        private FrmPocetna frmLogin;
        private FrmMain frmMain;

        private static MainController instance;
        private MainController() { }

        public static MainController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MainController();
                }
                return instance;
            }
        }

        public Trener Trener { get; internal set; }

        public void LogOut()
        {
            try
            {
                Communication.Communication.Instance.LogOut(Trener);
                Communication.Communication.Instance.Disconnect();
                Trener = null;
            }
            catch (ServerException) {}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Neuspešno odjavljivanje.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public void OpenLoginForm()
        {
            frmLogin = new FrmPocetna(loginController, registerController);
            frmLogin.Show();
        }

        public void OpenMainForm()
        {
            frmMain = new FrmMain(mainController);
            frmMain.Show();
        }
    }
}
