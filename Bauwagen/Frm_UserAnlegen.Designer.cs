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
            this.label2 = new System.Windows.Forms.Label();
            this.TxT_Vorname = new System.Windows.Forms.TextBox();
            this.CmD_Create = new System.Windows.Forms.Button();
            this.CmD_Close = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxT_Password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxT_Budget = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxT_Kredit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxT_TokenID = new System.Windows.Forms.TextBox();
            this.ChK_ChangePW = new System.Windows.Forms.CheckBox();
            this.CmB_User = new System.Windows.Forms.ComboBox();
            this.ChK_Aktiv = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Vorname";
            // 
            // TxT_Vorname
            // 
            this.TxT_Vorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxT_Vorname.Location = new System.Drawing.Point(134, 22);
            this.TxT_Vorname.Name = "TxT_Vorname";
            this.TxT_Vorname.Size = new System.Drawing.Size(199, 31);
            this.TxT_Vorname.TabIndex = 2;
            // 
            // CmD_Create
            // 
            this.CmD_Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_Create.Location = new System.Drawing.Point(392, 21);
            this.CmD_Create.Name = "CmD_Create";
            this.CmD_Create.Size = new System.Drawing.Size(123, 53);
            this.CmD_Create.TabIndex = 9;
            this.CmD_Create.Text = "Speichern";
            this.CmD_Create.UseVisualStyleBackColor = true;
            this.CmD_Create.Click += new System.EventHandler(this.CmD_Create_Click);
            // 
            // CmD_Close
            // 
            this.CmD_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_Close.Location = new System.Drawing.Point(392, 80);
            this.CmD_Close.Name = "CmD_Close";
            this.CmD_Close.Size = new System.Drawing.Size(123, 53);
            this.CmD_Close.TabIndex = 10;
            this.CmD_Close.Text = "abbrechen";
            this.CmD_Close.UseVisualStyleBackColor = true;
            this.CmD_Close.Click += new System.EventHandler(this.CmD_Close_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password";
            // 
            // TxT_Password
            // 
            this.TxT_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxT_Password.Location = new System.Drawing.Point(134, 91);
            this.TxT_Password.Name = "TxT_Password";
            this.TxT_Password.PasswordChar = '*';
            this.TxT_Password.Size = new System.Drawing.Size(199, 31);
            this.TxT_Password.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Budget";
            // 
            // TxT_Budget
            // 
            this.TxT_Budget.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxT_Budget.Location = new System.Drawing.Point(134, 158);
            this.TxT_Budget.Name = "TxT_Budget";
            this.TxT_Budget.Size = new System.Drawing.Size(199, 31);
            this.TxT_Budget.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kredit";
            // 
            // TxT_Kredit
            // 
            this.TxT_Kredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxT_Kredit.Location = new System.Drawing.Point(134, 195);
            this.TxT_Kredit.Name = "TxT_Kredit";
            this.TxT_Kredit.Size = new System.Drawing.Size(199, 31);
            this.TxT_Kredit.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Token";
            // 
            // TxT_TokenID
            // 
            this.TxT_TokenID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxT_TokenID.Location = new System.Drawing.Point(134, 256);
            this.TxT_TokenID.Name = "TxT_TokenID";
            this.TxT_TokenID.PasswordChar = '*';
            this.TxT_TokenID.Size = new System.Drawing.Size(199, 31);
            this.TxT_TokenID.TabIndex = 6;
            // 
            // ChK_ChangePW
            // 
            this.ChK_ChangePW.AutoSize = true;
            this.ChK_ChangePW.Checked = true;
            this.ChK_ChangePW.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChK_ChangePW.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChK_ChangePW.Location = new System.Drawing.Point(392, 173);
            this.ChK_ChangePW.Name = "ChK_ChangePW";
            this.ChK_ChangePW.Size = new System.Drawing.Size(204, 29);
            this.ChK_ChangePW.TabIndex = 7;
            this.ChK_ChangePW.Text = "Passwort ändern?";
            this.ChK_ChangePW.UseVisualStyleBackColor = true;
            // 
            // CmB_User
            // 
            this.CmB_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmB_User.FormattingEnabled = true;
            this.CmB_User.Location = new System.Drawing.Point(556, 21);
            this.CmB_User.Name = "CmB_User";
            this.CmB_User.Size = new System.Drawing.Size(277, 33);
            this.CmB_User.TabIndex = 999;
            this.CmB_User.TabStop = false;
            this.CmB_User.SelectedIndexChanged += new System.EventHandler(this.CmB_User_SelectedIndexChanged);
            // 
            // ChK_Aktiv
            // 
            this.ChK_Aktiv.AutoSize = true;
            this.ChK_Aktiv.Checked = true;
            this.ChK_Aktiv.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChK_Aktiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChK_Aktiv.Location = new System.Drawing.Point(392, 208);
            this.ChK_Aktiv.Name = "ChK_Aktiv";
            this.ChK_Aktiv.Size = new System.Drawing.Size(88, 29);
            this.ChK_Aktiv.TabIndex = 8;
            this.ChK_Aktiv.Text = "aktiv?";
            this.ChK_Aktiv.UseVisualStyleBackColor = true;
            // 
            // Frm_UserAnlegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(845, 323);
            this.Controls.Add(this.CmB_User);
            this.Controls.Add(this.ChK_Aktiv);
            this.Controls.Add(this.ChK_ChangePW);
            this.Controls.Add(this.CmD_Close);
            this.Controls.Add(this.CmD_Create);
            this.Controls.Add(this.TxT_TokenID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxT_Kredit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxT_Budget);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxT_Password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxT_Vorname);
            this.Controls.Add(this.label2);
            this.Name = "Frm_UserAnlegen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Benutzer anlegen";
            this.Load += new System.EventHandler(this.Frm_UserAnlegen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxT_Vorname;
        private System.Windows.Forms.Button CmD_Create;
        private System.Windows.Forms.Button CmD_Close;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxT_Password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxT_Budget;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxT_Kredit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxT_TokenID;
        private System.Windows.Forms.CheckBox ChK_ChangePW;
        private System.Windows.Forms.ComboBox CmB_User;
        private System.Windows.Forms.CheckBox ChK_Aktiv;
    }
}