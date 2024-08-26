using Domain;
using FitnesStudioClientApp.Helpers;
using System;
using System.Windows.Forms;

namespace FitnesStudioClientApp.UIControllers
{
    public class IzmeniClanaController
    {
        internal void IzmeniClana(TextBox tbClanId, TextBox tbIme, TextBox tbPrezime, DateTimePicker dtpDatumRodjenja, TextBox tbTelefon, TextBox tbZanimanje, Label lblError, Clan preselectedClan)
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
                    Id = preselectedClan.Id,
                    ClanId = Int32.Parse(tbClanId.Text),
                    Ime = tbIme.Text,
                    Prezime = tbPrezime.Text,
                    DatumRodjenja = dtpDatumRodjenja.Value,
                    Telefon = tbTelefon.Text,
                    Zanimanje = tbZanimanje.Text,
                };

                Communication.Communication.Instance.IzmeniClana(c); // TODO greska pri pretrazi clana nakon cuvanja ovde!!!
                MessageBox.Show("Clan je uspesno izmenjen!");

                tbClanId.Text = "";
                tbIme.Text = "";
                tbPrezime.Text = "";
                tbZanimanje.Text = "";
                tbTelefon.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška pri dodavanju člana.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
