namespace Bauwagen
{
    partial class Frm_UserListe
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgV_UserHistory = new System.Windows.Forms.DataGridView();
            this.Benutzer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Art = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Menge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Summe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TmR_Refresh = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DgV_UserHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // DgV_UserHistory
            // 
            this.DgV_UserHistory.AllowUserToAddRows = false;
            this.DgV_UserHistory.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgV_UserHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgV_UserHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgV_UserHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Benutzer,
            this.Art,
            this.Menge,
            this.Datum,
            this.Preis,
            this.Summe});
            this.DgV_UserHistory.Location = new System.Drawing.Point(12, 12);
            this.DgV_UserHistory.Name = "DgV_UserHistory";
            this.DgV_UserHistory.ReadOnly = true;
            this.DgV_UserHistory.Size = new System.Drawing.Size(776, 524);
            this.DgV_UserHistory.TabIndex = 0;
            // 
            // Benutzer
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Benutzer.DefaultCellStyle = dataGridViewCellStyle2;
            this.Benutzer.HeaderText = "Benutzer";
            this.Benutzer.Name = "Benutzer";
            this.Benutzer.ReadOnly = true;
            // 
            // Art
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Art.DefaultCellStyle = dataGridViewCellStyle3;
            this.Art.HeaderText = "Art";
            this.Art.Name = "Art";
            this.Art.ReadOnly = true;
            // 
            // Menge
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menge.DefaultCellStyle = dataGridViewCellStyle4;
            this.Menge.HeaderText = "Menge";
            this.Menge.Name = "Menge";
            this.Menge.ReadOnly = true;
            // 
            // Datum
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datum.DefaultCellStyle = dataGridViewCellStyle5;
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            this.Datum.Width = 200;
            // 
            // Preis
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Preis.DefaultCellStyle = dataGridViewCellStyle6;
            this.Preis.HeaderText = "Preis";
            this.Preis.Name = "Preis";
            this.Preis.ReadOnly = true;
            // 
            // Summe
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Summe.DefaultCellStyle = dataGridViewCellStyle7;
            this.Summe.HeaderText = "Summe";
            this.Summe.Name = "Summe";
            this.Summe.ReadOnly = true;
            // 
            // TmR_Refresh
            // 
            this.TmR_Refresh.Interval = 60000;
            this.TmR_Refresh.Tick += new System.EventHandler(this.TmR_Refresh_Tick);
            // 
            // Frm_UserListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 548);
            this.Controls.Add(this.DgV_UserHistory);
            this.Name = "Frm_UserListe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entnahmeprotokoll";
            this.Load += new System.EventHandler(this.Frm_UserListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgV_UserHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgV_UserHistory;
        private System.Windows.Forms.Timer TmR_Refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Benutzer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Art;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Summe;
    }
}