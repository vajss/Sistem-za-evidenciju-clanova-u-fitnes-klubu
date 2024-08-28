using Domain;
using FitnesStudioClientApp.UIControllers;
using System;
using System.Windows.Forms;

namespace FitnesStudioClientApp
{
    public partial class FrmMain : Form
    {

        public MainViewCoordinator mainViewCoordinator = new MainViewCoordinator();
        public FrmMain()
        {
            InitializeComponent();
        }

        public FrmMain(MainViewCoordinator MainViewCoordinator)
        {
            InitializeComponent();
            this.mainViewCoordinator = MainViewCoordinator;
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainController.Instance.LogOut();
            MainController.Instance.OpenLoginForm();
        }

        private void DodajClanaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            mainViewCoordinator.OpenUCDodajClana(this);

        }

        private void dodajGrupuToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            mainViewCoordinator.OpenUCDodajGrupu(this);
        }

        private void naToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            mainViewCoordinator.OpenUCNadjiClanove(this);
        }

        private void pretražiGrupeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            mainViewCoordinator.OpenUCNadjiGrupe(this);
        }

        private void OdjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainController.Instance?.LogOut();
            this.Dispose();
            MainController.Instance.OpenLoginForm();
        }

        private void DodajTerminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainViewCoordinator.OpenUCDodajTermin(this);

        }

        private void PretragaTerminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainViewCoordinator.OpenUCNadjiTermin(this);
        }
    }
}
