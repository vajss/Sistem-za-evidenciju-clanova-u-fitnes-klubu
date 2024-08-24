using FitnesStudioClientApp.User_Controls;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace FitnesStudioClientApp.UIControllers
{
    public class MainViewController
    {

        public void ChangePanel(UserControl userControl, FrmMain frmMain)
        {
            Debug.WriteLine(">>>>>>> outside3 ");

            frmMain.PnlMain.Controls.Clear();
            if (userControl != null)
            {
                Debug.WriteLine(">>>>>>> insode", userControl);

                userControl.Dock = DockStyle.Fill;
                frmMain.PnlMain.Controls.Add(userControl);
            }
        }

        internal void OpenUCDodajClana(FrmMain frmMain)
        {
            Debug.WriteLine(">>>>>>> open UC");
            ChangePanel(new UCDodajClana(new DodajClanaController()), frmMain);
        }
    }
}
