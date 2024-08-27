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
    public partial class UCDodajTermin : UserControl
    {
        private DodajTerminController dodajTerminController;

        public UCDodajTermin()
        {
            InitializeComponent();
        }

        public UCDodajTermin(DodajTerminController dodajTerminController)
        {
            this.dodajTerminController = dodajTerminController;
            InitializeComponent();
            dodajTerminController.UcitajGrupe(cbGrupa);
        }

        private void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            dodajTerminController.DodajTermin(tbTerminId, cbGrupa, dtpDatum, tbTrajanje, lblError, lblTrajanjeError, lblTerminIdError);
        }
    }
}
