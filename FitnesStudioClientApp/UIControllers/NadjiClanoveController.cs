using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace FitnesStudioClientApp.UIControllers
{
    public class NadjiClanoveController
    {
        internal void SetGrid(DataGridView dgvClanovi)
        {
            dgvClanovi.DataSource = new BindingList<Clan>();
            SetGridColumnProperties(dgvClanovi);
        }

        internal void PretraziClanove(TextBox tbPretraga, DataGridView dgvClanovi, Label lblError)
        {
            if (string.IsNullOrWhiteSpace(tbPretraga.Text))
            {
                return;
            }

            try
            {
                Clan clan = new Clan();
                clan.GCondition = $"C.Ime LIKE '%{tbPretraga.Text}%' OR C.Prezime LIKE '%{tbPretraga.Text}%'";
                BindingList<Clan> clanovi = new BindingList<Clan>(Communication.Communication.Instance.PretraziClanove(clan));
                if (clanovi?.Count != 0 && clanovi?.Count != null)
                {
                    dgvClanovi.DataSource = clanovi;
                    dgvClanovi.Refresh();
                    SetGridColumnProperties(dgvClanovi);
                    lblError.Text = "";
                } else
                {
                    dgvClanovi.Rows.Clear();
                    lblError.Text = "Nema rezultata za datu pretragu";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška pri Pretrazi članova.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetGridColumnProperties(DataGridView dgvClanovi)
        {
            dgvClanovi.Columns["DatumRodjenja"].HeaderText = "Datum rođenja";
            dgvClanovi.Columns["DatumRodjenja"].DefaultCellStyle.Format = "dd.MM.yyyy.";
            dgvClanovi.Columns["ClanId"].DefaultCellStyle.Format = "D6";
            dgvClanovi.Columns["Id"].Visible = false;
        }
    }
}
