using Domain;
using FitnesStudioClientApp.UIControllers;
using System;
using System.Windows.Forms;

namespace FitnesStudioClientApp.User_Controls
{
    public partial class UCNadjiTermin : UserControl
    {
        private NadjiTerminController nadjiTerminController;
        private FrmMain parentForm;

        public UCNadjiTermin()
        {
            InitializeComponent();
        }

        public UCNadjiTermin(NadjiTerminController nadjiTerminController)
        {
            this.nadjiTerminController = nadjiTerminController;
            InitializeComponent();
            nadjiTerminController.SetGrid(dgvTermini);
        }

        public UCNadjiTermin(NadjiTerminController nadjiTerminController, FrmMain frmMain)
        {
            parentForm = frmMain;
            this.nadjiTerminController = nadjiTerminController;
            InitializeComponent();
            nadjiTerminController.SetGrid(dgvTermini);
        }

        private void BtnPretrazi_Click(object sender, EventArgs e)
        {
            nadjiTerminController.PretraziTermine(tbPretraga, dgvTermini, lblError);
        }

        private void TbPretraga_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nadjiTerminController.PretraziTermine(tbPretraga, dgvTermini, lblError);
                e.SuppressKeyPress = true;
            }
        }

        private void BtnPrikazi_Click(object sender, EventArgs e)
        {
            nadjiTerminController.PrikaziTermin(parentForm, (Termin)dgvTermini.CurrentRow?.DataBoundItem, lblPrikaziError);
        }
    }
}
