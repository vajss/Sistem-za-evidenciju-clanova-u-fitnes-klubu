﻿using Domain;
using FitnesStudioClientApp.Helpers;
using System;
using System.Net.Sockets;
using System.Runtime.Remoting;
using System.Windows.Forms;
using View.Exceptions;

namespace FitnesStudioClientApp.UIControllers
{
    public class LoginController
    {
        internal bool Connect()
        {
            try
            {
                Communication.Communication.Instance.Connect();
                return true;
            }
            catch (SocketException ex)
            {
                MessageBox.Show("Greska prilikom povezivanja na server: " + ex.Message, "Greška pri prijavljivanju.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        internal void Login(TextBox tbKorisnickoIme, TextBox tbLozinka, FrmPocetna parentForm, Label lblError)
        {
            if (!UserControlHelpers.EmptyFieldValidation(tbKorisnickoIme, lblError) |
                !UserControlHelpers.EmptyFieldValidation(tbLozinka, lblError))
            {
                lblError.Visible = true;
                return;
            }
            try
            {
                lblError.Visible = false;
                Trener t = new Trener
                {
                    KorisnickoIme = tbKorisnickoIme.Text,
                    Sifra = tbLozinka.Text
                };
                t = Communication.Communication.Instance.Login(t);
                if (t != null)
                {
                    if (t.VecUlogovan)
                    {
                        MessageBox.Show("Ovaj korisnik je već ulogovan.");
                        return;
                    }
                    MainController.Instance.Trener = t;
                    MainController.Instance.OpenMainForm();
                    parentForm.Dispose();
                }
                else
                {
                    throw new SystemNotFoundException();
                }

            }
            catch (ServerException se)
            {
                throw se;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška pri prijavljivanju.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
