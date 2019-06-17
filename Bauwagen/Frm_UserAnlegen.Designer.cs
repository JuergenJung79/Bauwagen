namespace Bauwagen
{
    partial class Frm_UserAnlegen
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxT_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxT_Vorname = new System.Windows.Forms.TextBox();
            this.CmD_Create = new System.Windows.Forms.Button();
            this.CmD_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // TxT_Name
            // 
            this.TxT_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxT_Name.Location = new System.Drawing.Point(126, 21);
            this.TxT_Name.Name = "TxT_Name";
            this.TxT_Name.Size = new System.Drawing.Size(199, 31);
            this.TxT_Name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Vorname";
            // 
            // TxT_Vorname
            // 
            this.TxT_Vorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxT_Vorname.Location = new System.Drawing.Point(126, 58);
            this.TxT_Vorname.Name = "TxT_Vorname";
            this.TxT_Vorname.Size = new System.Drawing.Size(199, 31);
            this.TxT_Vorname.TabIndex = 1;
            // 
            // CmD_Create
            // 
            this.CmD_Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_Create.Location = new System.Drawing.Point(665, 21);
            this.CmD_Create.Name = "CmD_Create";
            this.CmD_Create.Size = new System.Drawing.Size(123, 53);
            this.CmD_Create.TabIndex = 2;
            this.CmD_Create.Text = "Speichern";
            this.CmD_Create.UseVisualStyleBackColor = true;
            this.CmD_Create.Click += new System.EventHandler(this.CmD_Create_Click);
            // 
            // CmD_Close
            // 
            this.CmD_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_Close.Location = new System.Drawing.Point(665, 80);
            this.CmD_Close.Name = "CmD_Close";
            this.CmD_Close.Size = new System.Drawing.Size(123, 53);
            this.CmD_Close.TabIndex = 2;
            this.CmD_Close.Text = "abbrechen";
            this.CmD_Close.UseVisualStyleBackColor = true;
            this.CmD_Close.Click += new System.EventHandler(this.CmD_Close_Click);
            // 
            // Frm_UserAnlegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmD_Close);
            this.Controls.Add(this.CmD_Create);
            this.Controls.Add(this.TxT_Vorname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxT_Name);
            this.Controls.Add(this.label1);
            this.Name = "Frm_UserAnlegen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Benutzer anlegen";
            this.Load += new System.EventHandler(this.Frm_UserAnlegen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxT_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxT_Vorname;
        private System.Windows.Forms.Button CmD_Create;
        private System.Windows.Forms.Button CmD_Close;
    }
}