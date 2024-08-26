﻿using FitnesStudioClientApp.User_Controls;
using System;
using System.Windows.Forms;

namespace FitnesStudioClientApp.UIControllers
{
    public class MainViewController
    {

        public void ChangePanel(UserControl userControl = null, FrmMain frmMain = null)
        {
            frmMain.PnlMain.Controls.Clear();
            if (userControl != null)
            {
                userControl.Dock = DockStyle.Fill;
                frmMain.PnlMain.Controls.Add(userControl);
            }
        }

        internal void OpenPocetna(FrmMain frmMain)
        {
            ChangePanel(null, frmMain);
        }

        internal void OpenUCDodajClana(FrmMain frmMain)
        {
            ChangePanel(new UCDodajClana(new DodajClanaController()), frmMain);
        }

        internal void OpenUCDodajGrupu(FrmMain frmMain)
        {
            ChangePanel(new UCDodajGrupu(new DodajGrupuController()), frmMain);
        }

        internal void OpenUCDodajTermin(FrmMain frmMain)
        {
            ChangePanel(new UCDodajTermin(new DodajTerminController()), frmMain);

        }

        internal void OpenUCNadjiClanove(FrmMain frmMain)
        {
            ChangePanel(new UCNadjiClanove(new NadjiClanoveController(), frmMain), frmMain);
        }

        internal void OpenUCNadjiGrupe(FrmMain frmMain)
        {
            ChangePanel(new UCNadjiGrupe(new NadjiGrupeController(), frmMain), frmMain);

        }
    }
}
