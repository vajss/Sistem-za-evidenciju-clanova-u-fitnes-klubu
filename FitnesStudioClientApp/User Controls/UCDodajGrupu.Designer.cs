namespace FitnesStudioClientApp.User_Controls
{
    partial class UCDodajGrupu
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
            this.lblNaziv = new System.Windows.Forms.Label();
            this.tbClanId = new System.Windows.Forms.TextBox();
            this.tbBrojClanova = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTreningProgram = new System.Windows.Forms.Label();
            this.cbTreningProgram = new System.Windows.Forms.ComboBox();
            this.dgvClanstva = new System.Windows.Forms.DataGridView();
            this.btnObrisiClanove = new System.Windows.Forms.Button();
            this.gbDodajClanove = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnDodajClana = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNeizmireno = new System.Windows.Forms.TextBox();
            this.dtpPoslednjePlacanje = new System.Windows.Forms.DateTimePicker();
            this.lblPoslednjePlacanje = new System.Windows.Forms.Label();
            this.dtpUclanjenje = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbClanovi = new System.Windows.Forms.ComboBox();
            this.lblClan = new System.Windows.Forms.Label();
            this.btnSacuvajGrupu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanstva)).BeginInit();
            this.gbDodajClanove.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(45, 51);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(89, 17);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "Naziv grupe:";
            // 
            // tbClanId
            // 
            this.tbClanId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbClanId.Font = new System.Drawing.Font("Arial", 11F);
            this.tbClanId.Location = new System.Drawing.Point(189, 47);
            this.tbClanId.Multiline = true;
            this.tbClanId.Name = "tbClanId";
            this.tbClanId.Size = new System.Drawing.Size(183, 25);
            this.tbClanId.TabIndex = 8;
            this.tbClanId.TextChanged += new System.EventHandler(this.TbClanId_TextChanged);
            // 
            // tbBrojClanova
            // 
            this.tbBrojClanova.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBrojClanova.Enabled = false;
            this.tbBrojClanova.Font = new System.Drawing.Font("Arial", 11F);
            this.tbBrojClanova.Location = new System.Drawing.Point(189, 142);
            this.tbBrojClanova.Multiline = true;
            this.tbBrojClanova.Name = "tbBrojClanova";
            this.tbBrojClanova.Size = new System.Drawing.Size(183, 25);
            this.tbBrojClanova.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Broj članova:";
            // 
            // lblTreningProgram
            // 
            this.lblTreningProgram.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTreningProgram.AutoSize = true;
            this.lblTreningProgram.Location = new System.Drawing.Point(45, 98);
            this.lblTreningProgram.Name = "lblTreningProgram";
            this.lblTreningProgram.Size = new System.Drawing.Size(119, 17);
            this.lblTreningProgram.TabIndex = 11;
            this.lblTreningProgram.Text = "Trening program:";
            // 
            // cbTreningProgram
            // 
            this.cbTreningProgram.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTreningProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTreningProgram.FormattingEnabled = true;
            this.cbTreningProgram.Location = new System.Drawing.Point(189, 94);
            this.cbTreningProgram.Name = "cbTreningProgram";
            this.cbTreningProgram.Size = new System.Drawing.Size(183, 25);
            this.cbTreningProgram.TabIndex = 12;
            this.cbTreningProgram.SelectedIndexChanged += new System.EventHandler(this.CalculateDebt);
            // 
            // dgvClanstva
            // 
            this.dgvClanstva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvClanstva.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvClanstva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClanstva.Location = new System.Drawing.Point(48, 199);
            this.dgvClanstva.Name = "dgvClanstva";
            this.dgvClanstva.Size = new System.Drawing.Size(565, 350);
            this.dgvClanstva.TabIndex = 13;
            // 
            // btnObrisiClanove
            // 
            this.btnObrisiClanove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnObrisiClanove.BackColor = System.Drawing.Color.Salmon;
            this.btnObrisiClanove.Enabled = false;
            this.btnObrisiClanove.FlatAppearance.BorderSize = 0;
            this.btnObrisiClanove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisiClanove.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiClanove.ForeColor = System.Drawing.Color.Transparent;
            this.btnObrisiClanove.Location = new System.Drawing.Point(515, 574);
            this.btnObrisiClanove.Name = "btnObrisiClanove";
            this.btnObrisiClanove.Size = new System.Drawing.Size(98, 48);
            this.btnObrisiClanove.TabIndex = 15;
            this.btnObrisiClanove.Text = "Obrisi označene";
            this.btnObrisiClanove.UseVisualStyleBackColor = false;
            this.btnObrisiClanove.Click += new System.EventHandler(this.BtnObrisiClanove_Click);
            // 
            // gbDodajClanove
            // 
            this.gbDodajClanove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbDodajClanove.Controls.Add(this.lblError);
            this.gbDodajClanove.Controls.Add(this.btnDodajClana);
            this.gbDodajClanove.Controls.Add(this.label5);
            this.gbDodajClanove.Controls.Add(this.tbNeizmireno);
            this.gbDodajClanove.Controls.Add(this.dtpPoslednjePlacanje);
            this.gbDodajClanove.Controls.Add(this.lblPoslednjePlacanje);
            this.gbDodajClanove.Controls.Add(this.dtpUclanjenje);
            this.gbDodajClanove.Controls.Add(this.label1);
            this.gbDodajClanove.Controls.Add(this.cbClanovi);
            this.gbDodajClanove.Controls.Add(this.lblClan);
            this.gbDodajClanove.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.gbDodajClanove.Location = new System.Drawing.Point(678, 199);
            this.gbDodajClanove.Name = "gbDodajClanove";
            this.gbDodajClanove.Size = new System.Drawing.Size(372, 350);
            this.gbDodajClanove.TabIndex = 16;
            this.gbDodajClanove.TabStop = false;
            this.gbDodajClanove.Text = "Dodaj članstvo u grupu";
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Arial", 10F);
            this.lblError.ForeColor = System.Drawing.Color.Salmon;
            this.lblError.Location = new System.Drawing.Point(182, 261);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 16);
            this.lblError.TabIndex = 28;
            this.lblError.Visible = false;
            // 
            // btnDodajClana
            // 
            this.btnDodajClana.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodajClana.BackColor = System.Drawing.Color.PowderBlue;
            this.btnDodajClana.FlatAppearance.BorderSize = 0;
            this.btnDodajClana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajClana.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajClana.ForeColor = System.Drawing.Color.Transparent;
            this.btnDodajClana.Location = new System.Drawing.Point(240, 285);
            this.btnDodajClana.Name = "btnDodajClana";
            this.btnDodajClana.Size = new System.Drawing.Size(98, 48);
            this.btnDodajClana.TabIndex = 25;
            this.btnDodajClana.Text = "Dodaj člana";
            this.btnDodajClana.UseVisualStyleBackColor = false;
            this.btnDodajClana.Click += new System.EventHandler(this.BtnDodajClana_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F);
            this.label5.Location = new System.Drawing.Point(17, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Neizmirena dugovanja:";
            // 
            // tbNeizmireno
            // 
            this.tbNeizmireno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNeizmireno.Enabled = false;
            this.tbNeizmireno.Font = new System.Drawing.Font("Arial", 11F);
            this.tbNeizmireno.Location = new System.Drawing.Point(185, 225);
            this.tbNeizmireno.Multiline = true;
            this.tbNeizmireno.Name = "tbNeizmireno";
            this.tbNeizmireno.Size = new System.Drawing.Size(153, 25);
            this.tbNeizmireno.TabIndex = 26;
            // 
            // dtpPoslednjePlacanje
            // 
            this.dtpPoslednjePlacanje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpPoslednjePlacanje.CustomFormat = "dd.MM.yyyy.";
            this.dtpPoslednjePlacanje.Font = new System.Drawing.Font("Arial", 11F);
            this.dtpPoslednjePlacanje.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPoslednjePlacanje.Location = new System.Drawing.Point(185, 168);
            this.dtpPoslednjePlacanje.Name = "dtpPoslednjePlacanje";
            this.dtpPoslednjePlacanje.Size = new System.Drawing.Size(153, 24);
            this.dtpPoslednjePlacanje.TabIndex = 23;
            this.dtpPoslednjePlacanje.ValueChanged += new System.EventHandler(this.CalculateDebt);
            // 
            // lblPoslednjePlacanje
            // 
            this.lblPoslednjePlacanje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPoslednjePlacanje.AutoSize = true;
            this.lblPoslednjePlacanje.Font = new System.Drawing.Font("Arial", 10F);
            this.lblPoslednjePlacanje.Location = new System.Drawing.Point(17, 173);
            this.lblPoslednjePlacanje.Name = "lblPoslednjePlacanje";
            this.lblPoslednjePlacanje.Size = new System.Drawing.Size(130, 16);
            this.lblPoslednjePlacanje.TabIndex = 22;
            this.lblPoslednjePlacanje.Text = "Poslednje plaćanje:";
            // 
            // dtpUclanjenje
            // 
            this.dtpUclanjenje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpUclanjenje.CustomFormat = "dd.MM.yyyy.";
            this.dtpUclanjenje.Font = new System.Drawing.Font("Arial", 11F);
            this.dtpUclanjenje.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpUclanjenje.Location = new System.Drawing.Point(185, 111);
            this.dtpUclanjenje.Name = "dtpUclanjenje";
            this.dtpUclanjenje.Size = new System.Drawing.Size(153, 24);
            this.dtpUclanjenje.TabIndex = 21;
            this.dtpUclanjenje.ValueChanged += new System.EventHandler(this.CalculateDebt);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.Location = new System.Drawing.Point(17, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Datum učlanjenja:";
            // 
            // cbClanovi
            // 
            this.cbClanovi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbClanovi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClanovi.FormattingEnabled = true;
            this.cbClanovi.Location = new System.Drawing.Point(185, 56);
            this.cbClanovi.Name = "cbClanovi";
            this.cbClanovi.Size = new System.Drawing.Size(153, 24);
            this.cbClanovi.TabIndex = 18;
            // 
            // lblClan
            // 
            this.lblClan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblClan.AutoSize = true;
            this.lblClan.Font = new System.Drawing.Font("Arial", 11F);
            this.lblClan.Location = new System.Drawing.Point(17, 60);
            this.lblClan.Name = "lblClan";
            this.lblClan.Size = new System.Drawing.Size(42, 17);
            this.lblClan.TabIndex = 17;
            this.lblClan.Text = "Clan:";
            // 
            // btnSacuvajGrupu
            // 
            this.btnSacuvajGrupu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSacuvajGrupu.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSacuvajGrupu.FlatAppearance.BorderSize = 0;
            this.btnSacuvajGrupu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSacuvajGrupu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvajGrupu.ForeColor = System.Drawing.Color.Transparent;
            this.btnSacuvajGrupu.Location = new System.Drawing.Point(964, 574);
            this.btnSacuvajGrupu.Name = "btnSacuvajGrupu";
            this.btnSacuvajGrupu.Size = new System.Drawing.Size(86, 48);
            this.btnSacuvajGrupu.TabIndex = 14;
            this.btnSacuvajGrupu.Text = "Sačuvaj grupu";
            this.btnSacuvajGrupu.UseVisualStyleBackColor = false;
            this.btnSacuvajGrupu.Click += new System.EventHandler(this.BtnSacuvajGrupu_Click);
            // 
            // UCDodajGrupu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbDodajClanove);
            this.Controls.Add(this.btnObrisiClanove);
            this.Controls.Add(this.btnSacuvajGrupu);
            this.Controls.Add(this.dgvClanstva);
            this.Controls.Add(this.cbTreningProgram);
            this.Controls.Add(this.lblTreningProgram);
            this.Controls.Add(this.tbBrojClanova);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbClanId);
            this.Controls.Add(this.lblNaziv);
            this.Font = new System.Drawing.Font("Arial", 11F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCDodajGrupu";
            this.Size = new System.Drawing.Size(1099, 664);
            this.Load += new System.EventHandler(this.UCDodajGrupu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanstva)).EndInit();
            this.gbDodajClanove.ResumeLayout(false);
            this.gbDodajClanove.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox tbClanId;
        private System.Windows.Forms.TextBox tbBrojClanova;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTreningProgram;
        private System.Windows.Forms.ComboBox cbTreningProgram;
        private System.Windows.Forms.DataGridView dgvClanstva;
        private System.Windows.Forms.Button btnObrisiClanove;
        private System.Windows.Forms.GroupBox gbDodajClanove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbClanovi;
        private System.Windows.Forms.Label lblClan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNeizmireno;
        private System.Windows.Forms.DateTimePicker dtpPoslednjePlacanje;
        private System.Windows.Forms.Label lblPoslednjePlacanje;
        private System.Windows.Forms.DateTimePicker dtpUclanjenje;
        private System.Windows.Forms.Button btnDodajClana;
        private System.Windows.Forms.Button btnSacuvajGrupu;
        private System.Windows.Forms.Label lblError;
    }
}
