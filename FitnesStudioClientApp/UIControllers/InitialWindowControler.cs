using FitnesStudioClientApp.User_Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnesStudioClientApp.UIControllers
{
    public class InitialWindowControler
    {
        FrmInitialWindow frmInitialWindow;

        private static InitialWindowControler instance;
        private InitialWindowControler(){}

        private static readonly object syncRoot = new object();

        public static InitialWindowControler Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new InitialWindowControler();
                        }
                    }
                }
                return instance;
            }
        }

        internal void Init(FrmInitialWindow frmInitialWindow)
        {
            this.frmInitialWindow = frmInitialWindow;
            frmInitialWindow.BtnLogIn.Click += BtnLogIn_Click;
            frmInitialWindow.BtnRegister.Click += BtnRegister_Click;
            frmInitialWindow.BtnNazad.Click += BtnNazad_Click;
        }

        private void BtnNazad_Click(object sender, EventArgs e)
        {
            ChangePanel();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCRegisterUser());
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCLogIn());
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
