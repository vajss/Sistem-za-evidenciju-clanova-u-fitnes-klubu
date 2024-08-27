using Domain;
using FitnesStudioClientApp.UIControllers;
using System.Windows.Forms;

namespace FitnesStudioClientApp.User_Controls
{
    public partial class UCNadjiGrupe : UserControl
    {
        private NadjiGrupeController nadjiGrupeController;
        private FrmMain parentForm;

        public UCNadjiGrupe()
        {
            InitializeComponent();
        }

        public UCNadjiGrupe(NadjiGrupeController nadjiGrupeController, FrmMain frmMain)
        {
            this.nadjiGrupeController = nadjiGrupeController;
            this.parentForm = frmMain;
            InitializeComponent();
            this.nadjiGrupeController.SetGrid(dgvGrupe);
        }

        private void BtnPretrazi_Click(object sender, System.EventArgs e)
        {
            nadjiGrupeController.PretraziGrupe(tbPretraga, dgvGrupe, lblError);
        }

        private void tbPretraga_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nadjiGrupeController.PretraziGrupe(tbPretraga, dgvGrupe, lblError);
                e.SuppressKeyPress = true;
            }
        }

        private void btnIzmeniGrupu_Click(object sender, System.EventArgs e)
        {
            nadjiGrupeController.IzmeniGrupu(parentForm, (Grupa)dgvGrupe.CurrentRow?.DataBoundItem, lblIzmenaError);
        }
    }
}
