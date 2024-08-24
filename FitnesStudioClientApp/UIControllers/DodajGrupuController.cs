using System.Windows.Forms;
using View.Exceptions;

namespace FitnesStudioClientApp.UIControllers
{
    public class DodajGrupuController
    {

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
    }
}
