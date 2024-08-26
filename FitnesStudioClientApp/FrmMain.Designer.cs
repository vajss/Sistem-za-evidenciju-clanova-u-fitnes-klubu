using System.Windows.Forms;

namespace FitnesStudioClientApp
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.msMeni = new System.Windows.Forms.MenuStrip();
            this.članoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajClanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.naToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajGrupuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretražiGrupeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dodajTerminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMeni.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMeni
            // 
            this.msMeni.BackColor = System.Drawing.Color.White;
            this.msMeni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.članoviToolStripMenuItem,
            this.grupeToolStripMenuItem,
            this.terminiToolStripMenuItem,
            this.odjavaToolStripMenuItem});
            this.msMeni.Location = new System.Drawing.Point(0, 0);
            this.msMeni.Name = "msMeni";
            this.msMeni.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.msMeni.Size = new System.Drawing.Size(1221, 27);
            this.msMeni.TabIndex = 0;
            this.msMeni.Text = "menuStrip1";
            // 
            // članoviToolStripMenuItem
            // 
            this.članoviToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajClanaToolStripMenuItem,
            this.naToolStripMenuItem});
            this.članoviToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F);
            this.članoviToolStripMenuItem.Name = "članoviToolStripMenuItem";
            this.članoviToolStripMenuItem.Size = new System.Drawing.Size(72, 23);
            this.članoviToolStripMenuItem.Text = "Članovi";
            // 
            // dodajClanaToolStripMenuItem
            // 
            this.dodajClanaToolStripMenuItem.Font = new System.Drawing.Font("Arial", 11F);
            this.dodajClanaToolStripMenuItem.Name = "dodajClanaToolStripMenuItem";
            this.dodajClanaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.dodajClanaToolStripMenuItem.Text = "Dodaj člana";
            this.dodajClanaToolStripMenuItem.Click += new System.EventHandler(this.DodajClanaToolStripMenuItem_Click);
            // 
            // naToolStripMenuItem
            // 
            this.naToolStripMenuItem.Font = new System.Drawing.Font("Arial", 11F);
            this.naToolStripMenuItem.Name = "naToolStripMenuItem";
            this.naToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.naToolStripMenuItem.Text = "Članovi";
            this.naToolStripMenuItem.Click += new System.EventHandler(this.naToolStripMenuItem_Click);
            // 
            // grupeToolStripMenuItem
            // 
            this.grupeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajGrupuToolStripMenuItem,
            this.pretražiGrupeToolStripMenuItem});
            this.grupeToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F);
            this.grupeToolStripMenuItem.Name = "grupeToolStripMenuItem";
            this.grupeToolStripMenuItem.Size = new System.Drawing.Size(63, 23);
            this.grupeToolStripMenuItem.Text = "Grupe";
            // 
            // dodajGrupuToolStripMenuItem
            // 
            this.dodajGrupuToolStripMenuItem.Font = new System.Drawing.Font("Arial", 11F);
            this.dodajGrupuToolStripMenuItem.Name = "dodajGrupuToolStripMenuItem";
            this.dodajGrupuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dodajGrupuToolStripMenuItem.Text = "Dodaj grupu";
            this.dodajGrupuToolStripMenuItem.Click += new System.EventHandler(this.dodajGrupuToolStripMenuItem_Click);
            // 
            // pretražiGrupeToolStripMenuItem
            // 
            this.pretražiGrupeToolStripMenuItem.Font = new System.Drawing.Font("Arial", 11F);
            this.pretražiGrupeToolStripMenuItem.Name = "pretražiGrupeToolStripMenuItem";
            this.pretražiGrupeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pretražiGrupeToolStripMenuItem.Text = "Pretraži grupe";
            this.pretražiGrupeToolStripMenuItem.Click += new System.EventHandler(this.pretražiGrupeToolStripMenuItem_Click);
            // 
            // terminiToolStripMenuItem
            // 
            this.terminiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajTerminToolStripMenuItem});
            this.terminiToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terminiToolStripMenuItem.Name = "terminiToolStripMenuItem";
            this.terminiToolStripMenuItem.Size = new System.Drawing.Size(70, 23);
            this.terminiToolStripMenuItem.Text = "Termini";
            // 
            // odjavaToolStripMenuItem
            // 
            this.odjavaToolStripMenuItem.BackColor = System.Drawing.Color.Salmon;
            this.odjavaToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odjavaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.odjavaToolStripMenuItem.Name = "odjavaToolStripMenuItem";
            this.odjavaToolStripMenuItem.Size = new System.Drawing.Size(74, 23);
            this.odjavaToolStripMenuItem.Text = "Odjava";
            this.odjavaToolStripMenuItem.Click += new System.EventHandler(this.OdjavaToolStripMenuItem_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.BackgroundImage = global::FitnesStudioClientApp.Properties.Resources.logo;
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlMain.Location = new System.Drawing.Point(0, 28);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1221, 728);
            this.pnlMain.TabIndex = 1;
            // 
            // dodajTerminToolStripMenuItem
            // 
            this.dodajTerminToolStripMenuItem.Font = new System.Drawing.Font("Arial", 11F);
            this.dodajTerminToolStripMenuItem.Name = "dodajTerminToolStripMenuItem";
            this.dodajTerminToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dodajTerminToolStripMenuItem.Text = "Dodaj Termin";
            this.dodajTerminToolStripMenuItem.Click += new System.EventHandler(this.DodajTerminToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 756);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.msMeni);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.MainMenuStrip = this.msMeni;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fitnes klub";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.msMeni.ResumeLayout(false);
            this.msMeni.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip msMeni;
        private ToolStripMenuItem članoviToolStripMenuItem;
        private ToolStripMenuItem grupeToolStripMenuItem;
        private ToolStripMenuItem terminiToolStripMenuItem;
        private ToolStripMenuItem dodajClanaToolStripMenuItem;
        private Panel pnlMain;
        private ToolStripMenuItem dodajGrupuToolStripMenuItem;
        private ToolStripMenuItem naToolStripMenuItem;
        private ToolStripMenuItem pretražiGrupeToolStripMenuItem;
        private ToolStripMenuItem odjavaToolStripMenuItem;
        private ToolStripMenuItem dodajTerminToolStripMenuItem;

        public Panel PnlMain { get => pnlMain; set => pnlMain = value; }
    }
}