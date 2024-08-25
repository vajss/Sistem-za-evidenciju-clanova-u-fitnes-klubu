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
            dodajGrupuController.SetDateLimits(dtpPoslednjePlacanje, dtpUclanjenje);
        }

        private void TbClanId_TextChanged(object sender, EventArgs e)
        {
            cbClanovi.BackColor = Color.White;
        }


        private void BtnObrisiClanove_Click(object sender, EventArgs e)
        {

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
            dodajGrupuController.DodajClanstvoUGrupu(cbClanovi, tbBrojClanova, dgvClanstva, dtpUclanjenje, dtpPoslednjePlacanje, tbNeizmireno, lblError);
        }

        private void CalculateDebt(object sender, EventArgs e)
        {
            dodajGrupuController.SetDateLimits(dtpPoslednjePlacanje, dtpUclanjenje);

            if (cbTreningProgram.SelectedIndex == -1)
            {
                return;
            }

            tbNeizmireno.Text = dodajGrupuController.GetMonthsDifference(dtpUclanjenje.Value, dtpPoslednjePlacanje.Value, cbTreningProgram).ToString() + " RSD";
        }
    }
}
