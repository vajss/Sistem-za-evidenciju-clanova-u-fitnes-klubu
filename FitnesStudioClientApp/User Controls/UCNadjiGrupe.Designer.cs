namespace FitnesStudioClientApp.User_Controls
{
    partial class UCNadjiGrupe
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
            this.dgvGrupe = new System.Windows.Forms.DataGridView();
            this.btnIzmeniGrupu = new System.Windows.Forms.Button();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblPretraga = new System.Windows.Forms.Label();
            this.tbPretraga = new System.Windows.Forms.TextBox();
            this.lblIzmenaError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupe)).BeginInit();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Salmon;
            this.lblError.Location = new System.Drawing.Point(24, 141);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 19);
            this.lblError.TabIndex = 37;
            // 
            // dgvGrupe
            // 
            this.dgvGrupe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvGrupe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGrupe.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvGrupe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupe.Location = new System.Drawing.Point(22, 168);
            this.dgvGrupe.MultiSelect = false;
            this.dgvGrupe.Name = "dgvGrupe";
            this.dgvGrupe.ReadOnly = true;
            this.dgvGrupe.Size = new System.Drawing.Size(720, 374);
            this.dgvGrupe.TabIndex = 36;
            // 
            // btnIzmeniGrupu
            // 
            this.btnIzmeniGrupu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIzmeniGrupu.BackColor = System.Drawing.Color.PowderBlue;
            this.btnIzmeniGrupu.FlatAppearance.BorderSize = 0;
            this.btnIzmeniGrupu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzmeniGrupu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniGrupu.ForeColor = System.Drawing.Color.Transparent;
            this.btnIzmeniGrupu.Location = new System.Drawing.Point(644, 572);
            this.btnIzmeniGrupu.Name = "btnIzmeniGrupu";
            this.btnIzmeniGrupu.Size = new System.Drawing.Size(98, 39);
            this.btnIzmeniGrupu.TabIndex = 35;
            this.btnIzmeniGrupu.Text = "Prikaži grupu";
            this.btnIzmeniGrupu.UseVisualStyleBackColor = false;
            this.btnIzmeniGrupu.Click += new System.EventHandler(this.btnIzmeniGrupu_Click);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPretrazi.BackColor = System.Drawing.Color.PowderBlue;
            this.btnPretrazi.FlatAppearance.BorderSize = 0;
            this.btnPretrazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPretrazi.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretrazi.ForeColor = System.Drawing.Color.Transparent;
            this.btnPretrazi.Location = new System.Drawing.Point(390, 92);
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
            this.lblNaslov.Location = new System.Drawing.Point(18, 26);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(161, 24);
            this.lblNaslov.TabIndex = 33;
            this.lblNaslov.Text = "Pretraga grupa";
            // 
            // lblPretraga
            // 
            this.lblPretraga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.Location = new System.Drawing.Point(20, 100);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(68, 17);
            this.lblPretraga.TabIndex = 32;
            this.lblPretraga.Text = "Pretraga:";
            // 
            // tbPretraga
            // 
            this.tbPretraga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPretraga.Location = new System.Drawing.Point(94, 93);
            this.tbPretraga.Multiline = true;
            this.tbPretraga.Name = "tbPretraga";
            this.tbPretraga.Size = new System.Drawing.Size(290, 30);
            this.tbPretraga.TabIndex = 31;
            this.tbPretraga.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPretraga_KeyDown);
            // 
            // lblIzmenaError
            // 
            this.lblIzmenaError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIzmenaError.AutoSize = true;
            this.lblIzmenaError.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblIzmenaError.ForeColor = System.Drawing.Color.Salmon;
            this.lblIzmenaError.Location = new System.Drawing.Point(618, 547);
            this.lblIzmenaError.Name = "lblIzmenaError";
            this.lblIzmenaError.Size = new System.Drawing.Size(0, 18);
            this.lblIzmenaError.TabIndex = 38;
            // 
            // UCNadjiGrupe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblIzmenaError);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.dgvGrupe);
            this.Controls.Add(this.btnIzmeniGrupu);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.lblPretraga);
            this.Controls.Add(this.tbPretraga);
            this.Font = new System.Drawing.Font("Arial", 11F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCNadjiGrupe";
            this.Size = new System.Drawing.Size(768, 685);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.DataGridView dgvGrupe;
        private System.Windows.Forms.Button btnIzmeniGrupu;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblPretraga;
        private System.Windows.Forms.TextBox tbPretraga;
        private System.Windows.Forms.Label lblIzmenaError;
    }
}
