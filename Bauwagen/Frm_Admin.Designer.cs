namespace Bauwagen
{
    partial class Frm_Admin
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
            this.CmD_CreateTables = new System.Windows.Forms.Button();
            this.CmD_CreateUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmD_CreateTables
            // 
            this.CmD_CreateTables.Location = new System.Drawing.Point(12, 197);
            this.CmD_CreateTables.Name = "CmD_CreateTables";
            this.CmD_CreateTables.Size = new System.Drawing.Size(111, 25);
            this.CmD_CreateTables.TabIndex = 0;
            this.CmD_CreateTables.Text = "Tabellen erstellen";
            this.CmD_CreateTables.UseVisualStyleBackColor = true;
            this.CmD_CreateTables.Click += new System.EventHandler(this.CmD_CreateTables_Click);
            // 
            // CmD_CreateUser
            // 
            this.CmD_CreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_CreateUser.Location = new System.Drawing.Point(12, 12);
            this.CmD_CreateUser.Name = "CmD_CreateUser";
            this.CmD_CreateUser.Size = new System.Drawing.Size(111, 60);
            this.CmD_CreateUser.TabIndex = 1;
            this.CmD_CreateUser.Text = "User anlegen";
            this.CmD_CreateUser.UseVisualStyleBackColor = true;
            this.CmD_CreateUser.Click += new System.EventHandler(this.CmD_CreateUser_Click);
            // 
            // Frm_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 234);
            this.Controls.Add(this.CmD_CreateUser);
            this.Controls.Add(this.CmD_CreateTables);
            this.Name = "Frm_Admin";
            this.Text = "Administration";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmD_CreateTables;
        private System.Windows.Forms.Button CmD_CreateUser;
    }
}