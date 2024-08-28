using Domain;
using FitnesStudioClientApp.Helpers;
using System;
using System.Runtime.Remoting;
using System.Windows.Forms;
using View.Exceptions;

namespace FitnesStudioClientApp.UIControllers
{
    public class DodajTerminController
    {
        internal void DodajTermin(TextBox tbTerminId, ComboBox cbGrupa, DateTimePicker dtpDatum, TextBox tbTrajanje, Label lblError, Label lblTrajanjeError, Label lblTerminIdError)
        {


            if (!UserControlHelpers.EmptyFieldValidation(tbTrajanje, lblError) |
                !UserControlHelpers.EmptyFieldValidation(tbTerminId, lblError) |
                !UserControlHelpers.StartWIthValidator(tbTerminId, lblTerminIdError, "T-") |
                !UserControlHelpers.IntValidation(tbTrajanje, lblTrajanjeError) |
                !UserControlHelpers.ComboBoxValidation(cbGrupa, lblError)
                )
            {
                lblTerminIdError.Visible = true;
                lblError.Visible = true;
                lblTrajanjeError.Visible = true;
                return;
            }

            lblTerminIdError.Visible = false;
            lblError.Visible = false;
            lblTrajanjeError.Visible = false;

            try
            {
                Termin t = new Termin
                {
                    TerminId = tbTerminId.Text,
                    Grupa = (Grupa)cbGrupa.SelectedItem,
                    Datum = dtpDatum.Value,
                    Trajanje = Int32.Parse(tbTrajanje.Text),
                };

                t = Communication.Communication.Instance.DodajTermin(t);
                MessageBox.Show("Termin je uspešno sačuvan!");

                cbGrupa.SelectedIndex = -1;
                tbTrajanje.Text = "";
                tbTerminId.Text = "";
            }
            catch (ServerException se)
            {
                throw se;
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message, "Greška pri čuvanju termina.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void UcitajGrupe(ComboBox cbGrupa)
        {
            try
            {
                cbGrupa.DataSource = Communication.Communication.Instance.VratiSveGrupe();
                cbGrupa.SelectedIndex = -1;
                cbGrupa.Text = "Izaberi grupu";
            }
            catch (ServerException se)
            {
                throw se;
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message, "Greška pri ucitavanju grupa.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
