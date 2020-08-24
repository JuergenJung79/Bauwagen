namespace Bauwagen
{
    partial class Frm_CocktailMixer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CmD_Klein_Schwach = new System.Windows.Forms.Button();
            this.CmD_klein_mittel = new System.Windows.Forms.Button();
            this.CmD_Klein_Stark = new System.Windows.Forms.Button();
            this.CmD_Groß_stark = new System.Windows.Forms.Button();
            this.CmD_Groß_mittel = new System.Windows.Forms.Button();
            this.CmD_Groß_schwach = new System.Windows.Forms.Button();
            this.FlW_Cocktails = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DgV_Warenkorb = new System.Windows.Forms.DataGridView();
            this.CmD_LöschenWarenkorb = new System.Windows.Forms.Button();
            this.CmD_Buchen = new System.Windows.Forms.Button();
            this.CmD_Logout = new System.Windows.Forms.Button();
            this.LbL_User = new System.Windows.Forms.Label();
            this.LbL_Verfügbar = new System.Windows.Forms.Label();
            this.LbL_Kredit = new System.Windows.Forms.Label();
            this.LbL_Budget = new System.Windows.Forms.Label();
            this.LbL_Summe = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CmD_InDenWarenkorb = new System.Windows.Forms.Button();
            this.Gütername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sträke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Summe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgV_Warenkorb)).BeginInit();
            this.SuspendLayout();
            // 
            // CmD_Klein_Schwach
            // 
            this.CmD_Klein_Schwach.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_Klein_Schwach.Location = new System.Drawing.Point(839, 70);
            this.CmD_Klein_Schwach.Name = "CmD_Klein_Schwach";
            this.CmD_Klein_Schwach.Size = new System.Drawing.Size(140, 70);
            this.CmD_Klein_Schwach.TabIndex = 5;
            this.CmD_Klein_Schwach.Text = "schwach";
            this.CmD_Klein_Schwach.UseVisualStyleBackColor = true;
            this.CmD_Klein_Schwach.Click += new System.EventHandler(this.CmD_Klein_Schwach_Click);
            // 
            // CmD_klein_mittel
            // 
            this.CmD_klein_mittel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_klein_mittel.Location = new System.Drawing.Point(839, 146);
            this.CmD_klein_mittel.Name = "CmD_klein_mittel";
            this.CmD_klein_mittel.Size = new System.Drawing.Size(140, 70);
            this.CmD_klein_mittel.TabIndex = 5;
            this.CmD_klein_mittel.Text = "mittel";
            this.CmD_klein_mittel.UseVisualStyleBackColor = true;
            this.CmD_klein_mittel.Click += new System.EventHandler(this.CmD_klein_mittel_Click);
            // 
            // CmD_Klein_Stark
            // 
            this.CmD_Klein_Stark.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_Klein_Stark.Location = new System.Drawing.Point(839, 222);
            this.CmD_Klein_Stark.Name = "CmD_Klein_Stark";
            this.CmD_Klein_Stark.Size = new System.Drawing.Size(140, 70);
            this.CmD_Klein_Stark.TabIndex = 5;
            this.CmD_Klein_Stark.Text = "stark";
            this.CmD_Klein_Stark.UseVisualStyleBackColor = true;
            this.CmD_Klein_Stark.Click += new System.EventHandler(this.CmD_Klein_Stark_Click);
            // 
            // CmD_Groß_stark
            // 
            this.CmD_Groß_stark.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_Groß_stark.Location = new System.Drawing.Point(996, 222);
            this.CmD_Groß_stark.Name = "CmD_Groß_stark";
            this.CmD_Groß_stark.Size = new System.Drawing.Size(140, 70);
            this.CmD_Groß_stark.TabIndex = 6;
            this.CmD_Groß_stark.Text = "stark";
            this.CmD_Groß_stark.UseVisualStyleBackColor = true;
            this.CmD_Groß_stark.Click += new System.EventHandler(this.CmD_Groß_stark_Click);
            // 
            // CmD_Groß_mittel
            // 
            this.CmD_Groß_mittel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_Groß_mittel.Location = new System.Drawing.Point(996, 146);
            this.CmD_Groß_mittel.Name = "CmD_Groß_mittel";
            this.CmD_Groß_mittel.Size = new System.Drawing.Size(140, 70);
            this.CmD_Groß_mittel.TabIndex = 7;
            this.CmD_Groß_mittel.Text = "mittel";
            this.CmD_Groß_mittel.UseVisualStyleBackColor = true;
            this.CmD_Groß_mittel.Click += new System.EventHandler(this.CmD_Groß_mittel_Click);
            // 
            // CmD_Groß_schwach
            // 
            this.CmD_Groß_schwach.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_Groß_schwach.Location = new System.Drawing.Point(996, 70);
            this.CmD_Groß_schwach.Name = "CmD_Groß_schwach";
            this.CmD_Groß_schwach.Size = new System.Drawing.Size(140, 70);
            this.CmD_Groß_schwach.TabIndex = 8;
            this.CmD_Groß_schwach.Text = "schwach";
            this.CmD_Groß_schwach.UseVisualStyleBackColor = true;
            this.CmD_Groß_schwach.Click += new System.EventHandler(this.CmD_Groß_schwach_Click);
            // 
            // FlW_Cocktails
            // 
            this.FlW_Cocktails.AutoScroll = true;
            this.FlW_Cocktails.Location = new System.Drawing.Point(12, 12);
            this.FlW_Cocktails.Name = "FlW_Cocktails";
            this.FlW_Cocktails.Size = new System.Drawing.Size(443, 607);
            this.FlW_Cocktails.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(885, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "klein";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1038, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "groß";
            // 
            // DgV_Warenkorb
            // 
            this.DgV_Warenkorb.AllowUserToAddRows = false;
            this.DgV_Warenkorb.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgV_Warenkorb.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.DgV_Warenkorb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgV_Warenkorb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Gütername,
            this.sträke,
            this.Preis,
            this.Summe});
            this.DgV_Warenkorb.Location = new System.Drawing.Point(462, 12);
            this.DgV_Warenkorb.Name = "DgV_Warenkorb";
            this.DgV_Warenkorb.ReadOnly = true;
            this.DgV_Warenkorb.Size = new System.Drawing.Size(368, 325);
            this.DgV_Warenkorb.TabIndex = 10;
            // 
            // CmD_LöschenWarenkorb
            // 
            this.CmD_LöschenWarenkorb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_LöschenWarenkorb.Location = new System.Drawing.Point(632, 532);
            this.CmD_LöschenWarenkorb.Name = "CmD_LöschenWarenkorb";
            this.CmD_LöschenWarenkorb.Size = new System.Drawing.Size(164, 39);
            this.CmD_LöschenWarenkorb.TabIndex = 11;
            this.CmD_LöschenWarenkorb.Text = "Warenkorb löschen";
            this.CmD_LöschenWarenkorb.UseVisualStyleBackColor = true;
            this.CmD_LöschenWarenkorb.Click += new System.EventHandler(this.CmD_LöschenWarenkorb_Click);
            // 
            // CmD_Buchen
            // 
            this.CmD_Buchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_Buchen.Location = new System.Drawing.Point(632, 451);
            this.CmD_Buchen.Name = "CmD_Buchen";
            this.CmD_Buchen.Size = new System.Drawing.Size(164, 52);
            this.CmD_Buchen.TabIndex = 12;
            this.CmD_Buchen.Text = "Buchen";
            this.CmD_Buchen.UseVisualStyleBackColor = true;
            this.CmD_Buchen.Click += new System.EventHandler(this.CmD_Buchen_Click);
            // 
            // CmD_Logout
            // 
            this.CmD_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_Logout.Location = new System.Drawing.Point(462, 577);
            this.CmD_Logout.Name = "CmD_Logout";
            this.CmD_Logout.Size = new System.Drawing.Size(164, 39);
            this.CmD_Logout.TabIndex = 13;
            this.CmD_Logout.Text = "Logout";
            this.CmD_Logout.UseVisualStyleBackColor = true;
            this.CmD_Logout.Click += new System.EventHandler(this.CmD_Logout_Click);
            // 
            // LbL_User
            // 
            this.LbL_User.AutoSize = true;
            this.LbL_User.Location = new System.Drawing.Point(777, 603);
            this.LbL_User.Name = "LbL_User";
            this.LbL_User.Size = new System.Drawing.Size(53, 13);
            this.LbL_User.TabIndex = 14;
            this.LbL_User.Text = "LbL_User";
            this.LbL_User.Visible = false;
            // 
            // LbL_Verfügbar
            // 
            this.LbL_Verfügbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbL_Verfügbar.Location = new System.Drawing.Point(689, 421);
            this.LbL_Verfügbar.Name = "LbL_Verfügbar";
            this.LbL_Verfügbar.Size = new System.Drawing.Size(141, 24);
            this.LbL_Verfügbar.TabIndex = 15;
            this.LbL_Verfügbar.Text = "LbL_Verfügbar";
            this.LbL_Verfügbar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LbL_Kredit
            // 
            this.LbL_Kredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbL_Kredit.ForeColor = System.Drawing.Color.Gray;
            this.LbL_Kredit.Location = new System.Drawing.Point(689, 388);
            this.LbL_Kredit.Name = "LbL_Kredit";
            this.LbL_Kredit.Size = new System.Drawing.Size(141, 24);
            this.LbL_Kredit.TabIndex = 16;
            this.LbL_Kredit.Text = "LbL_Kredit";
            this.LbL_Kredit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LbL_Budget
            // 
            this.LbL_Budget.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbL_Budget.Location = new System.Drawing.Point(689, 364);
            this.LbL_Budget.Name = "LbL_Budget";
            this.LbL_Budget.Size = new System.Drawing.Size(141, 24);
            this.LbL_Budget.TabIndex = 17;
            this.LbL_Budget.Text = "LbL_Budget";
            this.LbL_Budget.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LbL_Summe
            // 
            this.LbL_Summe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbL_Summe.Location = new System.Drawing.Point(689, 340);
            this.LbL_Summe.Name = "LbL_Summe";
            this.LbL_Summe.Size = new System.Drawing.Size(141, 24);
            this.LbL_Summe.TabIndex = 18;
            this.LbL_Summe.Text = "LbL_Summe";
            this.LbL_Summe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LbL_Summe.TextChanged += new System.EventHandler(this.LbL_Summe_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(564, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Verfügbarer Kredit:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(537, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Verfügbares Guthaben:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(556, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Warenkorb Summe:";
            // 
            // CmD_InDenWarenkorb
            // 
            this.CmD_InDenWarenkorb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_InDenWarenkorb.Location = new System.Drawing.Point(462, 451);
            this.CmD_InDenWarenkorb.Name = "CmD_InDenWarenkorb";
            this.CmD_InDenWarenkorb.Size = new System.Drawing.Size(164, 52);
            this.CmD_InDenWarenkorb.TabIndex = 11;
            this.CmD_InDenWarenkorb.Text = "Auswahl in Warenkorb";
            this.CmD_InDenWarenkorb.UseVisualStyleBackColor = true;
            this.CmD_InDenWarenkorb.Click += new System.EventHandler(this.CmD_InDenWarenkorb_Click);
            // 
            // Gütername
            // 
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gütername.DefaultCellStyle = dataGridViewCellStyle14;
            this.Gütername.HeaderText = "Name";
            this.Gütername.Name = "Gütername";
            this.Gütername.ReadOnly = true;
            // 
            // sträke
            // 
            this.sträke.HeaderText = "Stärke";
            this.sträke.Name = "sträke";
            this.sträke.ReadOnly = true;
            this.sträke.Width = 60;
            // 
            // Preis
            // 
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Preis.DefaultCellStyle = dataGridViewCellStyle15;
            this.Preis.HeaderText = "Preis";
            this.Preis.Name = "Preis";
            this.Preis.ReadOnly = true;
            this.Preis.Width = 80;
            // 
            // Summe
            // 
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Summe.DefaultCellStyle = dataGridViewCellStyle16;
            this.Summe.HeaderText = "Summe";
            this.Summe.Name = "Summe";
            this.Summe.ReadOnly = true;
            this.Summe.Width = 80;
            // 
            // Frm_CocktailMixer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 628);
            this.Controls.Add(this.LbL_Verfügbar);
            this.Controls.Add(this.LbL_Kredit);
            this.Controls.Add(this.LbL_Budget);
            this.Controls.Add(this.LbL_Summe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LbL_User);
            this.Controls.Add(this.CmD_InDenWarenkorb);
            this.Controls.Add(this.CmD_LöschenWarenkorb);
            this.Controls.Add(this.CmD_Buchen);
            this.Controls.Add(this.CmD_Logout);
            this.Controls.Add(this.DgV_Warenkorb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmD_Groß_stark);
            this.Controls.Add(this.CmD_Groß_mittel);
            this.Controls.Add(this.CmD_Groß_schwach);
            this.Controls.Add(this.CmD_Klein_Stark);
            this.Controls.Add(this.CmD_klein_mittel);
            this.Controls.Add(this.CmD_Klein_Schwach);
            this.Controls.Add(this.FlW_Cocktails);
            this.Name = "Frm_CocktailMixer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cocktail Mixer Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_CocktailMixer_FormClosing);
            this.Load += new System.EventHandler(this.Frm_CocktailMixer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgV_Warenkorb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlW_Cocktails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgV_Warenkorb;
        private System.Windows.Forms.Button CmD_LöschenWarenkorb;
        private System.Windows.Forms.Button CmD_Buchen;
        private System.Windows.Forms.Button CmD_Logout;
        private System.Windows.Forms.Label LbL_User;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label LbL_Kredit;
        public System.Windows.Forms.Label LbL_Budget;
        private System.Windows.Forms.Button CmD_Klein_Schwach;
        private System.Windows.Forms.Button CmD_klein_mittel;
        private System.Windows.Forms.Button CmD_Klein_Stark;
        private System.Windows.Forms.Button CmD_Groß_stark;
        private System.Windows.Forms.Button CmD_Groß_mittel;
        private System.Windows.Forms.Button CmD_Groß_schwach;
        public System.Windows.Forms.Label LbL_Verfügbar;
        public System.Windows.Forms.Label LbL_Summe;
        private System.Windows.Forms.Button CmD_InDenWarenkorb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gütername;
        private System.Windows.Forms.DataGridViewTextBoxColumn sträke;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Summe;
    }
}