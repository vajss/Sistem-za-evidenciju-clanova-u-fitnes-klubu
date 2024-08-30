using Domain;
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

        public UCDodajTermin(DodajTerminController dodajTerminController, Termin termin)
        {
            this.dodajTerminController = dodajTerminController;
            InitializeComponent();
            dodajTerminController.UcitajGrupe(cbGrupa);
            Termin t = Communication.Communication.Instance.UcitahjTermin(termin);

            tbTerminId.Text = t.TerminId.ToString();
            tbTrajanje.Text = t.Trajanje.ToString();
            dtpDatum.Text = t.Datum.ToString();
            cbGrupa.SelectedItem = t.Grupa;
            btnSacuvaj.Visible = false;
        }

        private void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            dodajTerminController.DodajTermin(tbTerminId, cbGrupa, dtpDatum, tbTrajanje, lblError, lblTrajanjeError, lblTerminIdError);
        }
    }
}
