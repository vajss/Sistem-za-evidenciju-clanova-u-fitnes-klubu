using FitnesStudioClientApp.UIControllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnesStudioClientApp.User_Controls
{
    public partial class UCNadjiClanove : UserControl
    {
        private NadjiClanoveController nadjiClanoveController;

        public UCNadjiClanove()
        {
            InitializeComponent();
        }

        public UCNadjiClanove(NadjiClanoveController nadjiClanoveController)
        {
            this.nadjiClanoveController = nadjiClanoveController;
            InitializeComponent();
            this.nadjiClanoveController.SetGrid(dgvClanovi);
        }

        private void BtnIzmeni_Click(object sender, EventArgs e)
        {

        }

        private void BtnPretrazi_Click(object sender, EventArgs e)
        {
            nadjiClanoveController.PretraziClanove(tbPretraga, dgvClanovi, lblError);
        }
    }
}
