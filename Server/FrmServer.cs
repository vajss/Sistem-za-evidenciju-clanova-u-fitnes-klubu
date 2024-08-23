using ServerApp.Controllers;
using System.Windows.Forms;

namespace ServerApp
{
    public partial class FrmServer : Form
    {

        public FrmServer()
        {
            UIServerController uIServerController = new UIServerController(this);
            InitializeComponent();
            uIServerController.Init();
        }

    }
}
