using Domain;
using FitnesStudioClientApp.UIControllers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FitnesStudioClientApp.User_Controls
{
    public partial class UCDodajIzmeniGrupu : UserControl
    {
        private DodajIzmeniGrupuController dodajGrupuController;
        private Grupa grupa;
        private FrmMain parentForm;

        public UCDodajIzmeniGrupu()
        {
            Init();
        }

        public UCDodajIzmeniGrupu(DodajIzmeniGrupuController dodajGrupuController)
        {
            this.dodajGrupuController = dodajGrupuController;
            Init();
        }

        public UCDodajIzmeniGrupu(DodajIzmeniGrupuController dodajGrupuController, Grupa grupa, FrmMain parentForm)
        {
            this.dodajGrupuController = dodajGrupuController;
            this.grupa = grupa;
            this.parentForm = parentForm;
            Init(grupa.Clanstva);
            SetupEdit(grupa);
        }

        private void SetupEdit(Grupa grupa)
        {
            btnSacuvajGrupu.Visible = false;
            btnIzmeniGrupu.Visible = true;
            btnNazad.Visible = true;

            tbNazivGrupe.Text = grupa.Naziv;
            tbBrojClanova.Text = grupa.BrojClanova.ToString();
        }

        private void Init(List<Clanstvo> clanstva = null)
        {
            InitializeComponent();
            tbNeizmireno.Text = "0 RSD";
            dodajGrupuController.SetDateLimits(dtpPoslednjePlacanje, dtpUclanjenje);
            dodajGrupuController.SetDataGridView(dgvClanstva, clanstva);
            cbTreningProgram.SelectionChangeCommitted += new System.EventHandler(CalculateDebt);
        }

        private void BtnObrisiClanove_Click(object sender, EventArgs e)
        {
            dodajGrupuController.RemoveMembers(dgvClanstva, lblGroupError);
            dodajGrupuController.OnRowCountChange(cbTreningProgram, tbBrojClanova, btnObrisiClanove);
        }

        private void BtnSacuvajGrupu_Click(object sender, EventArgs e)
        {
            dodajGrupuController.SacuvajGrupu(cbTreningProgram, tbNazivGrupe, tbBrojClanova, dgvClanstva, lblGroupError);
            dodajGrupuController.ResetFields(cbClanovi, tbNeizmireno, dtpPoslednjePlacanje, dtpUclanjenje);
        }

        private void UCDodajGrupu_Load(object sender, EventArgs e)
        {
            dodajGrupuController.UcitajClanove(cbClanovi);
            dodajGrupuController.UcitajTreningPrograme(cbTreningProgram);
            if (grupa is Grupa g)
            {
                cbTreningProgram.SelectedItem = g.TreningProgram;
            }
        }

        private void BtnDodajClana_Click(object sender, EventArgs e)
        {
            dodajGrupuController.DodajClanstvoUGrupu(cbClanovi, tbBrojClanova, dgvClanstva, dtpUclanjenje, dtpPoslednjePlacanje, tbNeizmireno, btnObrisiClanove, lblError);
        } 

        private void CalculateDebt(object sender, EventArgs e)
        {
            dodajGrupuController.SetDateLimits(dtpPoslednjePlacanje, dtpUclanjenje);
            if (cbTreningProgram.SelectedIndex == -1) return;
            tbNeizmireno.Text = dodajGrupuController.GetDebt(dtpPoslednjePlacanje.Value, cbTreningProgram).ToString() + " RSD";
        }

        private void tbNazivGrupe_TextChanged(object sender, EventArgs e)
        {
            tbNazivGrupe.BackColor = Color.White;
        }

        private void cbTreningProgram_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dodajGrupuController.RecalculateDebt(cbTreningProgram, dgvClanstva);
            cbTreningProgram.BackColor = Color.White;
        }

        private void dgvClanstva_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            dodajGrupuController.OnRowCountChange(cbTreningProgram, tbBrojClanova, btnObrisiClanove);
        }

        private void BtnIzmeniClanstvo_Click(object sender, EventArgs e)
        {
            dodajGrupuController.IzmeniClanstvo(cbClanovi, dtpUclanjenje, dtpPoslednjePlacanje, tbNeizmireno, lblError);
        }

        private void DgvClanstva_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClanstva.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dgvClanstva.SelectedRows[0];
                if (selectedRow.DataBoundItem is Clanstvo selectedClanstvo)
                {
                    dodajGrupuController.SetClanstvoToChange(cbClanovi, selectedClanstvo, dtpUclanjenje, dtpPoslednjePlacanje, tbNeizmireno);
                }
            }
        }

        private void btnIzmeniGrupu_Click(object sender, EventArgs e)
        {
            dodajGrupuController.SacuvajGrupu(cbTreningProgram, tbNazivGrupe, tbBrojClanova, dgvClanstva, lblGroupError, true);
        }

        private void BtnIzmeniGrupu_button_Click(object sender, EventArgs e)
        {
            parentForm.mainController.OpenUCNadjiGrupe(parentForm);
        }
    }
}
