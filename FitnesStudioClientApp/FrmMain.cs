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

        private void DodajClanaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            mainController.OpenUCDodajClana(this);

        }

        private void dodajGrupuToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            mainController.OpenUCDodajGrupu(this);
        }

        private void naToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            mainController.OpenUCNadjiClanove(this);
        }
    }
}
