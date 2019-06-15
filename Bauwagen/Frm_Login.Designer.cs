namespace Bauwagen
{
    partial class Frm_Login
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
            this.TxT_Password = new System.Windows.Forms.TextBox();
            this.LbL_Status = new System.Windows.Forms.Label();
            this.CmD_OK = new System.Windows.Forms.Button();
            this.CmD_Cancel = new System.Windows.Forms.Button();
            this.LbL_Username = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password";
            // 
            // TxT_Password
            // 
            this.TxT_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxT_Password.Location = new System.Drawing.Point(131, 34);
            this.TxT_Password.Name = "TxT_Password";
            this.TxT_Password.PasswordChar = '*';
            this.TxT_Password.Size = new System.Drawing.Size(132, 29);
            this.TxT_Password.TabIndex = 1;
            this.TxT_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxT_Password_KeyDown);
            // 
            // LbL_Status
            // 
            this.LbL_Status.AutoSize = true;
            this.LbL_Status.Location = new System.Drawing.Point(12, 76);
            this.LbL_Status.Name = "LbL_Status";
            this.LbL_Status.Size = new System.Drawing.Size(37, 13);
            this.LbL_Status.TabIndex = 2;
            this.LbL_Status.Text = "Status";
            this.LbL_Status.Visible = false;
            // 
            // CmD_OK
            // 
            this.CmD_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_OK.Location = new System.Drawing.Point(325, 12);
            this.CmD_OK.Name = "CmD_OK";
            this.CmD_OK.Size = new System.Drawing.Size(93, 34);
            this.CmD_OK.TabIndex = 3;
            this.CmD_OK.Text = "OK";
            this.CmD_OK.UseVisualStyleBackColor = true;
            this.CmD_OK.Click += new System.EventHandler(this.CmD_OK_Click);
            // 
            // CmD_Cancel
            // 
            this.CmD_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_Cancel.Location = new System.Drawing.Point(325, 52);
            this.CmD_Cancel.Name = "CmD_Cancel";
            this.CmD_Cancel.Size = new System.Drawing.Size(93, 34);
            this.CmD_Cancel.TabIndex = 3;
            this.CmD_Cancel.Text = "Cancel";
            this.CmD_Cancel.UseVisualStyleBackColor = true;
            this.CmD_Cancel.Click += new System.EventHandler(this.CmD_Cancel_Click);
            // 
            // LbL_Username
            // 
            this.LbL_Username.AutoSize = true;
            this.LbL_Username.Location = new System.Drawing.Point(53, 76);
            this.LbL_Username.Name = "LbL_Username";
            this.LbL_Username.Size = new System.Drawing.Size(55, 13);
            this.LbL_Username.TabIndex = 2;
            this.LbL_Username.Text = "Username";
            this.LbL_Username.Visible = false;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(430, 98);
            this.Controls.Add(this.CmD_Cancel);
            this.Controls.Add(this.CmD_OK);
            this.Controls.Add(this.LbL_Username);
            this.Controls.Add(this.LbL_Status);
            this.Controls.Add(this.TxT_Password);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxT_Password;
        public System.Windows.Forms.Label LbL_Status;
        private System.Windows.Forms.Button CmD_OK;
        private System.Windows.Forms.Button CmD_Cancel;
        public System.Windows.Forms.Label LbL_Username;
    }
}