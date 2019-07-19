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
            this.CmD_Geldaufladen = new System.Windows.Forms.Button();
            this.CmD_GüterBearbeiten = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxT_Unverschlüsselt = new System.Windows.Forms.TextBox();
            this.TxT_Verschlüsselt = new System.Windows.Forms.TextBox();
            this.CmD_Backup = new System.Windows.Forms.Button();
            this.PgB_Backup_Personen = new System.Windows.Forms.ProgressBar();
            this.PgB_Backup_Güter = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.CmD_Restore = new System.Windows.Forms.Button();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.progressBar6 = new System.Windows.Forms.ProgressBar();
            this.progressBar7 = new System.Windows.Forms.ProgressBar();
            this.progressBar8 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // CmD_CreateTables
            // 
            this.CmD_CreateTables.Location = new System.Drawing.Point(12, 197);
            this.CmD_CreateTables.Name = "CmD_CreateTables";
            this.CmD_CreateTables.Size = new System.Drawing.Size(130, 25);
            this.CmD_CreateTables.TabIndex = 0;
            this.CmD_CreateTables.TabStop = false;
            this.CmD_CreateTables.Text = "Tabellen erstellen";
            this.CmD_CreateTables.UseVisualStyleBackColor = true;
            this.CmD_CreateTables.Click += new System.EventHandler(this.CmD_CreateTables_Click);
            // 
            // CmD_CreateUser
            // 
            this.CmD_CreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_CreateUser.Location = new System.Drawing.Point(12, 12);
            this.CmD_CreateUser.Name = "CmD_CreateUser";
            this.CmD_CreateUser.Size = new System.Drawing.Size(130, 60);
            this.CmD_CreateUser.TabIndex = 1;
            this.CmD_CreateUser.Text = "User bearbeiten";
            this.CmD_CreateUser.UseVisualStyleBackColor = true;
            this.CmD_CreateUser.Click += new System.EventHandler(this.CmD_CreateUser_Click);
            // 
            // CmD_Geldaufladen
            // 
            this.CmD_Geldaufladen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_Geldaufladen.Location = new System.Drawing.Point(341, 12);
            this.CmD_Geldaufladen.Name = "CmD_Geldaufladen";
            this.CmD_Geldaufladen.Size = new System.Drawing.Size(130, 60);
            this.CmD_Geldaufladen.TabIndex = 1;
            this.CmD_Geldaufladen.Text = "Geld aufladen";
            this.CmD_Geldaufladen.UseVisualStyleBackColor = true;
            this.CmD_Geldaufladen.Click += new System.EventHandler(this.CmD_Geldaufladen_Click);
            // 
            // CmD_GüterBearbeiten
            // 
            this.CmD_GüterBearbeiten.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_GüterBearbeiten.Location = new System.Drawing.Point(175, 12);
            this.CmD_GüterBearbeiten.Name = "CmD_GüterBearbeiten";
            this.CmD_GüterBearbeiten.Size = new System.Drawing.Size(130, 60);
            this.CmD_GüterBearbeiten.TabIndex = 1;
            this.CmD_GüterBearbeiten.Text = "Getränke bearbeiten";
            this.CmD_GüterBearbeiten.UseVisualStyleBackColor = true;
            this.CmD_GüterBearbeiten.Click += new System.EventHandler(this.CmD_GüterBearbeiten_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output:";
            // 
            // TxT_Unverschlüsselt
            // 
            this.TxT_Unverschlüsselt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxT_Unverschlüsselt.Location = new System.Drawing.Point(232, 111);
            this.TxT_Unverschlüsselt.Name = "TxT_Unverschlüsselt";
            this.TxT_Unverschlüsselt.Size = new System.Drawing.Size(239, 31);
            this.TxT_Unverschlüsselt.TabIndex = 4;
            this.TxT_Unverschlüsselt.TextChanged += new System.EventHandler(this.TxT_Unverschlüsselt_TextChanged);
            // 
            // TxT_Verschlüsselt
            // 
            this.TxT_Verschlüsselt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxT_Verschlüsselt.Location = new System.Drawing.Point(232, 148);
            this.TxT_Verschlüsselt.Name = "TxT_Verschlüsselt";
            this.TxT_Verschlüsselt.Size = new System.Drawing.Size(239, 31);
            this.TxT_Verschlüsselt.TabIndex = 4;
            // 
            // CmD_Backup
            // 
            this.CmD_Backup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_Backup.Location = new System.Drawing.Point(560, 38);
            this.CmD_Backup.Name = "CmD_Backup";
            this.CmD_Backup.Size = new System.Drawing.Size(130, 60);
            this.CmD_Backup.TabIndex = 1;
            this.CmD_Backup.Text = "Backup";
            this.CmD_Backup.UseVisualStyleBackColor = true;
            this.CmD_Backup.Click += new System.EventHandler(this.CmD_Backup_Click);
            // 
            // PgB_Backup_Personen
            // 
            this.PgB_Backup_Personen.Location = new System.Drawing.Point(712, 12);
            this.PgB_Backup_Personen.Name = "PgB_Backup_Personen";
            this.PgB_Backup_Personen.Size = new System.Drawing.Size(238, 23);
            this.PgB_Backup_Personen.TabIndex = 5;
            // 
            // PgB_Backup_Güter
            // 
            this.PgB_Backup_Güter.Location = new System.Drawing.Point(712, 41);
            this.PgB_Backup_Güter.Name = "PgB_Backup_Güter";
            this.PgB_Backup_Güter.Size = new System.Drawing.Size(238, 23);
            this.PgB_Backup_Güter.TabIndex = 5;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(712, 70);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(238, 23);
            this.progressBar3.TabIndex = 5;
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(712, 99);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(238, 23);
            this.progressBar4.TabIndex = 5;
            // 
            // CmD_Restore
            // 
            this.CmD_Restore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_Restore.Location = new System.Drawing.Point(560, 191);
            this.CmD_Restore.Name = "CmD_Restore";
            this.CmD_Restore.Size = new System.Drawing.Size(130, 60);
            this.CmD_Restore.TabIndex = 1;
            this.CmD_Restore.Text = "Restore";
            this.CmD_Restore.UseVisualStyleBackColor = true;
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(712, 168);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(238, 23);
            this.progressBar5.TabIndex = 5;
            // 
            // progressBar6
            // 
            this.progressBar6.Location = new System.Drawing.Point(712, 197);
            this.progressBar6.Name = "progressBar6";
            this.progressBar6.Size = new System.Drawing.Size(238, 23);
            this.progressBar6.TabIndex = 5;
            // 
            // progressBar7
            // 
            this.progressBar7.Location = new System.Drawing.Point(712, 226);
            this.progressBar7.Name = "progressBar7";
            this.progressBar7.Size = new System.Drawing.Size(238, 23);
            this.progressBar7.TabIndex = 5;
            // 
            // progressBar8
            // 
            this.progressBar8.Location = new System.Drawing.Point(712, 255);
            this.progressBar8.Name = "progressBar8";
            this.progressBar8.Size = new System.Drawing.Size(238, 23);
            this.progressBar8.TabIndex = 5;
            // 
            // Frm_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 290);
            this.Controls.Add(this.progressBar8);
            this.Controls.Add(this.progressBar4);
            this.Controls.Add(this.progressBar7);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar6);
            this.Controls.Add(this.PgB_Backup_Güter);
            this.Controls.Add(this.progressBar5);
            this.Controls.Add(this.PgB_Backup_Personen);
            this.Controls.Add(this.TxT_Verschlüsselt);
            this.Controls.Add(this.TxT_Unverschlüsselt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmD_Restore);
            this.Controls.Add(this.CmD_Backup);
            this.Controls.Add(this.CmD_Geldaufladen);
            this.Controls.Add(this.CmD_GüterBearbeiten);
            this.Controls.Add(this.CmD_CreateUser);
            this.Controls.Add(this.CmD_CreateTables);
            this.Name = "Frm_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administration";
            this.Load += new System.EventHandler(this.Frm_Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmD_CreateTables;
        private System.Windows.Forms.Button CmD_CreateUser;
        private System.Windows.Forms.Button CmD_Geldaufladen;
        private System.Windows.Forms.Button CmD_GüterBearbeiten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxT_Unverschlüsselt;
        private System.Windows.Forms.TextBox TxT_Verschlüsselt;
        private System.Windows.Forms.Button CmD_Backup;
        private System.Windows.Forms.ProgressBar PgB_Backup_Personen;
        private System.Windows.Forms.ProgressBar PgB_Backup_Güter;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.Button CmD_Restore;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.ProgressBar progressBar6;
        private System.Windows.Forms.ProgressBar progressBar7;
        private System.Windows.Forms.ProgressBar progressBar8;
    }
}