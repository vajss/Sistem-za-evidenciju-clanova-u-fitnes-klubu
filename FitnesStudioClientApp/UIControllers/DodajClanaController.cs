using Domain;
using FitnesStudioClientApp.Helpers;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace FitnesStudioClientApp.UIControllers
{
    public class DodajClanaController
    {
        internal void DodajClana(TextBox tbClanId, TextBox tbIme, TextBox tbPrezime, DateTimePicker dtpDatumRodjenja, TextBox tbZanimanje, TextBox tbTelefon, Label lblError)
        {
            if (!UserControlHelpers.EmptyFieldValidation(tbClanId, lblError) |
                !UserControlHelpers.EmptyFieldValidation(tbIme, lblError) |
                !UserControlHelpers.EmptyFieldValidation(tbPrezime, lblError) |
                !UserControlHelpers.EmptyFieldValidation(tbZanimanje, lblError) |
                !UserControlHelpers.EmptyFieldValidation(tbTelefon, lblError) |
                !UserControlHelpers.SixDigitValidation(tbClanId, lblError, "ClanId mora biti šesticifreni broj.")
                )
            {
                lblError.Visible = true;
                return;
            }
            try
            {
                lblError.Visible = false;
                
                Clan c = new Clan
                {
                    ClanId = Int32.Parse(tbClanId.Text),
                    Ime = tbIme.Text,
                    Prezime = tbPrezime.Text,
                    DatumRodjenja = dtpDatumRodjenja.Value,
                    Telefon = tbTelefon.Text,
                    Zanimanje = tbZanimanje.Text,
                };

                c = Communication.Communication.Instance.DodajClana(c);
                MessageBox.Show("Clan je uspesno sacuvan!");

                tbClanId.Text = "";
                tbIme.Text = "";
                tbPrezime.Text = "";
                tbZanimanje.Text = "";
                tbTelefon.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška pri dodavanju člana." , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
