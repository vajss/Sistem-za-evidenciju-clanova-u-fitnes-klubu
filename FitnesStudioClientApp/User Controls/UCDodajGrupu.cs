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
            this.dodajGrupuController = dodajGrupuController;
            InitializeComponent();
        }

        private void TbClanId_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblNaziv_Click(object sender, EventArgs e)
        {

        }

        private void BtnObrisiClanove_Click(object sender, EventArgs e)
        {

        }

        private void BtnSacuvajGrupu_Click(object sender, EventArgs e)
        {

        }

        private void UCDodajGrupu_Load(object sender, EventArgs e)
        {
            dodajGrupuController.UcitajClanove(cbClanovi);
        }
    }
}
