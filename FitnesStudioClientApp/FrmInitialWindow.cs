using FitnesStudioClientApp.UIControllers;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace FitnesStudioClientApp
{
    public partial class FrmInitialWindow : Form
    {
        public FrmInitialWindow()
        {
            Debug.WriteLine(">>> Is this ever called? ");

            InitializeComponent();
        }

        public FrmInitialWindow(LoginController loginController, RegisterController registerController)
        {
            InitializeComponent();
            InitialWindowControler.Instance.Init(loginController, registerController, this);
        }

        public LoginController LoginController { get; }

        private void FrmInitialWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
