using FitnesStudioClientApp.User_Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnesStudioClientApp.UIControllers
{
    internal class InitialWindowControler
    {
        FrmInitialWindow frmInitialWindow;

        internal void Init(FrmInitialWindow frmInitialWindow)
        {
            this.frmInitialWindow = frmInitialWindow;
            frmInitialWindow.BtnLogIn.Click += BtnLogIn_Click;
            frmInitialWindow.BtnRegister.Click += BtnRegister_Click;

        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCRegisterUser());
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCLogIn());
        }

        private void ChangePanel(UserControl userControl)
        {
            frmInitialWindow.PnlMain.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            frmInitialWindow.PnlMain.Controls.Add(userControl);
        }
    }
}
