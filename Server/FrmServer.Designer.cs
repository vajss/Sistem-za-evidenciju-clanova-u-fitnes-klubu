using System.Windows.Forms;

namespace ServerApp
{
    partial class FrmServer
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
            this.lblServerState = new System.Windows.Forms.Label();
            this.lblStatusServera = new System.Windows.Forms.Label();
            this.btnToggle = new ServerApp.ToggleButton();
            this.SuspendLayout();
            // 
            // lblServerState
            // 
            this.lblServerState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblServerState.AutoSize = true;
            this.lblServerState.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblServerState.ForeColor = System.Drawing.Color.Salmon;
            this.lblServerState.Location = new System.Drawing.Point(355, 287);
            this.lblServerState.Name = "lblServerState";
            this.lblServerState.Size = new System.Drawing.Size(112, 15);
            this.lblServerState.TabIndex = 1;
            this.lblServerState.Text = "Server je iskljucen";
            // 
            // lblStatusServera
            // 
            this.lblStatusServera.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStatusServera.AutoSize = true;
            this.lblStatusServera.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatusServera.Location = new System.Drawing.Point(361, 261);
            this.lblStatusServera.Name = "lblStatusServera";
            this.lblStatusServera.Size = new System.Drawing.Size(94, 15);
            this.lblStatusServera.TabIndex = 2;
            this.lblStatusServera.Text = "Status servera:";
            // 
            // btnToggle
            // 
            this.btnToggle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnToggle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnToggle.ButtonRadius = 40;
            this.btnToggle.FlatAppearance.BorderSize = 0;
            this.btnToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggle.ForeColor = System.Drawing.Color.White;
            this.btnToggle.Location = new System.Drawing.Point(364, 354);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(80, 40);
            this.btnToggle.TabIndex = 0;
            this.btnToggle.Text = "⬤";
            this.btnToggle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToggle.ToggleState = ServerApp.Custom_UI_components.ToggleStateEnum.OFF;
            this.btnToggle.UseVisualStyleBackColor = false;
            // 
            // FrmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(810, 497);
            this.Controls.Add(this.lblStatusServera);
            this.Controls.Add(this.lblServerState);
            this.Controls.Add(this.btnToggle);
            this.Name = "FrmServer";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblServerState;
        private Label lblStatusServera;
        private ToggleButton btnToggle;

        public ToggleButton BtnToggle { get => btnToggle; set => btnToggle = value; }
        public Label LblServerState { get => lblServerState; set => lblServerState = value; }
    }
}

