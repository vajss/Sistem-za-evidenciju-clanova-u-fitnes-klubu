using Domain;
using FitnesStudioClientApp.UIControllers;
using System;
using System.Windows.Forms;

namespace FitnesStudioClientApp
{
    public partial class FrmMain : Form
    {

        public MainViewCoordinator mainController = new MainViewCoordinator();
        public FrmMain()
        {
            InitializeComponent();
        }

        public FrmMain(MainViewCoordinator mainController)
        {
            InitializeComponent();
            this.mainController = mainController;
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainController.Instance.LogOut();
            MainController.Instance.OpenLoginForm();
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

        private void pretražiGrupeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            mainController.OpenUCNadjiGrupe(this);
        }

        private void OdjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainController.Instance?.LogOut();
            this.Dispose();
            MainController.Instance.OpenLoginForm();
        }

        private void DodajTerminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCDodajTermin(this);

        }

        private void PretragaTerminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCNadjiTermin(this);
        }
    }
}
