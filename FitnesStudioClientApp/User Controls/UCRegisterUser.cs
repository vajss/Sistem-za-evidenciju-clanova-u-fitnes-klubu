using FitnesStudioClientApp.UIControllers;
using System;
using System.Windows.Forms;

namespace FitnesStudioClientApp.User_Controls
{
    public partial class UCRegisterUser : UserControl
    {

        private readonly RegisterController registerController;
        private readonly FrmPocetna frmInitialWindow;
        private readonly LoginController loginController;

        public UCRegisterUser()
        {
            InitializeComponent();
        }

        public UCRegisterUser(RegisterController registerController, FrmPocetna frmInitialWindow, LoginController loginController)
        {
            this.registerController = registerController;
            this.frmInitialWindow = frmInitialWindow;
            this.loginController = loginController;
            InitializeComponent();
            btnRegister.Cursor = Cursors.Hand;
            this.loginController = loginController;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (loginController.Connect())
            {
                registerController.Register(tbName, tbLastName, tbUsername, tbPassword, tbRepeatPassword, lblError, frmInitialWindow, loginController);
            }            
        }
    }
}
