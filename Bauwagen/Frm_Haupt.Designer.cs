﻿namespace Bauwagen
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CmD_Systemsteuerung = new System.Windows.Forms.Button();
            this.FlW_Anwender = new System.Windows.Forms.FlowLayoutPanel();
            this.FlW_Verbrauchsgüter = new System.Windows.Forms.FlowLayoutPanel();
            this.CmD_Logout = new System.Windows.Forms.Button();
            this.DgV_Warenkorb = new System.Windows.Forms.DataGridView();
            this.CmD_Buchen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LbL_Summe = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LbL_Budget = new System.Windows.Forms.Label();
            this.LbL_Verfügbar = new System.Windows.Forms.Label();
            this.CmD_LöschenWarenkorb = new System.Windows.Forms.Button();
            this.LbL_Kredit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LbL_User = new System.Windows.Forms.Label();
            this.TmR_Backup = new System.Windows.Forms.Timer(this.components);
            this.TmR_Refresh = new System.Windows.Forms.Timer(this.components);
            this.Gütername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anzahl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Summe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgV_Warenkorb)).BeginInit();
            this.SuspendLayout();
            // 
            // CmD_Systemsteuerung
            // 
            this.CmD_Systemsteuerung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_Systemsteuerung.Location = new System.Drawing.Point(482, 580);
            this.CmD_Systemsteuerung.Name = "CmD_Systemsteuerung";
            this.CmD_Systemsteuerung.Size = new System.Drawing.Size(164, 39);
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
            this.FlW_Anwender.Size = new System.Drawing.Size(303, 607);
            this.FlW_Anwender.TabIndex = 3;
            // 
            // FlW_Verbrauchsgüter
            // 
            this.FlW_Verbrauchsgüter.AutoScroll = true;
            this.FlW_Verbrauchsgüter.Location = new System.Drawing.Point(695, 9);
            this.FlW_Verbrauchsgüter.Name = "FlW_Verbrauchsgüter";
            this.FlW_Verbrauchsgüter.Size = new System.Drawing.Size(303, 607);
            this.FlW_Verbrauchsgüter.TabIndex = 4;
            // 
            // CmD_Logout
            // 
            this.CmD_Logout.Enabled = false;
            this.CmD_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_Logout.Location = new System.Drawing.Point(321, 580);
            this.CmD_Logout.Name = "CmD_Logout";
            this.CmD_Logout.Size = new System.Drawing.Size(116, 39);
            this.CmD_Logout.TabIndex = 5;
            this.CmD_Logout.Text = "Logout";
            this.CmD_Logout.UseVisualStyleBackColor = true;
            this.CmD_Logout.Click += new System.EventHandler(this.CmD_Logout_Click);
            // 
            // DgV_Warenkorb
            // 
            this.DgV_Warenkorb.AllowUserToAddRows = false;
            this.DgV_Warenkorb.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgV_Warenkorb.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgV_Warenkorb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgV_Warenkorb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Gütername,
            this.Anzahl,
            this.Preis,
            this.Summe});
            this.DgV_Warenkorb.Location = new System.Drawing.Point(321, 12);
            this.DgV_Warenkorb.Name = "DgV_Warenkorb";
            this.DgV_Warenkorb.ReadOnly = true;
            this.DgV_Warenkorb.Size = new System.Drawing.Size(368, 360);
            this.DgV_Warenkorb.TabIndex = 6;
            // 
            // CmD_Buchen
            // 
            this.CmD_Buchen.Enabled = false;
            this.CmD_Buchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_Buchen.Location = new System.Drawing.Point(321, 535);
            this.CmD_Buchen.Name = "CmD_Buchen";
            this.CmD_Buchen.Size = new System.Drawing.Size(116, 39);
            this.CmD_Buchen.TabIndex = 5;
            this.CmD_Buchen.Text = "Buchen";
            this.CmD_Buchen.UseVisualStyleBackColor = true;
            this.CmD_Buchen.Click += new System.EventHandler(this.CmD_Buchen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(407, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Warenkorb Summe:";
            // 
            // LbL_Summe
            // 
            this.LbL_Summe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbL_Summe.Location = new System.Drawing.Point(540, 385);
            this.LbL_Summe.Name = "LbL_Summe";
            this.LbL_Summe.Size = new System.Drawing.Size(141, 24);
            this.LbL_Summe.TabIndex = 7;
            this.LbL_Summe.Text = "LbL_Summe";
            this.LbL_Summe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LbL_Summe.TextChanged += new System.EventHandler(this.LbL_Summe_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(388, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Verfügbares Guthaben:";
            // 
            // LbL_Budget
            // 
            this.LbL_Budget.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbL_Budget.Location = new System.Drawing.Point(540, 409);
            this.LbL_Budget.Name = "LbL_Budget";
            this.LbL_Budget.Size = new System.Drawing.Size(141, 24);
            this.LbL_Budget.TabIndex = 7;
            this.LbL_Budget.Text = "LbL_Budget";
            this.LbL_Budget.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LbL_Budget.TextChanged += new System.EventHandler(this.LbL_Budget_TextChanged);
            // 
            // LbL_Verfügbar
            // 
            this.LbL_Verfügbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbL_Verfügbar.Location = new System.Drawing.Point(540, 466);
            this.LbL_Verfügbar.Name = "LbL_Verfügbar";
            this.LbL_Verfügbar.Size = new System.Drawing.Size(141, 24);
            this.LbL_Verfügbar.TabIndex = 7;
            this.LbL_Verfügbar.Text = "LbL_Verfügbar";
            this.LbL_Verfügbar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CmD_LöschenWarenkorb
            // 
            this.CmD_LöschenWarenkorb.Enabled = false;
            this.CmD_LöschenWarenkorb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_LöschenWarenkorb.Location = new System.Drawing.Point(482, 535);
            this.CmD_LöschenWarenkorb.Name = "CmD_LöschenWarenkorb";
            this.CmD_LöschenWarenkorb.Size = new System.Drawing.Size(164, 39);
            this.CmD_LöschenWarenkorb.TabIndex = 5;
            this.CmD_LöschenWarenkorb.Text = "Warenkorb löschen";
            this.CmD_LöschenWarenkorb.UseVisualStyleBackColor = true;
            this.CmD_LöschenWarenkorb.Click += new System.EventHandler(this.CmD_LöschenWarenkorb_Click);
            // 
            // LbL_Kredit
            // 
            this.LbL_Kredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbL_Kredit.ForeColor = System.Drawing.Color.Gray;
            this.LbL_Kredit.Location = new System.Drawing.Point(540, 433);
            this.LbL_Kredit.Name = "LbL_Kredit";
            this.LbL_Kredit.Size = new System.Drawing.Size(141, 24);
            this.LbL_Kredit.TabIndex = 7;
            this.LbL_Kredit.Text = "LbL_Kredit";
            this.LbL_Kredit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LbL_Kredit.TextChanged += new System.EventHandler(this.LbL_Budget_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(415, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Verfügbarer Kredit:";
            // 
            // LbL_User
            // 
            this.LbL_User.AutoSize = true;
            this.LbL_User.Location = new System.Drawing.Point(636, 606);
            this.LbL_User.Name = "LbL_User";
            this.LbL_User.Size = new System.Drawing.Size(53, 13);
            this.LbL_User.TabIndex = 8;
            this.LbL_User.Text = "LbL_User";
            this.LbL_User.Visible = false;
            // 
            // TmR_Backup
            // 
            this.TmR_Backup.Enabled = true;
            this.TmR_Backup.Interval = 86400000;
            this.TmR_Backup.Tick += new System.EventHandler(this.TmR_Backup_Tick);
            // 
            // TmR_Refresh
            // 
            this.TmR_Refresh.Enabled = true;
            this.TmR_Refresh.Interval = 60000;
            this.TmR_Refresh.Tick += new System.EventHandler(this.TmR_Refresh_Tick);
            // 
            // Gütername
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gütername.DefaultCellStyle = dataGridViewCellStyle2;
            this.Gütername.HeaderText = "Name";
            this.Gütername.Name = "Gütername";
            this.Gütername.ReadOnly = true;
            // 
            // Anzahl
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Anzahl.DefaultCellStyle = dataGridViewCellStyle3;
            this.Anzahl.HeaderText = "Anzahl";
            this.Anzahl.Name = "Anzahl";
            this.Anzahl.ReadOnly = true;
            this.Anzahl.Width = 60;
            // 
            // Preis
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Preis.DefaultCellStyle = dataGridViewCellStyle4;
            this.Preis.HeaderText = "Preis";
            this.Preis.Name = "Preis";
            this.Preis.ReadOnly = true;
            this.Preis.Width = 80;
            // 
            // Summe
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Summe.DefaultCellStyle = dataGridViewCellStyle5;
            this.Summe.HeaderText = "Summe";
            this.Summe.Name = "Summe";
            this.Summe.ReadOnly = true;
            this.Summe.Width = 80;
            // 
            // Frm_Haupt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1008, 628);
            this.Controls.Add(this.CmD_LöschenWarenkorb);
            this.Controls.Add(this.LbL_User);
            this.Controls.Add(this.LbL_Verfügbar);
            this.Controls.Add(this.LbL_Kredit);
            this.Controls.Add(this.LbL_Budget);
            this.Controls.Add(this.LbL_Summe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgV_Warenkorb);
            this.Controls.Add(this.CmD_Buchen);
            this.Controls.Add(this.CmD_Logout);
            this.Controls.Add(this.FlW_Verbrauchsgüter);
            this.Controls.Add(this.FlW_Anwender);
            this.Controls.Add(this.CmD_Systemsteuerung);
            this.Name = "Frm_Haupt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbL_Summe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LbL_Budget;
        private System.Windows.Forms.Label LbL_Verfügbar;
        private System.Windows.Forms.Button CmD_LöschenWarenkorb;
        private System.Windows.Forms.Label LbL_Kredit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LbL_User;
        private System.Windows.Forms.Timer TmR_Backup;
        private System.Windows.Forms.Timer TmR_Refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gütername;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anzahl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Summe;
    }
}

