using FitnesStudioClientApp.UIControllers;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace FitnesStudioClientApp.User_Controls
{
    public partial class UCLogIn : UserControl
    {
        private readonly LoginController loginController;
        FrmPocetna parentForm;

        public UCLogIn()
        {
            InitializeComponent();
        }

        public UCLogIn(LoginController loginController, FrmPocetna frmInitialWindow)
        {
            parentForm = frmInitialWindow;
            this.loginController = loginController;
            InitializeComponent();
            btnShow.Cursor = Cursors.Hand;
            btnLogIn.Cursor = Cursors.Hand;
            // TODO For ease of testing. Remove later
            tbUsername.Text = "Vajss";
            tbPassword.Text = "asdf";
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (loginController.Connect())
            {
                loginController.Login(tbUsername, tbPassword, parentForm, lblError);
            }
            Debug.WriteLine(">>> Log in ");
        }

        private void btnShow_MouseDown(object sender, MouseEventArgs e)
        {
            tbPassword.PasswordChar = '\0';
        }

        private void btnShow_MouseUp(object sender, MouseEventArgs e)
        {
            tbPassword.PasswordChar = '*';
        }
    }
}
