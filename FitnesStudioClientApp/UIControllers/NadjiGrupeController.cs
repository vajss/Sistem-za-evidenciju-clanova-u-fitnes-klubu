
using Domain;
using System.ComponentModel;
using System.Windows.Forms;
using System;
using System.Runtime.Remoting;

namespace FitnesStudioClientApp.UIControllers
{
    public class NadjiGrupeController
    {
        internal void SetGrid(DataGridView dgvGrupe)
        {
            dgvGrupe.DataSource = new BindingList<Grupa>(Communication.Communication.Instance.VratiSveGrupe());
            dgvGrupe.Columns["TreningProgram"].HeaderText = "Trening program";
        }

        internal void PretraziGrupe(TextBox tbPretraga, DataGridView dgvGrupe, Label lblError)
        {
            if (string.IsNullOrWhiteSpace(tbPretraga.Text))
            {
                return;
            }

            try
            {
                Grupa grupa = new Grupa();
                grupa.GCondition = $"G.Naziv LIKE '%{tbPretraga.Text}%'";
                BindingList<Grupa> grupe = new BindingList<Grupa>(Communication.Communication.Instance.VratiSveGrupe()); // TODO pretrazi ovde ide
                if (grupe?.Count != 0 && grupe?.Count != null)
                {
                    dgvGrupe.DataSource = grupe;
                    dgvGrupe.Refresh();
                    dgvGrupe.Columns["TreningProgram"].HeaderText = "Trening program";
                    lblError.Text = "";
                }
                else
                {
                    dgvGrupe.Rows.Clear();
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
    }  
}
