
using Domain;
using System.ComponentModel;
using System.Windows.Forms;
using System;
using System.Runtime.Remoting;
using FitnesStudioClientApp.User_Controls;

namespace FitnesStudioClientApp.UIControllers
{
    public class NadjiGrupeController
    {
        internal void SetGrid(DataGridView dgvGrupe)
        {

            try
            {
                dgvGrupe.DataSource = new BindingList<Grupa>(Communication.Communication.Instance.VratiSveGrupe());
                dgvGrupe.Columns["TreningProgram"].HeaderText = "Trening program";
                dgvGrupe.Columns["BrojClanova"].HeaderText = "Broj članova";
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
                BindingList<Grupa> grupe = new BindingList<Grupa>(Communication.Communication.Instance.PretraziGrupe(grupa));
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

        internal void IzmeniGrupu(FrmMain parentForm, Grupa grupa, Label lblError)
        {
            if (grupa != null)
            {
                parentForm.mainController.ChangePanel(new UCDodajIzmeniGrupu(new DodajIzmeniGrupuController(), grupa, parentForm), parentForm);
            }
            else
            {
                lblError.Text = "Nije odabrana grupa.";
            }
        }
    }  
}
