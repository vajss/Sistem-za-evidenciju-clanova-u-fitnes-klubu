using FitnesStudioClientApp.User_Controls;
using System.Windows.Forms;

namespace FitnesStudioClientApp.UIControllers
{
    public class MainViewController
    {

        public void ChangePanel(UserControl userControl, FrmMain frmMain)
        {
            frmMain.PnlMain.Controls.Clear();
            if (userControl != null)
            {
                userControl.Dock = DockStyle.Fill;
                frmMain.PnlMain.Controls.Add(userControl);
            }
        }

        internal void OpenUCDodajClana(FrmMain frmMain)
        {
            ChangePanel(new UCDodajClana(new DodajClanaController()), frmMain);
        }

        internal void OpenUCDodajGrupu(FrmMain frmMain)
        {
            ChangePanel(new UCDodajGrupu(new DodajGrupuController()), frmMain);
        }

        internal void OpenUCNadjiClanove(FrmMain frmMain)
        {
            ChangePanel(new UCNadjiClanove(new NadjiClanoveController()), frmMain);
        }
    }
}
