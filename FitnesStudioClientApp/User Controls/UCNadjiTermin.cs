using FitnesStudioClientApp.UIControllers;
using System;
using System.Windows.Forms;

namespace FitnesStudioClientApp.User_Controls
{
    public partial class UCNadjiTermin : UserControl
    {
        private NadjiTerminController nadjiTerminController;

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

        private void BtnPretrazi_Click(object sender, EventArgs e)
        {
            nadjiTerminController.PretraziTermine(tbPretraga, dgvTermini, lblError);
        }
    }
}
