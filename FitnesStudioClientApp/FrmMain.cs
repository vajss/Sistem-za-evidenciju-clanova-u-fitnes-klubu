using FitnesStudioClientApp.UIControllers;
using FitnesStudioClientApp.User_Controls;
using System.Windows.Forms;

namespace FitnesStudioClientApp
{
    public partial class FrmMain : Form
    {

        MainViewController mainController = new MainViewController();

        public FrmMain()
        {
            InitializeComponent();
        }

        public FrmMain(MainViewController mainController)
        {
            InitializeComponent();
            this.mainController = mainController;
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainCoordinator.Instance.OpenLoginForm();
        }

        private void dodajČlanaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            //mainController.ChangePanel(new UCDodajClana(new DodajClanaController()), this);
            //mainController.OpenUCDodajClana(this);

            PnlMain.Controls.Clear();
      /*      if (userControl != null)
            {*/
            Dock = DockStyle.Fill;
            PnlMain.Controls.Add(new UCDodajClana(new DodajClanaController()));
            //}
        }
    }
}
