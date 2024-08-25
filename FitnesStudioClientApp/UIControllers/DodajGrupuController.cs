using Domain;
using FitnesStudioClientApp.Helpers;
using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using View.Exceptions;


namespace FitnesStudioClientApp.UIControllers
{
    public class DodajGrupuController
    {
        BindingList<Clanstvo> clanstva = new BindingList<Clanstvo>();

        internal void DodajClanstvoUGrupu(ComboBox cbClanovi, TextBox tbBrojClanova, DataGridView dgvClanstva, DateTimePicker dtpUclanjenje, DateTimePicker dtpPoslednjePlacanje, TextBox tbNeizmireno, ComboBox cbTreningProgram, Button btnObrisiClanove,  Label lblError)
        {
            if (!UserControlHelpers.ComboBoxValidation(cbClanovi, lblError) |
                !UserControlHelpers.CompareDatesValidation(dtpUclanjenje, dtpPoslednjePlacanje, lblError, "Učlanjenje ne može biti neako poslednjeg plaćanja.")
               )
            {

                lblError.Visible = true;
                return;
            }

            string[] parts = tbNeizmireno.Text.Split(' ');
            string numberPart = parts[0];
            int neizmirenaDugovanja = int.Parse(numberPart);

            Clanstvo clanstvo = new Clanstvo
            {
                Clan = (Clan)cbClanovi.SelectedItem,
                DatumPoslednjegPlacanja = dtpPoslednjePlacanje.Value,
                DatumUclanjenja = dtpUclanjenje.Value,
                NeizmirenaDugovanja = neizmirenaDugovanja
            };

            if (clanstva.Contains(clanstvo))
            {
                lblError.Text = "Član već dodat u grupu.";
                lblError.Visible = true;
                return;
            }

            clanstva.Add( clanstvo );
            tbBrojClanova.Text = clanstva.Count.ToString();
            dgvClanstva.Refresh();
            lblError.Visible = false;
            cbTreningProgram.Enabled = false;
            btnObrisiClanove.Enabled = true;
        }

        internal void UcitajClanove(ComboBox cmbClan)
        {
            try
            {
                cmbClan.DataSource = Communication.Communication.Instance.VratiClanove();
                cmbClan.SelectedIndex = -1;
                cmbClan.Text = "Izaberi člana";
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message, "Greška pri uitavanju.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        internal int GetDebt(DateTime endDate, ComboBox program)
        {
            int price = ((TreningProgram)(program.SelectedItem)).Cena;
            int yearDifference = (DateTime.Now).Year - endDate.Year;
            int monthDifference = (DateTime.Now).Month - endDate.Month;

            return (yearDifference * 12 + monthDifference) * price;
        }

        internal void UcitajTreningPrograme(ComboBox cbTreningProgram)
        {
            try
            {
                cbTreningProgram.DataSource = Communication.Communication.Instance.VratiTrerningPrograme();
                cbTreningProgram.SelectedIndex = -1;
                cbTreningProgram.Text = "Izaberi Trening program.";
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message, "Greška pri ucitavanju.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void SetDateLimits(DateTimePicker dtpPoslednjePlacanje, DateTimePicker dtpUclanjenje)
        {
            dtpUclanjenje.MaxDate = DateTime.Now;
            dtpPoslednjePlacanje.MinDate = dtpUclanjenje.Value.AddHours(-1);
            dtpPoslednjePlacanje.MaxDate = DateTime.Now;
        }

        internal void SetDataGridView(DataGridView dgvClanstva)
        {
            dgvClanstva.DataSource = clanstva;
            dgvClanstva.Columns["DatumUclanjenja"].HeaderText = "Datum učlanjenja";
            dgvClanstva.Columns["DatumPoslednjegPlacanja"].HeaderText = "Poslednja članarina plaćena";
            dgvClanstva.Columns["Clan"].HeaderText = "Član";
            dgvClanstva.Columns["NeizmirenaDugovanja"].HeaderText = "Neizmirena dugovanja";
            dgvClanstva.Columns["Grupa"].Visible = false;
        }

        internal void OnRowcountChange(DataGridView dgvClanstva, ComboBox cbTreningProgram, TextBox tbBrojClanova, Button btnObrisiClanove)
        {
            if (clanstva.Count == 0)
            {
                cbTreningProgram.Enabled = true;
                btnObrisiClanove.Enabled = false;
            }
            else {
                btnObrisiClanove.Enabled = true;
            }
            tbBrojClanova.Text = clanstva.Count.ToString();
        }

        internal void RemoveMembers(DataGridView dgvClanstva)
        {
            foreach (DataGridViewRow row in dgvClanstva.SelectedRows)
            {
                Clanstvo member = row.DataBoundItem as Clanstvo;
                if (member != null)
                {
                    clanstva.Remove(member);
                }
            }

        }

        internal void SacuvajGrupu(ComboBox cbTreningProgram, TextBox tbNazivGrupe, TextBox tbBrojClanova, DataGridView dgvClanstva, GroupBox gbDodajClanove, Label lblError)
        {
            if (!UserControlHelpers.ComboBoxValidation(cbTreningProgram, lblError) |
                !UserControlHelpers.EmptyFieldValidation(tbNazivGrupe, lblError)
            )
            {
                lblError.Visible = true;
                return;
            }
            try
            {
                lblError.Visible = false;
                Grupa g = new Grupa
                {
                    Naziv = tbNazivGrupe.Text,
                    BrojClanova = Int32.Parse(tbBrojClanova.Text),
                    TreningProgram = cbTreningProgram.SelectedItem as TreningProgram,
                    Clanstva = clanstva.ToList()
                };
                g = Communication.Communication.Instance.SacuvajGrupu(g);

                MessageBox.Show("Grupa uspešno sačuvana.");

                tbNazivGrupe.Text = "";
                cbTreningProgram.SelectedIndex = -1;
                cbTreningProgram.Enabled = true;
                tbBrojClanova.Text = "";
                dgvClanstva.Rows.Clear();
                dgvClanstva.Refresh();
                gbDodajClanove.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška čuvanju grupe.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
