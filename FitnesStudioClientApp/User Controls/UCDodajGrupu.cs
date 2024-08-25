using FitnesStudioClientApp.UIControllers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FitnesStudioClientApp.User_Controls
{
    public partial class UCDodajGrupu : UserControl
    {
        private DodajGrupuController dodajGrupuController;

        public UCDodajGrupu()
        {
            InitializeComponent();
        }

        public UCDodajGrupu(DodajGrupuController dodajGrupuController)
        {
            // TODO should have input that says if we are editing or creating group
            // and then change buttons based on that.

            this.dodajGrupuController = dodajGrupuController;
            InitializeComponent();
            tbNeizmireno.Text = "0 RSD";
            dodajGrupuController.SetDateLimits(dtpPoslednjePlacanje, dtpUclanjenje);
            dodajGrupuController.SetDataGridView(dgvClanstva);
            cbTreningProgram.SelectionChangeCommitted += new System.EventHandler(CalculateDebt);
        }

        private void BtnObrisiClanove_Click(object sender, EventArgs e)
        {
            dodajGrupuController.RemoveMembers(dgvClanstva);
            dodajGrupuController.OnRowcountChange(dgvClanstva, cbTreningProgram, tbBrojClanova, btnObrisiClanove);
        }

        private void BtnSacuvajGrupu_Click(object sender, EventArgs e)
        {
            //dodajGrupuController.SacuvajGrupu();
        }

        private void UCDodajGrupu_Load(object sender, EventArgs e)
        {
            dodajGrupuController.UcitajClanove(cbClanovi);
            dodajGrupuController.UcitajTreningPrograme(cbTreningProgram);
        }

        private void BtnDodajClana_Click(object sender, EventArgs e)
        {
            dodajGrupuController.DodajClanstvoUGrupu(cbClanovi, tbBrojClanova, dgvClanstva, dtpUclanjenje, dtpPoslednjePlacanje, tbNeizmireno, cbTreningProgram, btnObrisiClanove, lblError);
        } 

        private void CalculateDebt(object sender, EventArgs e)
        {
            dodajGrupuController.SetDateLimits(dtpPoslednjePlacanje, dtpUclanjenje);
            cbTreningProgram.BackColor = Color.White;
            if (cbTreningProgram.SelectedIndex == -1) return;
            tbNeizmireno.Text = dodajGrupuController.GetDebt(dtpPoslednjePlacanje.Value, cbTreningProgram).ToString() + " RSD";
        }

        private void tbNazivGrupe_TextChanged(object sender, EventArgs e)
        {
            tbNazivGrupe.BackColor = Color.White;
        }

        private void cbTreningProgram_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (!gbDodajClanove.Visible && cbTreningProgram.SelectedIndex != -1)
            {
                gbDodajClanove.Visible = true;
                // tbNeizmireno.Text = dodajGrupuController.GetDebt(dtpPoslednjePlacanje.Value, cbTreningProgram).ToString() + " RSD";
                // tbNeizmireno.Text = dodajGrupuController.GetDebt(dtpPoslednjePlacanje.Value, cbTreningProgram).ToString() + " RSD";
            }
        }

        private void dgvClanstva_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            dodajGrupuController.OnRowcountChange(dgvClanstva, cbTreningProgram, tbBrojClanova, btnObrisiClanove);
        }


        // TODO blokiraj program promenu ako su clanovi vec dodati.
        // Mozda sakrij celu grupu ako nije odabaran
    }
}
