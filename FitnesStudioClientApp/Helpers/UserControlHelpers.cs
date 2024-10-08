﻿using Domain;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.Remoting.Messaging;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FitnesStudioClientApp.Helpers
{
    public static class UserControlHelpers
    {
        public static bool EmptyFieldValidation(TextBox tb, Label errorLabel = null)
        {
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                tb.BackColor = Color.Salmon;
                errorLabel.Text = "Popunite naznačena polja.";
                return false;
            }
            tb.BackColor = Color.White;
            return true;
        }

        public static bool RepeatPasswordValidation(TextBox password, TextBox repeatPassword, Label errorLabel)
        {
            if (password.Text != repeatPassword.Text)
            {
                errorLabel.Text = "Lozinke se ne poklapaju.";
                return false;
            }
            
            return true;
        }

        public static bool ComboBoxValidation(ComboBox cb, Label errorLabel)
        {
            if (cb.SelectedIndex == -1)
            {
                errorLabel.Text = "Popunite sva polja.";
                cb.BackColor = Color.Salmon;
                return false;
            }
            else
            {
                cb.BackColor = Color.WhiteSmoke;
                return true;
            }
        }

        public static bool IntValidation(TextBox tb, Label lblError)
        {
            if (!int.TryParse(tb.Text, out int _))
            {
                lblError.Visible = true;
                lblError.Text = "Morate uneti broj za trajanje";
                tb.BackColor = Color.Salmon;
                return false;
            }
            else
            {
                lblError.Visible = false;
                lblError.Text = "";
                tb.BackColor = Color.White;
                return true;
            }
        }

    public static bool SixDigitValidation(TextBox tb, Label errorLabel, string message)
    {
        string pattern = @"^\d{6}$";
        if (!Regex.IsMatch(tb.Text, pattern))
        {
            tb.BackColor = Color.Salmon;
            errorLabel.Text = message;
            return false;
        }
        
        tb.BackColor = Color.White;
        return true;
    }

    public static bool DateValidation(TextBox tb, Label lblError)
    {
        if (string.IsNullOrWhiteSpace(tb.Text) ||
            !DateTime.TryParseExact(tb.Text, "dd.MM.yyyy.", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
        {

            tb.BackColor = Color.Salmon;
            lblError.Text = "Datum mora biti u formatu dd.MM.yyyy.";
            return false;
        }

        tb.BackColor = SystemColors.Control;
        return true;
    }

        internal static bool CompareDatesValidation(DateTimePicker pastDate, DateTimePicker futureDate, Label lblError, string errorMessage)
        {
            if (pastDate.Value.Date > futureDate.Value.Date)
            {
                lblError.Text = errorMessage;
                return false;
            }
            return true;
        }

        internal static bool StartWIthValidator(TextBox tb, Label errorLabel, string prefix)
        {
            if (!Regex.IsMatch(tb.Text, @"^T-"))
            {
                tb.BackColor = Color.Salmon;
                errorLabel.Text = $"Mora početi sa '{prefix}'.";
                return false;
            }
            errorLabel.Text = "";
            errorLabel.Visible = false;
            tb.BackColor = Color.White;
            return true;
        }
    }
}
