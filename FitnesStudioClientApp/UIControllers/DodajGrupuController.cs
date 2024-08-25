using Domain;
using FitnesStudioClientApp.Helpers;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using View.Exceptions;

namespace FitnesStudioClientApp.UIControllers
{
    public class DodajGrupuController
    {
        internal void DodajClanstvoUGrupu(ComboBox cbClanovi, TextBox tbBrojClanova, DataGridView dgvClanstva, DateTimePicker dtpUclanjenje, DateTimePicker dtpPoslednjePlacanje, TextBox tbNeizmireno, Label lblError)
        {
            if (!UserControlHelpers.ComboBoxValidation(cbClanovi, lblError) |
                !UserControlHelpers.CompareDatesValidation(dtpUclanjenje, dtpPoslednjePlacanje, lblError, "Učlanjenje ne može biti neako poslednjeg plaćanja.")
                /*!UserControlHelpers.EmptyFieldValidation(tbIme, lblError) |
               !UserControlHelpers.EmptyFieldValidation(tbPrezime, lblError) |
               !UserControlHelpers.EmptyFieldValidation(tbZanimanje, lblError) |
               !UserControlHelpers.EmptyFieldValidation(tbTelefon, lblError) |
               !UserControlHelpers.SixDigitValidation(tbClanId, lblError, "ClanId mora biti šesticifreni broj.")*/
               )
            {
                lblError.Visible = true;
                return;
            }
            lblError.Visible = false;
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


        internal int GetMonthsDifference(DateTime startDate, DateTime endDate, ComboBox program)
        {
            int price = ((TreningProgram)(program.SelectedItem)).Cena;
            int yearDifference = endDate.Year - startDate.Year;
            int monthDifference = endDate.Month - startDate.Month;

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
            dtpPoslednjePlacanje.MinDate = dtpUclanjenje.Value;
            dtpUclanjenje.MaxDate = DateTime.Now;
        }
    }
}
