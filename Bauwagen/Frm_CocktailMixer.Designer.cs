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
            System.Windows.Forms.Button button1;
            System.Windows.Forms.Button button2;
            System.Windows.Forms.Button button3;
            System.Windows.Forms.Button button4;
            System.Windows.Forms.Button button5;
            System.Windows.Forms.Button button6;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FlW_Anwender = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DgV_Warenkorb = new System.Windows.Forms.DataGridView();
            this.Gütername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anzahl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Summe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmD_LöschenWarenkorb = new System.Windows.Forms.Button();
            this.CmD_Buchen = new System.Windows.Forms.Button();
            this.CmD_Logout = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgV_Warenkorb)).BeginInit();
            this.SuspendLayout();
            // 
            // FlW_Anwender
            // 
            this.FlW_Anwender.AutoScroll = true;
            this.FlW_Anwender.Location = new System.Drawing.Point(12, 12);
            this.FlW_Anwender.Name = "FlW_Anwender";
            this.FlW_Anwender.Size = new System.Drawing.Size(443, 607);
            this.FlW_Anwender.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button1.Location = new System.Drawing.Point(839, 70);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(140, 70);
            button1.TabIndex = 5;
            button1.Text = "schwach";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button2.Location = new System.Drawing.Point(839, 146);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(140, 70);
            button2.TabIndex = 5;
            button2.Text = "mittel";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button3.Location = new System.Drawing.Point(839, 222);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(140, 70);
            button3.TabIndex = 5;
            button3.Text = "stark";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button4.Location = new System.Drawing.Point(996, 222);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(140, 70);
            button4.TabIndex = 6;
            button4.Text = "stark";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button5.Location = new System.Drawing.Point(996, 146);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(140, 70);
            button5.TabIndex = 7;
            button5.Text = "mittel";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button6.Location = new System.Drawing.Point(996, 70);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(140, 70);
            button6.TabIndex = 8;
            button6.Text = "schwach";
            button6.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgV_Warenkorb.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DgV_Warenkorb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgV_Warenkorb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Gütername,
            this.Anzahl,
            this.Preis,
            this.Summe});
            this.DgV_Warenkorb.Location = new System.Drawing.Point(462, 12);
            this.DgV_Warenkorb.Name = "DgV_Warenkorb";
            this.DgV_Warenkorb.ReadOnly = true;
            this.DgV_Warenkorb.Size = new System.Drawing.Size(368, 325);
            this.DgV_Warenkorb.TabIndex = 10;
            // 
            // Gütername
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gütername.DefaultCellStyle = dataGridViewCellStyle7;
            this.Gütername.HeaderText = "Name";
            this.Gütername.Name = "Gütername";
            this.Gütername.ReadOnly = true;
            // 
            // Anzahl
            // 
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Anzahl.DefaultCellStyle = dataGridViewCellStyle8;
            this.Anzahl.HeaderText = "Anzahl";
            this.Anzahl.Name = "Anzahl";
            this.Anzahl.ReadOnly = true;
            this.Anzahl.Width = 60;
            // 
            // Preis
            // 
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Preis.DefaultCellStyle = dataGridViewCellStyle9;
            this.Preis.HeaderText = "Preis";
            this.Preis.Name = "Preis";
            this.Preis.ReadOnly = true;
            this.Preis.Width = 80;
            // 
            // Summe
            // 
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Summe.DefaultCellStyle = dataGridViewCellStyle10;
            this.Summe.HeaderText = "Summe";
            this.Summe.Name = "Summe";
            this.Summe.ReadOnly = true;
            this.Summe.Width = 80;
            // 
            // CmD_LöschenWarenkorb
            // 
            this.CmD_LöschenWarenkorb.Enabled = false;
            this.CmD_LöschenWarenkorb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_LöschenWarenkorb.Location = new System.Drawing.Point(632, 532);
            this.CmD_LöschenWarenkorb.Name = "CmD_LöschenWarenkorb";
            this.CmD_LöschenWarenkorb.Size = new System.Drawing.Size(164, 39);
            this.CmD_LöschenWarenkorb.TabIndex = 11;
            this.CmD_LöschenWarenkorb.Text = "Warenkorb löschen";
            this.CmD_LöschenWarenkorb.UseVisualStyleBackColor = true;
            // 
            // CmD_Buchen
            // 
            this.CmD_Buchen.Enabled = false;
            this.CmD_Buchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_Buchen.Location = new System.Drawing.Point(632, 451);
            this.CmD_Buchen.Name = "CmD_Buchen";
            this.CmD_Buchen.Size = new System.Drawing.Size(164, 52);
            this.CmD_Buchen.TabIndex = 12;
            this.CmD_Buchen.Text = "Buchen";
            this.CmD_Buchen.UseVisualStyleBackColor = true;
            // 
            // CmD_Logout
            // 
            this.CmD_Logout.Enabled = false;
            this.CmD_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_Logout.Location = new System.Drawing.Point(462, 577);
            this.CmD_Logout.Name = "CmD_Logout";
            this.CmD_Logout.Size = new System.Drawing.Size(164, 39);
            this.CmD_Logout.TabIndex = 13;
            this.CmD_Logout.Text = "Logout";
            this.CmD_Logout.UseVisualStyleBackColor = true;
            // 
            // Frm_CocktailMixer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 628);
            this.Controls.Add(this.CmD_LöschenWarenkorb);
            this.Controls.Add(this.CmD_Buchen);
            this.Controls.Add(this.CmD_Logout);
            this.Controls.Add(this.DgV_Warenkorb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(button4);
            this.Controls.Add(button5);
            this.Controls.Add(button6);
            this.Controls.Add(button3);
            this.Controls.Add(button2);
            this.Controls.Add(button1);
            this.Controls.Add(this.FlW_Anwender);
            this.Name = "Frm_CocktailMixer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cocktail Mixer Admin";
            ((System.ComponentModel.ISupportInitialize)(this.DgV_Warenkorb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlW_Anwender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgV_Warenkorb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gütername;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anzahl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Summe;
        private System.Windows.Forms.Button CmD_LöschenWarenkorb;
        private System.Windows.Forms.Button CmD_Buchen;
        private System.Windows.Forms.Button CmD_Logout;
    }
}