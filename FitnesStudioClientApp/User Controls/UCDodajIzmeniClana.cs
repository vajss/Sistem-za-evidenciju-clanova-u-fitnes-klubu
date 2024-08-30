using Domain;
using FitnesStudioClientApp.UIControllers;
using System;
using System.Windows.Forms;

namespace FitnesStudioClientApp.User_Controls
{
    public partial class UCDodajIzmeniClana : UserControl
    {
        private DodajClanaController dodajClanaController;
        private IzmeniClanaController izmeniClanaController;
        private Clan preselectedClan;
        private FrmMain parentForm;

        public UCDodajIzmeniClana()
        {
            InitializeComponent();
        }

        public UCDodajIzmeniClana(DodajClanaController dodajClanaController)
        {
            InitializeComponent();
            dtpDatumRodjenja.MaxDate = DateTime.Now;
            this.dodajClanaController = dodajClanaController;
        }

        public UCDodajIzmeniClana(IzmeniClanaController izmeniClanaController, Clan clanZaIzmeniti, FrmMain frmMain)
        {
            InitializeComponent();
            parentForm = frmMain;
            dtpDatumRodjenja.MaxDate = DateTime.Now;
            this.izmeniClanaController = izmeniClanaController;
            Clan c = Communication.Communication.Instance.UcitahjClana(clanZaIzmeniti);
            SetupEdit(c);
        }

        private void SetupEdit(Clan clan)
        {
            preselectedClan = clan;

            tbClanId.Text = clan.ClanId.ToString();
            tbClanId.Enabled = false;
            tbIme.Text = clan.Ime;
            tbPrezime.Text = clan.Prezime;
            tbTelefon.Text = clan.Telefon;
            tbZanimanje.Text = clan.Zanimanje;
            dtpDatumRodjenja.Value = clan.DatumRodjenja;
            btnNazad.Visible = true;
            lblNaslov.Text = "Izmena člana";

            btnSacuvajClana.Visible = false;
            btnIzmeniClana.Visible = true;
        }

        private void BtnSacuvajClana_Click(object sender, System.EventArgs e)
        {
            dodajClanaController.DodajClana(tbClanId, tbIme, tbPrezime, dtpDatumRodjenja, tbTelefon, tbZanimanje, lblError);
        }

        private void BtnIzmeniClana_Click(object sender, EventArgs e)
        {
            izmeniClanaController.IzmeniClana(tbClanId, tbIme, tbPrezime, dtpDatumRodjenja, tbTelefon, tbZanimanje, lblError, preselectedClan, parentForm);
        }

        private void BtnNazad_Click(object sender, EventArgs e)
        {
            parentForm.mainViewCoordinator.OpenUCNadjiClanove(parentForm);
        }
    }
}
