using ServerApp.Custom_UI_components;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerApp.Controllers
{
    internal class UIServerController
    {
        private Server server;
        private readonly FrmServer frmServer;

        public UIServerController(FrmServer frmServer)
        {
            this.frmServer = frmServer;
        }

        internal void Init()
        {
            frmServer.BtnToggle.Click += BtnToggle_Click;
        }

        private void BtnToggle_Click(object sender, EventArgs e)
        {
            ChangeToggleState(frmServer.BtnToggle.ToggleState == ToggleStateEnum.ON ? ToggleStateEnum.OFF : ToggleStateEnum.ON);

            if (frmServer.BtnToggle.ToggleState == ToggleStateEnum.ON)
                StartServer();
            else
                StopServer();
        }

        private void StopServer()
        {
            server?.Stop();
            server = null;
            Debug.WriteLine(">>> Server stopped.");
        }

        private void StartServer()
        {
            server = new Server();
            if (server.Start())
            {
                Thread serverListeningThread = new Thread(server.Listen);
                Debug.WriteLine(">>> Server started.");

                serverListeningThread.IsBackground = true;
                serverListeningThread.Start();
            }
            else
            {
                ChangeToggleState(ToggleStateEnum.OFF);
                MessageBox.Show("Greska prilikom pokretanja servera!");
            }
        }

        private void ChangeToggleState(ToggleStateEnum toggleState)
        {
            frmServer.BtnToggle.ToggleState = toggleState;
            frmServer.BtnToggle.BackColor = toggleState == ToggleStateEnum.ON ? Color.Chartreuse : SystemColors.ControlDark;
            frmServer.BtnToggle.TextAlign = toggleState == ToggleStateEnum.ON ? ContentAlignment.MiddleRight : ContentAlignment.MiddleLeft;
            frmServer.LblServerState.ForeColor = toggleState == ToggleStateEnum.ON ? Color.Chartreuse : Color.Salmon;
            frmServer.LblServerState.Text = toggleState == ToggleStateEnum.ON ? "Server je ukljucen" : "Server je iskljucen.";
        }
    }
}
