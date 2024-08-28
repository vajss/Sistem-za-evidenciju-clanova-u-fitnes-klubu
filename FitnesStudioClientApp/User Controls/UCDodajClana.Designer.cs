namespace FitnesStudioClientApp.User_Controls
{
    partial class UCDodajClana
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
            this.lblNaslov = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbClanId = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbZanimanje = new System.Windows.Forms.TextBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.btnSacuvajClana = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnIzmeniClana = new System.Windows.Forms.Button();
            this.btnNazad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblNaslov.Location = new System.Drawing.Point(97, 76);
            this.lblNaslov.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(148, 19);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "Unos novog člana";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F);
            this.label1.Location = new System.Drawing.Point(143, 251);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11F);
            this.label2.Location = new System.Drawing.Point(143, 323);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F);
            this.label3.Location = new System.Drawing.Point(143, 396);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Datum rođenja:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11F);
            this.label4.Location = new System.Drawing.Point(143, 468);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Zanimanje:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11F);
            this.label5.Location = new System.Drawing.Point(143, 539);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Telefon:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11F);
            this.label6.Location = new System.Drawing.Point(143, 192);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Član ID:";
            // 
            // tbClanId
            // 
            this.tbClanId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbClanId.Font = new System.Drawing.Font("Arial", 11F);
            this.tbClanId.Location = new System.Drawing.Point(324, 187);
            this.tbClanId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbClanId.Multiline = true;
            this.tbClanId.Name = "tbClanId";
            this.tbClanId.Size = new System.Drawing.Size(173, 31);
            this.tbClanId.TabIndex = 7;
            // 
            // tbIme
            // 
            this.tbIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbIme.Font = new System.Drawing.Font("Arial", 11F);
            this.tbIme.Location = new System.Drawing.Point(324, 246);
            this.tbIme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbIme.Multiline = true;
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(173, 31);
            this.tbIme.TabIndex = 8;
            // 
            // tbPrezime
            // 
            this.tbPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPrezime.Font = new System.Drawing.Font("Arial", 11F);
            this.tbPrezime.Location = new System.Drawing.Point(324, 318);
            this.tbPrezime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPrezime.Multiline = true;
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(173, 31);
            this.tbPrezime.TabIndex = 9;
            // 
            // tbZanimanje
            // 
            this.tbZanimanje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbZanimanje.Font = new System.Drawing.Font("Arial", 11F);
            this.tbZanimanje.Location = new System.Drawing.Point(324, 463);
            this.tbZanimanje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbZanimanje.Multiline = true;
            this.tbZanimanje.Name = "tbZanimanje";
            this.tbZanimanje.Size = new System.Drawing.Size(173, 31);
            this.tbZanimanje.TabIndex = 10;
            // 
            // tbTelefon
            // 
            this.tbTelefon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbTelefon.Font = new System.Drawing.Font("Arial", 11F);
            this.tbTelefon.Location = new System.Drawing.Point(324, 534);
            this.tbTelefon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTelefon.Multiline = true;
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(173, 31);
            this.tbTelefon.TabIndex = 11;
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDatumRodjenja.CustomFormat = "dd.MM.yyyy.";
            this.dtpDatumRodjenja.Font = new System.Drawing.Font("Arial", 11F);
            this.dtpDatumRodjenja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(324, 392);
            this.dtpDatumRodjenja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(173, 24);
            this.dtpDatumRodjenja.TabIndex = 12;
            // 
            // btnSacuvajClana
            // 
            this.btnSacuvajClana.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSacuvajClana.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSacuvajClana.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnSacuvajClana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSacuvajClana.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnSacuvajClana.ForeColor = System.Drawing.Color.White;
            this.btnSacuvajClana.Location = new System.Drawing.Point(365, 609);
            this.btnSacuvajClana.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSacuvajClana.Name = "btnSacuvajClana";
            this.btnSacuvajClana.Size = new System.Drawing.Size(132, 40);
            this.btnSacuvajClana.TabIndex = 14;
            this.btnSacuvajClana.Text = "Sačuvaj člana";
            this.btnSacuvajClana.UseVisualStyleBackColor = false;
            this.btnSacuvajClana.Click += new System.EventHandler(this.BtnSacuvajClana_Click);
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.SystemColors.Control;
            this.lblError.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblError.ForeColor = System.Drawing.Color.Salmon;
            this.lblError.Location = new System.Drawing.Point(324, 575);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 15;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btnIzmeniClana
            // 
            this.btnIzmeniClana.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIzmeniClana.BackColor = System.Drawing.Color.PowderBlue;
            this.btnIzmeniClana.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnIzmeniClana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzmeniClana.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnIzmeniClana.ForeColor = System.Drawing.Color.White;
            this.btnIzmeniClana.Location = new System.Drawing.Point(351, 609);
            this.btnIzmeniClana.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIzmeniClana.Name = "btnIzmeniClana";
            this.btnIzmeniClana.Size = new System.Drawing.Size(146, 40);
            this.btnIzmeniClana.TabIndex = 16;
            this.btnIzmeniClana.Text = "Sačuvaj Izmene";
            this.btnIzmeniClana.UseVisualStyleBackColor = false;
            this.btnIzmeniClana.Visible = false;
            this.btnIzmeniClana.Click += new System.EventHandler(this.BtnIzmeniClana_Click);
            // 
            // btnNazad
            // 
            this.btnNazad.BackColor = System.Drawing.Color.PowderBlue;
            this.btnNazad.FlatAppearance.BorderSize = 0;
            this.btnNazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNazad.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnNazad.ForeColor = System.Drawing.Color.Transparent;
            this.btnNazad.Location = new System.Drawing.Point(21, 22);
            this.btnNazad.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(115, 36);
            this.btnNazad.TabIndex = 17;
            this.btnNazad.Text = "< Nazad";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Visible = false;
            this.btnNazad.Click += new System.EventHandler(this.BtnNazad_Click);
            // 
            // UCDodajClana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.btnIzmeniClana);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnSacuvajClana);
            this.Controls.Add(this.dtpDatumRodjenja);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.tbZanimanje);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.tbClanId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNaslov);
            this.Font = new System.Drawing.Font("Arial", 11F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UCDodajClana";
            this.Size = new System.Drawing.Size(633, 700);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbClanId;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbZanimanje;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
        private System.Windows.Forms.Button btnSacuvajClana;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnIzmeniClana;
        private System.Windows.Forms.Button btnNazad;
    }
}
