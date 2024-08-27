using Domain;
using FitnesStudioClientApp.UIControllers;
using System;
using System.Windows.Forms;

namespace FitnesStudioClientApp.User_Controls
{
    public partial class UCNadjiClanove : UserControl
    {
        private NadjiClanoveController nadjiClanoveController;
        private FrmMain parentForm;

        public UCNadjiClanove()
        {
            InitializeComponent();
        }

        public UCNadjiClanove(NadjiClanoveController nadjiClanoveController, FrmMain parentForm)
        {
            this.parentForm = parentForm;
            this.nadjiClanoveController = nadjiClanoveController;
            InitializeComponent();
            this.nadjiClanoveController.SetGrid(dgvClanovi);
        }

        private void BtnIzmeni_Click(object sender, EventArgs e)
        {
            nadjiClanoveController.IzmeniClana(parentForm, (Clan)dgvClanovi.CurrentRow?.DataBoundItem, lblIzmeniError);
        }

        private void BtnPretrazi_Click(object sender, EventArgs e)
        {
            nadjiClanoveController.PretraziClanove(tbPretraga, dgvClanovi, lblError);
        }

        private void TbPretraga_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nadjiClanoveController.PretraziClanove(tbPretraga, dgvClanovi, lblError);
                e.SuppressKeyPress = true;
            }
        }
    }
}
