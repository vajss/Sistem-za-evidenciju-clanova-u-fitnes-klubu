using Domain;
using System;
using System.ComponentModel;
using System.Runtime.Remoting;
using System.Windows.Forms;

namespace FitnesStudioClientApp.UIControllers
{
    public class NadjiTerminController
    {
        internal void PretraziTermine(TextBox tbPretraga, DataGridView dgvTermini, Label lblError)
        {
            if (string.IsNullOrWhiteSpace(tbPretraga.Text))
            {
                return;
            }

            try
            {
                Termin termin = new Termin();
                termin.GCondition = $"TE.TerminId LIKE '%{tbPretraga.Text}%'";
                BindingList<Termin> termini = new BindingList<Termin>(Communication.Communication.Instance.PretraziTermine(termin));
                if (termini?.Count != 0 && termini?.Count != null)
                {
                    dgvTermini.DataSource = termini;
                    dgvTermini.Refresh();
                    //SetGridColumnProperties(dgvClanovi);
                    lblError.Text = "";
                }
                else
                {
                    dgvTermini.Rows.Clear();
                    lblError.Text = "Nema rezultata za datu pretragu";
                }
            }
            catch (ServerException se)
            {
                throw se;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška pri pretrazi članova.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void SetGrid(DataGridView dgvClanovi)
        {
            dgvClanovi.DataSource = new BindingList<Termin>();
            dgvClanovi.Columns["Id"].Visible = false;
            dgvClanovi.Columns["Id"].HeaderText = "Termin Id";
        }
    }
}
