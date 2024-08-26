using FitnesStudioClientApp.UIControllers;
using System.Windows.Forms;

namespace FitnesStudioClientApp.User_Controls
{
    public partial class UCNadjiGrupe : UserControl
    {
        private NadjiGrupeController nadjiGrupeController;
        private FrmMain frmMain;

        public UCNadjiGrupe()
        {
            InitializeComponent();
        }

        public UCNadjiGrupe(NadjiGrupeController nadjiGrupeController, FrmMain frmMain)
        {
            this.nadjiGrupeController = nadjiGrupeController;
            this.frmMain = frmMain;
            InitializeComponent();
            this.nadjiGrupeController.SetGrid(dgvGrupe);
        }
    }
}
