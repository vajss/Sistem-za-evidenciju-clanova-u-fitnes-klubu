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
        internal void DodajTermin(ComboBox cbGrupa, DateTimePicker dtpDatum, TextBox tbTrajanje, Label lblError, Label lblTrajanjeError)
        {


            if (!UserControlHelpers.EmptyFieldValidation(tbTrajanje, lblError) |
                !UserControlHelpers.IntValidation(tbTrajanje, lblTrajanjeError) |
                !UserControlHelpers.ComboBoxValidation(cbGrupa, lblError)
                )
            {
                lblError.Visible = true;
                lblTrajanjeError.Visible = true;
                return;
            }

            lblError.Visible = false;
            lblTrajanjeError.Visible = false;

            try
            {
                Termin t = new Termin
                {
                    Grupa = (Grupa)cbGrupa.SelectedItem,
                    Datum = dtpDatum.Value,
                    Trajanje = Int32.Parse(tbTrajanje.Text),
                };

                t = Communication.Communication.Instance.DodajTermin(t);
                MessageBox.Show("Termin je uspesno sacuvan!");

                cbGrupa.SelectedIndex = -1;
                tbTrajanje.Text = "";
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
