using FitnesStudioClientApp.UIControllers;
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
    }
}
