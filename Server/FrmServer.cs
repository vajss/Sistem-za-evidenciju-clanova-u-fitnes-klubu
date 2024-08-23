using Server.Controllers;
using System.Windows.Forms;

namespace Server
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
