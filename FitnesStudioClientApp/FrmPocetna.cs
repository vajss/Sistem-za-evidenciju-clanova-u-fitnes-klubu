using FitnesStudioClientApp.UIControllers;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace FitnesStudioClientApp
{
    public partial class FrmPocetna : Form
    {
        public FrmPocetna()
        {
            Debug.WriteLine(">>> Is this ever called? ");

            InitializeComponent();
        }

        public FrmPocetna(LoginController loginController, RegisterController registerController)
        {
            InitializeComponent();
            PocetnaForma.Instance.Init(loginController, registerController, this);
        }

        public LoginController LoginController { get; }

        private void FrmInitialWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
