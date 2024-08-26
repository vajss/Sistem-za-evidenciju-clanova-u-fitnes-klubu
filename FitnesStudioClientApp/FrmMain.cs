using Domain;
using FitnesStudioClientApp.UIControllers;
using System;
using System.Windows.Forms;

namespace FitnesStudioClientApp
{
    public partial class FrmMain : Form
    {

        public MainViewController mainController = new MainViewController();
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
            MainCoordinator.Instance.LogOut();
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

        private void pretražiGrupeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            mainController.OpenUCNadjiGrupe(this);
        }

        private void pocetnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenPocetna(this);
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainCoordinator.Instance?.LogOut();
            this.Dispose();
            MainCoordinator.Instance.OpenLoginForm();
        }
    }
}
