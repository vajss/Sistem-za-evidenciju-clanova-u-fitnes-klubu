using Domain;
using FitnesStudioClientApp.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting;
using System.Windows.Forms;
using View.Exceptions;


namespace FitnesStudioClientApp.UIControllers
{
    public class DodajIzmeniGrupuController
    {
        BindingList<Clanstvo> clanstva = new BindingList<Clanstvo>();

        internal void DodajClanstvoUGrupu(ComboBox cbClanovi, TextBox tbBrojClanova, DataGridView dgvClanstva, DateTimePicker dtpUclanjenje, DateTimePicker dtpPoslednjePlacanje, TextBox tbNeizmireno, Button btnObrisiClanove,  Label lblError)
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
            btnObrisiClanove.Enabled = true;
        }

        internal void UcitajClanove(ComboBox cmbClan)
        {
            try
            {
                cmbClan.DataSource = Communication.Communication.Instance.VratiSveClanove();
                cmbClan.SelectedIndex = -1;
                cmbClan.Text = "Izaberi člana";
            }
            catch (ServerException se)
            {
                throw se;
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
            catch (ServerException se)
            {
                throw se;
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message, "Greška pri ucitavanju.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void SetDateLimits(DateTimePicker dtpPoslednjePlacanje, DateTimePicker dtpUclanjenje)
        {
            try
            {
                dtpUclanjenje.MaxDate = DateTime.Now.AddMinutes(1);
                dtpPoslednjePlacanje.MinDate = dtpUclanjenje.Value.AddHours(-1);
                dtpPoslednjePlacanje.MaxDate = DateTime.Now;
            }
            catch (Exception e){
                Debug.WriteLine($"Datumi: {e.Message}");
            }
        }

        internal void SetDataGridView(DataGridView dgvClanstva, List<Clanstvo> existingClanstva = null)
        {
            if (!(existingClanstva?.Count == 0) && existingClanstva != null)
            {
                clanstva = new BindingList<Clanstvo>(existingClanstva);
            }

            dgvClanstva.DataSource = clanstva;
            dgvClanstva.Columns["DatumUclanjenja"].HeaderText = "Datum učlanjenja";
            dgvClanstva.Columns["DatumUclanjenja"].DefaultCellStyle.Format = "dd.MM.yyyy.";
            dgvClanstva.Columns["DatumPoslednjegPlacanja"].HeaderText = "Poslednja članarina plaćena";
            dgvClanstva.Columns["DatumPoslednjegPlacanja"].DefaultCellStyle.Format = "dd.MM.yyyy.";
            dgvClanstva.Columns["Clan"].HeaderText = "Član";
            dgvClanstva.Columns["NeizmirenaDugovanja"].HeaderText = "Neizmirena dugovanja";
            dgvClanstva.Columns["Grupa"].Visible = false;
        }

        internal void OnRowCountChange(ComboBox cbTreningProgram, TextBox tbBrojClanova, Button btnObrisiClanove)
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

        internal void RemoveMembers(DataGridView dgvClanstva, Label lblError)
        {
            if (dgvClanstva.SelectedRows?.Count == 0)
            {
                lblError.Visible = true;
                lblError.Text = "Nema izabranih clanstava za obrisati.";
                return;
            }

            lblError.Visible = false;
            lblError.Text = "";

            foreach (DataGridViewRow row in dgvClanstva.SelectedRows)
            {
                Clanstvo member = row.DataBoundItem as Clanstvo;
                if (member != null)
                {
                    clanstva.Remove(member);
                }
            }

        }

        internal void SacuvajGrupu(ComboBox cbTreningProgram, TextBox tbNazivGrupe, TextBox tbBrojClanova, DataGridView dgvClanstva, Label lblError, bool izmeni = false, Grupa grupa = null, FrmMain parentForm = null)
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

                if (izmeni)
                {
                    g.Id = grupa.Id;
                }

                g = izmeni ? Communication.Communication.Instance.IzmeniGrupu(g) : Communication.Communication.Instance.SacuvajGrupu(g);

                MessageBox.Show(izmeni ? "Grupa uspešno izmenjena." : "Grupa uspešno sačuvana.");

                tbNazivGrupe.Text = "";
                cbTreningProgram.SelectedIndex = -1;
                tbBrojClanova.Text = "";
                dgvClanstva.Rows.Clear();
                dgvClanstva.Refresh();

                if (izmeni)
                {
                    parentForm.mainController.OpenUCNadjiGrupe(parentForm);
                }                
            }
            catch (ServerException se)
            {
                throw se;
            }
            catch (Exception ex)
            {
                string messageType = izmeni ? "izmeni" : "čuvanju";
                MessageBox.Show(ex.Message, $"Greška pri {messageType} grupe.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void RecalculateDebt(ComboBox cbTreningProgram, DataGridView dgvClanstva)
        {
            foreach (Clanstvo c in clanstva)
            {
                c.NeizmirenaDugovanja = GetDebt(c.DatumPoslednjegPlacanja, cbTreningProgram);
            }
            dgvClanstva.Refresh();
        }

        internal void ResetFields(ComboBox cbClanovi, TextBox tbNeizmireno, DateTimePicker dtpPoslednjePlacanje, DateTimePicker dtpUclanjenje)
        {
            cbClanovi.SelectedIndex = -1;
            tbNeizmireno.Text = "0 RSD";
            dtpPoslednjePlacanje.Value = DateTime.Now.AddHours(-1);
            dtpUclanjenje.Value = DateTime.Now.AddHours(-2); ;
        }

        internal void IzmeniClanstvo(ComboBox cbClanovi, DateTimePicker dtpUclanjenje, DateTimePicker dtpPoslednjePlacanje, TextBox tbNeizmireno, Label lblError)
        {
            string[] parts = tbNeizmireno.Text.Split(' ');
            string numberPart = parts[0];
            int neizmirenaDugovanja = int.Parse(numberPart);

            Clanstvo clanstvoZaIzmeniti = new Clanstvo
            {
                Clan = (Clan)cbClanovi.SelectedItem,
                DatumPoslednjegPlacanja = dtpPoslednjePlacanje.Value,
                DatumUclanjenja = dtpUclanjenje.Value,
                NeizmirenaDugovanja = neizmirenaDugovanja
            };

            if (!clanstva.Contains(clanstvoZaIzmeniti))
            {
                lblError.Text = "Samo dodata članstva se mogu izmeniti";
                lblError.Visible = true;
                return;
            }

            lblError.Text = "";
            lblError.Visible = false;

            List<Clanstvo> clanstvaList = clanstva.ToList();
            int selectedIndex = clanstvaList.FindIndex(i => i.Clan.Id == clanstvoZaIzmeniti.Clan.Id);
            clanstva[selectedIndex] = clanstvoZaIzmeniti;
        }

        internal void SetClanstvoToChange(ComboBox cbClanovi, Clanstvo selectedClanstvo, DateTimePicker dtpUclanjenje, DateTimePicker dtpPoslednjePlacanje, TextBox tbNeizmireno)
        {
            try
            {
                cbClanovi.SelectedItem = selectedClanstvo.Clan;
                tbNeizmireno.Text = selectedClanstvo.NeizmirenaDugovanja.ToString() + " RSD";

                dtpUclanjenje.Value = selectedClanstvo.DatumUclanjenja.AddMinutes(-1);
                dtpPoslednjePlacanje.Value = selectedClanstvo.DatumPoslednjegPlacanja.AddMinutes(-2);
            }
            catch (ArgumentOutOfRangeException){

                MessageBox.Show("Datum je neispravan.");
            }

        }
    }
}
