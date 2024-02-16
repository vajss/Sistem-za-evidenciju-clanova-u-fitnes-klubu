using FitnesStudioClientApp.UIControllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnesStudioClientApp
{
    public partial class FrmInitialWindow : Form
    {
        public FrmInitialWindow()
        {
            InitializeComponent();
            InitialWindowControler controller = new InitialWindowControler();
            controller.Init(this);
        }
    }
}
