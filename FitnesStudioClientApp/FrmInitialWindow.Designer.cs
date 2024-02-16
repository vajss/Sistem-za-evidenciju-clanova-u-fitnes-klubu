using System.Windows.Forms;

namespace FitnesStudioClientApp
{
    partial class FrmInitialWindow
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegister.BackColor = System.Drawing.Color.PowderBlue;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.Transparent;
            this.btnRegister.Location = new System.Drawing.Point(30, 65);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(93, 42);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Registracija";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogIn.BackColor = System.Drawing.Color.PowderBlue;
            this.btnLogIn.FlatAppearance.BorderSize = 0;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogIn.Location = new System.Drawing.Point(30, 15);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(93, 42);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "Login";
            this.btnLogIn.UseVisualStyleBackColor = false;
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMain.Location = new System.Drawing.Point(156, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(428, 438);
            this.pnlMain.TabIndex = 3;
            // 
            // FrmInitialWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 462);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.pnlMain);
            this.Name = "FrmInitialWindow";
            this.Text = "Log in";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogIn;
        private Panel pnlMain;

        public Button BtnRegister { get => btnRegister; set => btnRegister = value; }
        public Button BtnLogIn { get => btnLogIn; set => btnLogIn = value; }
        public Panel PnlMain { get => pnlMain; set => pnlMain = value; }
    }
}

