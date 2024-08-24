using FitnesStudioClientApp.UIControllers;
using System.Windows.Forms;

namespace FitnesStudioClientApp.User_Controls
{
    public partial class UCDodajClana : UserControl
    {
        private DodajClanaController dodajClanaController;

        public UCDodajClana()
        {
            InitializeComponent();
        }

        public UCDodajClana(DodajClanaController dodajClanaController)
        {
            InitializeComponent();
            this.dodajClanaController = dodajClanaController;
        }

        private void btnSacuvajClana_Click(object sender, System.EventArgs e)
        {

        }
    }
}
