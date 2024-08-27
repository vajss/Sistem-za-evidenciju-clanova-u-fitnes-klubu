namespace FitnesStudioClientApp.User_Controls
{
    partial class UCDodajTermin
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
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.tbTrajanje = new System.Windows.Forms.TextBox();
            this.lblGrupa = new System.Windows.Forms.Label();
            this.lblTrajanje = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.cbGrupa = new System.Windows.Forms.ComboBox();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblTrajanjeError = new System.Windows.Forms.Label();
            this.tbTerminId = new System.Windows.Forms.TextBox();
            this.lblTerminId = new System.Windows.Forms.Label();
            this.lblTerminIdError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpDatum
            // 
            this.dtpDatum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDatum.CustomFormat = "dd.MM.yyyy.";
            this.dtpDatum.Font = new System.Drawing.Font("Arial", 11F);
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatum.Location = new System.Drawing.Point(253, 206);
            this.dtpDatum.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(173, 24);
            this.dtpDatum.TabIndex = 24;
            // 
            // tbTrajanje
            // 
            this.tbTrajanje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbTrajanje.Font = new System.Drawing.Font("Arial", 11F);
            this.tbTrajanje.Location = new System.Drawing.Point(253, 261);
            this.tbTrajanje.Margin = new System.Windows.Forms.Padding(4);
            this.tbTrajanje.Multiline = true;
            this.tbTrajanje.Name = "tbTrajanje";
            this.tbTrajanje.Size = new System.Drawing.Size(173, 23);
            this.tbTrajanje.TabIndex = 22;
            // 
            // lblGrupa
            // 
            this.lblGrupa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGrupa.AutoSize = true;
            this.lblGrupa.Font = new System.Drawing.Font("Arial", 11F);
            this.lblGrupa.Location = new System.Drawing.Point(160, 155);
            this.lblGrupa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrupa.Name = "lblGrupa";
            this.lblGrupa.Size = new System.Drawing.Size(52, 17);
            this.lblGrupa.TabIndex = 18;
            this.lblGrupa.Text = "Grupa:";
            // 
            // lblTrajanje
            // 
            this.lblTrajanje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTrajanje.AutoSize = true;
            this.lblTrajanje.Font = new System.Drawing.Font("Arial", 11F);
            this.lblTrajanje.Location = new System.Drawing.Point(160, 263);
            this.lblTrajanje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrajanje.Name = "lblTrajanje";
            this.lblTrajanje.Size = new System.Drawing.Size(63, 17);
            this.lblTrajanje.TabIndex = 16;
            this.lblTrajanje.Text = "Trajanje:";
            // 
            // lblDatum
            // 
            this.lblDatum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Arial", 11F);
            this.lblDatum.Location = new System.Drawing.Point(160, 210);
            this.lblDatum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(56, 17);
            this.lblDatum.TabIndex = 15;
            this.lblDatum.Text = "Datum:";
            // 
            // cbGrupa
            // 
            this.cbGrupa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbGrupa.BackColor = System.Drawing.Color.White;
            this.cbGrupa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrupa.FormattingEnabled = true;
            this.cbGrupa.Location = new System.Drawing.Point(253, 153);
            this.cbGrupa.Name = "cbGrupa";
            this.cbGrupa.Size = new System.Drawing.Size(173, 21);
            this.cbGrupa.TabIndex = 25;
            // 
            // lblMin
            // 
            this.lblMin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Arial", 9F);
            this.lblMin.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblMin.Location = new System.Drawing.Point(431, 264);
            this.lblMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(36, 15);
            this.lblMin.TabIndex = 26;
            this.lblMin.Text = "(min)";
            // 
            // lblNaslov
            // 
            this.lblNaslov.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblNaslov.Location = new System.Drawing.Point(125, 67);
            this.lblNaslov.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(111, 19);
            this.lblNaslov.TabIndex = 27;
            this.lblNaslov.Text = "Unos termina";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSacuvaj.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSacuvaj.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnSacuvaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSacuvaj.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnSacuvaj.ForeColor = System.Drawing.Color.White;
            this.btnSacuvaj.Location = new System.Drawing.Point(317, 325);
            this.btnSacuvaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(109, 33);
            this.btnSacuvaj.TabIndex = 28;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.BtnSacuvaj_Click);
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.SystemColors.Control;
            this.lblError.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblError.ForeColor = System.Drawing.Color.Salmon;
            this.lblError.Location = new System.Drawing.Point(250, 301);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 29;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblTrajanjeError
            // 
            this.lblTrajanjeError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTrajanjeError.AutoSize = true;
            this.lblTrajanjeError.BackColor = System.Drawing.SystemColors.Control;
            this.lblTrajanjeError.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTrajanjeError.ForeColor = System.Drawing.Color.Salmon;
            this.lblTrajanjeError.Location = new System.Drawing.Point(475, 266);
            this.lblTrajanjeError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrajanjeError.Name = "lblTrajanjeError";
            this.lblTrajanjeError.Size = new System.Drawing.Size(0, 13);
            this.lblTrajanjeError.TabIndex = 30;
            this.lblTrajanjeError.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // tbTerminId
            // 
            this.tbTerminId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbTerminId.Font = new System.Drawing.Font("Arial", 11F);
            this.tbTerminId.Location = new System.Drawing.Point(253, 110);
            this.tbTerminId.Margin = new System.Windows.Forms.Padding(4);
            this.tbTerminId.Multiline = true;
            this.tbTerminId.Name = "tbTerminId";
            this.tbTerminId.Size = new System.Drawing.Size(173, 23);
            this.tbTerminId.TabIndex = 32;
            // 
            // lblTerminId
            // 
            this.lblTerminId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTerminId.AutoSize = true;
            this.lblTerminId.Font = new System.Drawing.Font("Arial", 11F);
            this.lblTerminId.Location = new System.Drawing.Point(160, 112);
            this.lblTerminId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTerminId.Name = "lblTerminId";
            this.lblTerminId.Size = new System.Drawing.Size(74, 17);
            this.lblTerminId.TabIndex = 31;
            this.lblTerminId.Text = "Termin ID:";
            // 
            // lblTerminIdError
            // 
            this.lblTerminIdError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTerminIdError.AutoSize = true;
            this.lblTerminIdError.BackColor = System.Drawing.SystemColors.Control;
            this.lblTerminIdError.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTerminIdError.ForeColor = System.Drawing.Color.Salmon;
            this.lblTerminIdError.Location = new System.Drawing.Point(437, 116);
            this.lblTerminIdError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTerminIdError.Name = "lblTerminIdError";
            this.lblTerminIdError.Size = new System.Drawing.Size(0, 13);
            this.lblTerminIdError.TabIndex = 33;
            this.lblTerminIdError.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // UCDodajTermin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblTerminIdError);
            this.Controls.Add(this.tbTerminId);
            this.Controls.Add(this.lblTerminId);
            this.Controls.Add(this.lblTrajanjeError);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.cbGrupa);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.tbTrajanje);
            this.Controls.Add(this.lblGrupa);
            this.Controls.Add(this.lblTrajanje);
            this.Controls.Add(this.lblDatum);
            this.Name = "UCDodajTermin";
            this.Size = new System.Drawing.Size(662, 665);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.TextBox tbTrajanje;
        private System.Windows.Forms.Label lblGrupa;
        private System.Windows.Forms.Label lblTrajanje;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.ComboBox cbGrupa;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblTrajanjeError;
        private System.Windows.Forms.TextBox tbTerminId;
        private System.Windows.Forms.Label lblTerminId;
        private System.Windows.Forms.Label lblTerminIdError;
    }
}
