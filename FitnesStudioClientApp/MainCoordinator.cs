using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnesStudioClientApp.UIControllers
{
    public class MainCoordinator
    {

        private readonly MainViewController mainController = new MainViewController();
        private readonly LoginController loginController = new LoginController();
        private readonly RegisterController registerController = new RegisterController();
        private FrmInitialWindow frmLogin;
        private FrmMain frmMain;

        private static MainCoordinator instance;
        private MainCoordinator() { }

        public static MainCoordinator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MainCoordinator();
                }
                return instance;
            }
        }

        public Trener Trener { get; internal set; }

        public void OpenLoginForm()
        {
            frmLogin = new FrmInitialWindow(loginController, registerController);
            frmLogin.Show();
        }

        public void OpenMainForm()
        {
            frmMain = new FrmMain(mainController);
            frmMain.Show();
        }
    }
}
