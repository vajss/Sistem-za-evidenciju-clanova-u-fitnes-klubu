using FitnesStudioClientApp.UIControllers;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace FitnesStudioClientApp
{
    public partial class FrmPocetna : Form
    {
        public LoginController LoginController { get; }

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

        

        private void FrmInitialWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Environment.Exit(0);
        }
    }
}
