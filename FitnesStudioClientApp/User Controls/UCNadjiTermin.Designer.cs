namespace FitnesStudioClientApp.User_Controls
{
    partial class UCNadjiTermin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblError = new System.Windows.Forms.Label();
            this.dgvTermini = new System.Windows.Forms.DataGridView();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblPretraga = new System.Windows.Forms.Label();
            this.tbPretraga = new System.Windows.Forms.TextBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.lblPrikaziError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).BeginInit();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Salmon;
            this.lblError.Location = new System.Drawing.Point(23, 162);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 19);
            this.lblError.TabIndex = 37;
            // 
            // dgvTermini
            // 
            this.dgvTermini.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvTermini.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTermini.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTermini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTermini.Location = new System.Drawing.Point(26, 195);
            this.dgvTermini.MultiSelect = false;
            this.dgvTermini.Name = "dgvTermini";
            this.dgvTermini.ReadOnly = true;
            this.dgvTermini.Size = new System.Drawing.Size(720, 374);
            this.dgvTermini.TabIndex = 36;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPretrazi.BackColor = System.Drawing.Color.PowderBlue;
            this.btnPretrazi.FlatAppearance.BorderSize = 0;
            this.btnPretrazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPretrazi.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretrazi.ForeColor = System.Drawing.Color.Transparent;
            this.btnPretrazi.Location = new System.Drawing.Point(394, 119);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(82, 32);
            this.btnPretrazi.TabIndex = 34;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.BtnPretrazi_Click);
            // 
            // lblNaslov
            // 
            this.lblNaslov.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(22, 53);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(178, 24);
            this.lblNaslov.TabIndex = 33;
            this.lblNaslov.Text = "Pretraga termina";
            // 
            // lblPretraga
            // 
            this.lblPretraga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.Location = new System.Drawing.Point(24, 127);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(68, 17);
            this.lblPretraga.TabIndex = 32;
            this.lblPretraga.Text = "Pretraga:";
            // 
            // tbPretraga
            // 
            this.tbPretraga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPretraga.Location = new System.Drawing.Point(98, 120);
            this.tbPretraga.Multiline = true;
            this.tbPretraga.Name = "tbPretraga";
            this.tbPretraga.Size = new System.Drawing.Size(290, 30);
            this.tbPretraga.TabIndex = 31;
            this.tbPretraga.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbPretraga_KeyDown);
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrikazi.BackColor = System.Drawing.Color.PowderBlue;
            this.btnPrikazi.FlatAppearance.BorderSize = 0;
            this.btnPrikazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrikazi.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikazi.ForeColor = System.Drawing.Color.Transparent;
            this.btnPrikazi.Location = new System.Drawing.Point(664, 113);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(82, 38);
            this.btnPrikazi.TabIndex = 38;
            this.btnPrikazi.Text = "Prikaži termin";
            this.btnPrikazi.UseVisualStyleBackColor = false;
            this.btnPrikazi.Click += new System.EventHandler(this.BtnPrikazi_Click);
            // 
            // lblPrikaziError
            // 
            this.lblPrikaziError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrikaziError.AutoSize = true;
            this.lblPrikaziError.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrikaziError.ForeColor = System.Drawing.Color.Salmon;
            this.lblPrikaziError.Location = new System.Drawing.Point(609, 162);
            this.lblPrikaziError.Name = "lblPrikaziError";
            this.lblPrikaziError.Size = new System.Drawing.Size(0, 19);
            this.lblPrikaziError.TabIndex = 39;
            // 
            // UCNadjiTermin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblPrikaziError);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.dgvTermini);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.lblPretraga);
            this.Controls.Add(this.tbPretraga);
            this.Font = new System.Drawing.Font("Arial", 11F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCNadjiTermin";
            this.Size = new System.Drawing.Size(768, 685);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.DataGridView dgvTermini;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblPretraga;
        private System.Windows.Forms.TextBox tbPretraga;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Label lblPrikaziError;
    }
}
