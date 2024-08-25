namespace FitnesStudioClientApp.User_Controls
{
    partial class UCNadjiClanove
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
            this.tbPretraga = new System.Windows.Forms.TextBox();
            this.lblPretraga = new System.Windows.Forms.Label();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.dgvClanovi = new System.Windows.Forms.DataGridView();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanovi)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPretraga
            // 
            this.tbPretraga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPretraga.Location = new System.Drawing.Point(96, 81);
            this.tbPretraga.Multiline = true;
            this.tbPretraga.Name = "tbPretraga";
            this.tbPretraga.Size = new System.Drawing.Size(290, 30);
            this.tbPretraga.TabIndex = 0;
            // 
            // lblPretraga
            // 
            this.lblPretraga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.Location = new System.Drawing.Point(22, 88);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(68, 17);
            this.lblPretraga.TabIndex = 1;
            this.lblPretraga.Text = "Pretraga:";
            // 
            // lblNaslov
            // 
            this.lblNaslov.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(20, 14);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(182, 24);
            this.lblNaslov.TabIndex = 2;
            this.lblNaslov.Text = "Pretraga članova";
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPretrazi.BackColor = System.Drawing.Color.PowderBlue;
            this.btnPretrazi.FlatAppearance.BorderSize = 0;
            this.btnPretrazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPretrazi.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretrazi.ForeColor = System.Drawing.Color.Transparent;
            this.btnPretrazi.Location = new System.Drawing.Point(392, 80);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(82, 32);
            this.btnPretrazi.TabIndex = 26;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.BtnPretrazi_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIzmeni.BackColor = System.Drawing.Color.PowderBlue;
            this.btnIzmeni.FlatAppearance.BorderSize = 0;
            this.btnIzmeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzmeni.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeni.ForeColor = System.Drawing.Color.Transparent;
            this.btnIzmeni.Location = new System.Drawing.Point(646, 554);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(98, 39);
            this.btnIzmeni.TabIndex = 28;
            this.btnIzmeni.Text = "Izmeni člana";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            this.btnIzmeni.Click += new System.EventHandler(this.BtnIzmeni_Click);
            // 
            // dgvClanovi
            // 
            this.dgvClanovi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvClanovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClanovi.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvClanovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClanovi.Location = new System.Drawing.Point(24, 156);
            this.dgvClanovi.Name = "dgvClanovi";
            this.dgvClanovi.ReadOnly = true;
            this.dgvClanovi.Size = new System.Drawing.Size(720, 374);
            this.dgvClanovi.TabIndex = 29;
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Salmon;
            this.lblError.Location = new System.Drawing.Point(21, 123);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 19);
            this.lblError.TabIndex = 30;
            // 
            // UCNadjiClanove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.dgvClanovi);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.lblPretraga);
            this.Controls.Add(this.tbPretraga);
            this.Font = new System.Drawing.Font("Arial", 11F);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "UCNadjiClanove";
            this.Size = new System.Drawing.Size(768, 685);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPretraga;
        private System.Windows.Forms.Label lblPretraga;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.DataGridView dgvClanovi;
        private System.Windows.Forms.Label lblError;
    }
}
