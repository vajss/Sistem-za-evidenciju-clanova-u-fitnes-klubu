using Domain;
using FitnesStudioClientApp.Helpers;
using FitnesStudioClientApp.User_Controls;
using System;
using System.Diagnostics;
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
                 FrmInitialWindow frmInitialWindow,
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
                return;
            }
            try
            {
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
                    InitialWindowControler.Instance.ChangePanel();
                    InitialWindowControler.Instance.ChangePanel(new UCLogIn(loginController ,frmInitialWindow));
                }
                else
                {
                    throw new Exception("Nepoznat problem prilikom registracije.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
