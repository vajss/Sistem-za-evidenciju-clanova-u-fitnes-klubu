using FitnesStudioClientApp.User_Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnesStudioClientApp.UIControllers
{
    internal class RegisterController
    {
        internal void Init(UCRegisterUser uCRegisterUser)
        {
            uCRegisterUser.BtnRegister.Click += BtnRegister_Click;
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uspešna registracija!", "Registracija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            InitialWindowControler.Instance.ChangePanel();
            // TODO kontam da ovde treba da uspostavim vezu sa serverom. Valjda
        }
    }
}
