using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace FitnesStudioClientApp.Helpers
{
    public static class UserControlHelpers
    {
        public static bool EmptyFieldValidation(TextBox txt, Label errorLabel = null)
        {

            Debug.WriteLine(">>>> errorLabel: " + errorLabel);
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.BackColor = Color.LightCoral;
                if (errorLabel != null)
                {
                    errorLabel.Text = "Popunite naznačena polja.";
                    errorLabel.Visible = true;
                }
                
                return false;
            }

            errorLabel.Visible = false;
            txt.BackColor = Color.White;
            return true;
        }

        public static bool RepeatPasswordValidation(TextBox password, TextBox repeatPassword, Label errorLabel)
        {
            if (password.Text != repeatPassword.Text)
            {
                errorLabel.Text = "Lozinke se ne poklapaju.";
                errorLabel.Visible = true;
                return false;
            }

            if (string.IsNullOrWhiteSpace(errorLabel.Text) )
            {
                errorLabel.Visible = false;
            }
            
            return true;
        }
    }
}
