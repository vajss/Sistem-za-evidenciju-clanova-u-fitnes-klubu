using Domain;
using FitnesStudioClientApp.User_Controls;
using System;
using System.Windows.Forms;

namespace FitnesStudioClientApp.UIControllers
{
    public class PocetnaForma
    {
        FrmPocetna frmInitialWindow;
        LoginController loginController;
        RegisterController registerController;

        private static PocetnaForma instance;
        private PocetnaForma(){}

        private static readonly object syncRoot = new object();

        public Trener Trener { get; internal set; }

        public static PocetnaForma Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new PocetnaForma();
                        }
                    }
                }
                return instance;
            }
        }

        internal void Init(LoginController loginController, RegisterController registerController, FrmPocetna frmInitialWindow)
        {
            this.loginController = loginController;
            this.frmInitialWindow = frmInitialWindow;
            this.registerController = registerController;
            frmInitialWindow.BtnLogIn.Click += BtnLogIn_Click;
            frmInitialWindow.BtnRegister.Click += BtnRegister_Click;
            frmInitialWindow.BtnNazad.Click += BtnNazad_Click;
            frmInitialWindow.BtnNazad.Cursor = Cursors.Hand;
            frmInitialWindow.BtnRegister.Cursor = Cursors.Hand;
            frmInitialWindow.BtnLogIn.Cursor = Cursors.Hand;
        }

        private void BtnNazad_Click(object sender, EventArgs e)
        {
            ChangePanel();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCRegisterUser(registerController, frmInitialWindow, loginController));
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCLogIn(loginController, frmInitialWindow));
        }

        private void ChangeButtonsVisibility()
        {
            frmInitialWindow.BtnRegister.Visible = !frmInitialWindow.BtnRegister.Visible;
            frmInitialWindow.BtnLogIn.Visible = !frmInitialWindow.BtnLogIn.Visible;
            frmInitialWindow.BtnNazad.Visible = !frmInitialWindow.BtnNazad.Visible;
        }

        public void ChangePanel(UserControl userControl = null)
        {
            ChangeButtonsVisibility();
            frmInitialWindow.PnlMain.Controls.Clear();
            if(userControl != null)
            {
                userControl.Dock = DockStyle.Fill;
                frmInitialWindow.PnlMain.Controls.Add(userControl);
            }
        }
    }
}
