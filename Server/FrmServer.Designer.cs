using System.Windows.Forms;

namespace Server
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
            this.btnToggle = new ToggleButton();
            this.lblServerState = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.btnToggle.Location = new System.Drawing.Point(365, 307);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(80, 40);
            this.btnToggle.TabIndex = 0;
            this.btnToggle.Text = "⬤";
            this.btnToggle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToggle.UseVisualStyleBackColor = false;
            // 
            // lblServerState
            // 
            this.lblServerState.AutoSize = true;
            this.lblServerState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerState.ForeColor = System.Drawing.Color.Salmon;
            this.lblServerState.Location = new System.Drawing.Point(338, 364);
            this.lblServerState.Name = "lblServerState";
            this.lblServerState.Size = new System.Drawing.Size(135, 16);
            this.lblServerState.TabIndex = 1;
            this.lblServerState.Text = "Server je iskljucen";
            // 
            // FrmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 497);
            this.Controls.Add(this.lblServerState);
            this.Controls.Add(this.btnToggle);
            this.Name = "FrmServer";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ToggleButton btnToggle;
        private System.Windows.Forms.Label lblServerState;

        public ToggleButton BtnToggle { get => btnToggle; set => btnToggle = value; }
        public Label LblServerState { get => lblServerState; set => lblServerState = value; }
    }
}

