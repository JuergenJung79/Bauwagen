namespace Bauwagen
{
    partial class Frm_Haupt
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.CmD_Systemsteuerung = new System.Windows.Forms.Button();
            this.FlW_Anwender = new System.Windows.Forms.FlowLayoutPanel();
            this.FlW_Verbrauchsgüter = new System.Windows.Forms.FlowLayoutPanel();
            this.CmD_Logout = new System.Windows.Forms.Button();
            this.DgV_Warenkorb = new System.Windows.Forms.DataGridView();
            this.Gütername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anzahl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Summe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmD_Buchen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LbL_Summe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgV_Warenkorb)).BeginInit();
            this.SuspendLayout();
            // 
            // CmD_Systemsteuerung
            // 
            this.CmD_Systemsteuerung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_Systemsteuerung.Location = new System.Drawing.Point(308, 580);
            this.CmD_Systemsteuerung.Name = "CmD_Systemsteuerung";
            this.CmD_Systemsteuerung.Size = new System.Drawing.Size(175, 39);
            this.CmD_Systemsteuerung.TabIndex = 1;
            this.CmD_Systemsteuerung.Text = "Systemsteuerung";
            this.CmD_Systemsteuerung.UseVisualStyleBackColor = true;
            this.CmD_Systemsteuerung.Click += new System.EventHandler(this.CmD_Systemsteuerung_Click);
            // 
            // FlW_Anwender
            // 
            this.FlW_Anwender.AutoScroll = true;
            this.FlW_Anwender.Location = new System.Drawing.Point(12, 12);
            this.FlW_Anwender.Name = "FlW_Anwender";
            this.FlW_Anwender.Size = new System.Drawing.Size(290, 607);
            this.FlW_Anwender.TabIndex = 3;
            // 
            // FlW_Verbrauchsgüter
            // 
            this.FlW_Verbrauchsgüter.AutoScroll = true;
            this.FlW_Verbrauchsgüter.Location = new System.Drawing.Point(914, 12);
            this.FlW_Verbrauchsgüter.Name = "FlW_Verbrauchsgüter";
            this.FlW_Verbrauchsgüter.Size = new System.Drawing.Size(290, 607);
            this.FlW_Verbrauchsgüter.TabIndex = 4;
            // 
            // CmD_Logout
            // 
            this.CmD_Logout.Enabled = false;
            this.CmD_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_Logout.Location = new System.Drawing.Point(787, 580);
            this.CmD_Logout.Name = "CmD_Logout";
            this.CmD_Logout.Size = new System.Drawing.Size(121, 39);
            this.CmD_Logout.TabIndex = 5;
            this.CmD_Logout.Text = "Logout";
            this.CmD_Logout.UseVisualStyleBackColor = true;
            this.CmD_Logout.Click += new System.EventHandler(this.CmD_Logout_Click);
            // 
            // DgV_Warenkorb
            // 
            this.DgV_Warenkorb.AllowUserToAddRows = false;
            this.DgV_Warenkorb.AllowUserToDeleteRows = false;
            this.DgV_Warenkorb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgV_Warenkorb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Gütername,
            this.Anzahl,
            this.Preis,
            this.Summe});
            this.DgV_Warenkorb.Location = new System.Drawing.Point(308, 12);
            this.DgV_Warenkorb.Name = "DgV_Warenkorb";
            this.DgV_Warenkorb.ReadOnly = true;
            this.DgV_Warenkorb.Size = new System.Drawing.Size(600, 360);
            this.DgV_Warenkorb.TabIndex = 6;
            // 
            // Gütername
            // 
            this.Gütername.HeaderText = "Name";
            this.Gütername.Name = "Gütername";
            this.Gütername.ReadOnly = true;
            this.Gütername.Width = 150;
            // 
            // Anzahl
            // 
            this.Anzahl.HeaderText = "Anzahl";
            this.Anzahl.Name = "Anzahl";
            this.Anzahl.ReadOnly = true;
            // 
            // Preis
            // 
            this.Preis.HeaderText = "Preis";
            this.Preis.Name = "Preis";
            this.Preis.ReadOnly = true;
            this.Preis.Width = 130;
            // 
            // Summe
            // 
            this.Summe.HeaderText = "Summe";
            this.Summe.Name = "Summe";
            this.Summe.ReadOnly = true;
            this.Summe.Width = 150;
            // 
            // CmD_Buchen
            // 
            this.CmD_Buchen.Enabled = false;
            this.CmD_Buchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_Buchen.Location = new System.Drawing.Point(570, 580);
            this.CmD_Buchen.Name = "CmD_Buchen";
            this.CmD_Buchen.Size = new System.Drawing.Size(121, 39);
            this.CmD_Buchen.TabIndex = 5;
            this.CmD_Buchen.Text = "Buchen";
            this.CmD_Buchen.UseVisualStyleBackColor = true;
            this.CmD_Buchen.Click += new System.EventHandler(this.CmD_Buchen_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(582, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Warenkorb Summe:";
            // 
            // LbL_Summe
            // 
            this.LbL_Summe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.LbL_Summe.Location = new System.Drawing.Point(767, 401);
            this.LbL_Summe.Name = "LbL_Summe";
            this.LbL_Summe.Size = new System.Drawing.Size(141, 24);
            this.LbL_Summe.TabIndex = 7;
            this.LbL_Summe.Text = "LbL_Summe";
            this.LbL_Summe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Frm_Haupt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1216, 628);
            this.Controls.Add(this.LbL_Summe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgV_Warenkorb);
            this.Controls.Add(this.CmD_Buchen);
            this.Controls.Add(this.CmD_Logout);
            this.Controls.Add(this.FlW_Verbrauchsgüter);
            this.Controls.Add(this.FlW_Anwender);
            this.Controls.Add(this.CmD_Systemsteuerung);
            this.Name = "Frm_Haupt";
            this.Text = "Bauwagen";
            this.Load += new System.EventHandler(this.Frm_Haupt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgV_Warenkorb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CmD_Systemsteuerung;
        private System.Windows.Forms.FlowLayoutPanel FlW_Anwender;
        private System.Windows.Forms.FlowLayoutPanel FlW_Verbrauchsgüter;
        private System.Windows.Forms.Button CmD_Logout;
        private System.Windows.Forms.DataGridView DgV_Warenkorb;
        private System.Windows.Forms.Button CmD_Buchen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gütername;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anzahl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Summe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbL_Summe;
    }
}

