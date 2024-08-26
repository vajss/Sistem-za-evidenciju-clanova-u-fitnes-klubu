using Domain;
using FitnesStudioClientApp.Helpers;
using FitnesStudioClientApp.User_Controls;
using System;
using System.Runtime.Remoting;
using System.Windows.Forms;

namespace FitnesStudioClientApp.UIControllers
{
    public class RegisterController
    {
        internal void Register(
                 TextBox tbName,
                 TextBox tbLastName,
                 TextBox tbUsername,
                 TextBox tbPassword,
                 TextBox tbRepeatPassword,
                 Label lblError,
                 FrmPocetna frmInitialWindow,
                 LoginController loginController)
        {
            if (
                !UserControlHelpers.EmptyFieldValidation(tbName, lblError) |
                !UserControlHelpers.EmptyFieldValidation(tbLastName, lblError) |
                !UserControlHelpers.EmptyFieldValidation(tbUsername, lblError) |
                !UserControlHelpers.EmptyFieldValidation(tbPassword, lblError) |
                !UserControlHelpers.EmptyFieldValidation(tbRepeatPassword, lblError) |
                !UserControlHelpers.RepeatPasswordValidation(tbPassword, tbRepeatPassword, lblError)
                )
            {
                lblError.Visible = true;
                return;
            }
            try
            {
                lblError.Visible = false;

                Trener t = new Trener
                {
                    Ime = tbName.Text,
                    Prezime = tbLastName.Text,
                    KorisnickoIme = tbUsername.Text,
                    Sifra = tbPassword.Text
                };

                t = Communication.Communication.Instance.Register(t);
                if (t != null)
                {
                    MessageBox.Show($"Korisnik {t.KorisnickoIme} uspesno registrovan");
                    PocetnaForma.Instance.ChangePanel();
                    PocetnaForma.Instance.ChangePanel(new UCLogIn(loginController ,frmInitialWindow));
                }
                else
                {
                    throw new Exception("Nepoznat problem prilikom registracije.");
                }
            }
            catch (ServerException se)
            {
                throw se;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška pri registraciji.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
