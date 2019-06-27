namespace Bauwagen
{
    partial class Frm_ChangePassword
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
            this.CmD_Cancel = new System.Windows.Forms.Button();
            this.CmD_OK = new System.Windows.Forms.Button();
            this.LbL_Username = new System.Windows.Forms.Label();
            this.LbL_Status = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxT_Password_1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxT_Password_2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CmD_Cancel
            // 
            this.CmD_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_Cancel.Location = new System.Drawing.Point(217, 138);
            this.CmD_Cancel.Name = "CmD_Cancel";
            this.CmD_Cancel.Size = new System.Drawing.Size(93, 34);
            this.CmD_Cancel.TabIndex = 4;
            this.CmD_Cancel.Text = "Cancel";
            this.CmD_Cancel.UseVisualStyleBackColor = true;
            // 
            // CmD_OK
            // 
            this.CmD_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_OK.Location = new System.Drawing.Point(118, 138);
            this.CmD_OK.Name = "CmD_OK";
            this.CmD_OK.Size = new System.Drawing.Size(93, 34);
            this.CmD_OK.TabIndex = 3;
            this.CmD_OK.Text = "OK";
            this.CmD_OK.UseVisualStyleBackColor = true;
            this.CmD_OK.Click += new System.EventHandler(this.CmD_OK_Click);
            // 
            // LbL_Username
            // 
            this.LbL_Username.AutoSize = true;
            this.LbL_Username.Location = new System.Drawing.Point(256, 9);
            this.LbL_Username.Name = "LbL_Username";
            this.LbL_Username.Size = new System.Drawing.Size(55, 13);
            this.LbL_Username.TabIndex = 6;
            this.LbL_Username.Text = "Username";
            this.LbL_Username.Visible = false;
            // 
            // LbL_Status
            // 
            this.LbL_Status.AutoSize = true;
            this.LbL_Status.Location = new System.Drawing.Point(215, 9);
            this.LbL_Status.Name = "LbL_Status";
            this.LbL_Status.Size = new System.Drawing.Size(37, 13);
            this.LbL_Status.TabIndex = 7;
            this.LbL_Status.Text = "Status";
            this.LbL_Status.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "neues Password";
            // 
            // TxT_Password_1
            // 
            this.TxT_Password_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxT_Password_1.Location = new System.Drawing.Point(218, 42);
            this.TxT_Password_1.Name = "TxT_Password_1";
            this.TxT_Password_1.PasswordChar = '*';
            this.TxT_Password_1.Size = new System.Drawing.Size(132, 29);
            this.TxT_Password_1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Wiederholen";
            // 
            // TxT_Password_2
            // 
            this.TxT_Password_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxT_Password_2.Location = new System.Drawing.Point(218, 77);
            this.TxT_Password_2.Name = "TxT_Password_2";
            this.TxT_Password_2.PasswordChar = '*';
            this.TxT_Password_2.Size = new System.Drawing.Size(132, 29);
            this.TxT_Password_2.TabIndex = 2;
            // 
            // Frm_ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 188);
            this.Controls.Add(this.CmD_Cancel);
            this.Controls.Add(this.CmD_OK);
            this.Controls.Add(this.LbL_Username);
            this.Controls.Add(this.LbL_Status);
            this.Controls.Add(this.TxT_Password_2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxT_Password_1);
            this.Controls.Add(this.label2);
            this.Name = "Frm_ChangePassword";
            this.Text = "Frm_ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmD_Cancel;
        private System.Windows.Forms.Button CmD_OK;
        public System.Windows.Forms.Label LbL_Username;
        public System.Windows.Forms.Label LbL_Status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxT_Password_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxT_Password_2;
    }
}