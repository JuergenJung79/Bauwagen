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
            this.PgB_Backup_Aufladung = new System.Windows.Forms.ProgressBar();
            this.PgB_Backup_History = new System.Windows.Forms.ProgressBar();
            this.CmD_Restore = new System.Windows.Forms.Button();
            this.PgB_Restore_Personen = new System.Windows.Forms.ProgressBar();
            this.PgB_Restore_Güter = new System.Windows.Forms.ProgressBar();
            this.PgB_Restore_Aufladung = new System.Windows.Forms.ProgressBar();
            this.PgB_Restore_History = new System.Windows.Forms.ProgressBar();
            this.CmB_DatumBackup = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmD_Info = new System.Windows.Forms.Button();
            this.CmD_Dashboard = new System.Windows.Forms.Button();
            this.CmD_Relais_1 = new System.Windows.Forms.Button();
            this.CmD_Relais_2 = new System.Windows.Forms.Button();
            this.CmD_Relais_3 = new System.Windows.Forms.Button();
            this.CmD_Relais_4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CmD_UserHistory = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CmB_ComPorts = new System.Windows.Forms.ComboBox();
            this.CmD_LongDrinkMixer = new System.Windows.Forms.Button();
            this.CmD_CreateCocktail = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.CmB_ComPortsCocktail = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PgB_Backup_Cocktails = new System.Windows.Forms.ProgressBar();
            this.PgB_Restore_Cocktails = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // CmD_CreateTables
            // 
            this.CmD_CreateTables.Location = new System.Drawing.Point(12, 302);
            this.CmD_CreateTables.Name = "CmD_CreateTables";
            this.CmD_CreateTables.Size = new System.Drawing.Size(111, 43);
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
            this.CmD_Geldaufladen.Location = new System.Drawing.Point(284, 12);
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
            this.CmD_GüterBearbeiten.Location = new System.Drawing.Point(148, 12);
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
            this.label1.Location = new System.Drawing.Point(77, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output:";
            // 
            // TxT_Unverschlüsselt
            // 
            this.TxT_Unverschlüsselt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxT_Unverschlüsselt.Location = new System.Drawing.Point(148, 160);
            this.TxT_Unverschlüsselt.Name = "TxT_Unverschlüsselt";
            this.TxT_Unverschlüsselt.Size = new System.Drawing.Size(239, 31);
            this.TxT_Unverschlüsselt.TabIndex = 4;
            this.TxT_Unverschlüsselt.TextChanged += new System.EventHandler(this.TxT_Unverschlüsselt_TextChanged);
            // 
            // TxT_Verschlüsselt
            // 
            this.TxT_Verschlüsselt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxT_Verschlüsselt.Location = new System.Drawing.Point(148, 197);
            this.TxT_Verschlüsselt.Name = "TxT_Verschlüsselt";
            this.TxT_Verschlüsselt.Size = new System.Drawing.Size(239, 31);
            this.TxT_Verschlüsselt.TabIndex = 4;
            // 
            // CmD_Backup
            // 
            this.CmD_Backup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_Backup.Location = new System.Drawing.Point(560, 12);
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
            // PgB_Backup_Aufladung
            // 
            this.PgB_Backup_Aufladung.Location = new System.Drawing.Point(712, 70);
            this.PgB_Backup_Aufladung.Name = "PgB_Backup_Aufladung";
            this.PgB_Backup_Aufladung.Size = new System.Drawing.Size(238, 23);
            this.PgB_Backup_Aufladung.TabIndex = 5;
            // 
            // PgB_Backup_History
            // 
            this.PgB_Backup_History.Location = new System.Drawing.Point(712, 99);
            this.PgB_Backup_History.Name = "PgB_Backup_History";
            this.PgB_Backup_History.Size = new System.Drawing.Size(238, 23);
            this.PgB_Backup_History.TabIndex = 5;
            // 
            // CmD_Restore
            // 
            this.CmD_Restore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_Restore.Location = new System.Drawing.Point(560, 187);
            this.CmD_Restore.Name = "CmD_Restore";
            this.CmD_Restore.Size = new System.Drawing.Size(130, 60);
            this.CmD_Restore.TabIndex = 1;
            this.CmD_Restore.Text = "Restore";
            this.CmD_Restore.UseVisualStyleBackColor = true;
            this.CmD_Restore.Click += new System.EventHandler(this.CmD_Restore_Click);
            // 
            // PgB_Restore_Personen
            // 
            this.PgB_Restore_Personen.Location = new System.Drawing.Point(712, 187);
            this.PgB_Restore_Personen.Name = "PgB_Restore_Personen";
            this.PgB_Restore_Personen.Size = new System.Drawing.Size(238, 23);
            this.PgB_Restore_Personen.TabIndex = 5;
            // 
            // PgB_Restore_Güter
            // 
            this.PgB_Restore_Güter.Location = new System.Drawing.Point(712, 216);
            this.PgB_Restore_Güter.Name = "PgB_Restore_Güter";
            this.PgB_Restore_Güter.Size = new System.Drawing.Size(238, 23);
            this.PgB_Restore_Güter.TabIndex = 5;
            // 
            // PgB_Restore_Aufladung
            // 
            this.PgB_Restore_Aufladung.Location = new System.Drawing.Point(712, 245);
            this.PgB_Restore_Aufladung.Name = "PgB_Restore_Aufladung";
            this.PgB_Restore_Aufladung.Size = new System.Drawing.Size(238, 23);
            this.PgB_Restore_Aufladung.TabIndex = 5;
            // 
            // PgB_Restore_History
            // 
            this.PgB_Restore_History.Location = new System.Drawing.Point(712, 274);
            this.PgB_Restore_History.Name = "PgB_Restore_History";
            this.PgB_Restore_History.Size = new System.Drawing.Size(238, 23);
            this.PgB_Restore_History.TabIndex = 5;
            // 
            // CmB_DatumBackup
            // 
            this.CmB_DatumBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmB_DatumBackup.FormattingEnabled = true;
            this.CmB_DatumBackup.Location = new System.Drawing.Point(560, 253);
            this.CmB_DatumBackup.Name = "CmB_DatumBackup";
            this.CmB_DatumBackup.Size = new System.Drawing.Size(130, 33);
            this.CmB_DatumBackup.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(402, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Restoredatum:";
            // 
            // CmD_Info
            // 
            this.CmD_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_Info.Location = new System.Drawing.Point(393, 160);
            this.CmD_Info.Name = "CmD_Info";
            this.CmD_Info.Size = new System.Drawing.Size(66, 68);
            this.CmD_Info.TabIndex = 10;
            this.CmD_Info.Text = "Info";
            this.CmD_Info.UseVisualStyleBackColor = true;
            this.CmD_Info.Click += new System.EventHandler(this.CmD_Info_Click);
            // 
            // CmD_Dashboard
            // 
            this.CmD_Dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_Dashboard.Location = new System.Drawing.Point(12, 78);
            this.CmD_Dashboard.Name = "CmD_Dashboard";
            this.CmD_Dashboard.Size = new System.Drawing.Size(130, 68);
            this.CmD_Dashboard.TabIndex = 10;
            this.CmD_Dashboard.Text = "Dashboard";
            this.CmD_Dashboard.UseVisualStyleBackColor = true;
            this.CmD_Dashboard.Click += new System.EventHandler(this.CmD_Dashboard_Click);
            // 
            // CmD_Relais_1
            // 
            this.CmD_Relais_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_Relais_1.Location = new System.Drawing.Point(148, 417);
            this.CmD_Relais_1.Name = "CmD_Relais_1";
            this.CmD_Relais_1.Size = new System.Drawing.Size(130, 68);
            this.CmD_Relais_1.TabIndex = 10;
            this.CmD_Relais_1.Text = "Relais Platz 1";
            this.CmD_Relais_1.UseVisualStyleBackColor = true;
            this.CmD_Relais_1.Click += new System.EventHandler(this.CmD_Relais_1_Click);
            // 
            // CmD_Relais_2
            // 
            this.CmD_Relais_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_Relais_2.Location = new System.Drawing.Point(284, 417);
            this.CmD_Relais_2.Name = "CmD_Relais_2";
            this.CmD_Relais_2.Size = new System.Drawing.Size(130, 68);
            this.CmD_Relais_2.TabIndex = 10;
            this.CmD_Relais_2.Text = "Relais Platz 2";
            this.CmD_Relais_2.UseVisualStyleBackColor = true;
            this.CmD_Relais_2.Click += new System.EventHandler(this.CmD_Relais_2_Click);
            // 
            // CmD_Relais_3
            // 
            this.CmD_Relais_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_Relais_3.Location = new System.Drawing.Point(420, 417);
            this.CmD_Relais_3.Name = "CmD_Relais_3";
            this.CmD_Relais_3.Size = new System.Drawing.Size(130, 68);
            this.CmD_Relais_3.TabIndex = 10;
            this.CmD_Relais_3.Text = "Relais Platz 3";
            this.CmD_Relais_3.UseVisualStyleBackColor = true;
            this.CmD_Relais_3.Click += new System.EventHandler(this.CmD_Relais_3_Click);
            // 
            // CmD_Relais_4
            // 
            this.CmD_Relais_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_Relais_4.Location = new System.Drawing.Point(556, 417);
            this.CmD_Relais_4.Name = "CmD_Relais_4";
            this.CmD_Relais_4.Size = new System.Drawing.Size(130, 68);
            this.CmD_Relais_4.TabIndex = 10;
            this.CmD_Relais_4.Text = "Relais Platz 4";
            this.CmD_Relais_4.UseVisualStyleBackColor = true;
            this.CmD_Relais_4.Click += new System.EventHandler(this.CmD_Relais_4_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(938, 50);
            this.label4.TabIndex = 2;
            this.label4.Text = "Diese Daten werden nicht über die Datenbank gesteuert und müssen in jeder Anwendu" +
    "ng \r\nseparat gepflegt werden";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(2, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(957, 5);
            this.label5.TabIndex = 11;
            // 
            // CmD_UserHistory
            // 
            this.CmD_UserHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_UserHistory.Location = new System.Drawing.Point(148, 78);
            this.CmD_UserHistory.Name = "CmD_UserHistory";
            this.CmD_UserHistory.Size = new System.Drawing.Size(130, 68);
            this.CmD_UserHistory.TabIndex = 10;
            this.CmD_UserHistory.Text = "User History";
            this.CmD_UserHistory.UseVisualStyleBackColor = true;
            this.CmD_UserHistory.Click += new System.EventHandler(this.CmD_UserHistory_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(696, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "COM Port Relais (Ausgabeautomat)";
            // 
            // CmB_ComPorts
            // 
            this.CmB_ComPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmB_ComPorts.FormattingEnabled = true;
            this.CmB_ComPorts.Location = new System.Drawing.Point(766, 440);
            this.CmB_ComPorts.Name = "CmB_ComPorts";
            this.CmB_ComPorts.Size = new System.Drawing.Size(121, 32);
            this.CmB_ComPorts.TabIndex = 13;
            this.CmB_ComPorts.SelectedIndexChanged += new System.EventHandler(this.CmB_ComPorts_SelectedIndexChanged);
            // 
            // CmD_LongDrinkMixer
            // 
            this.CmD_LongDrinkMixer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_LongDrinkMixer.Location = new System.Drawing.Point(284, 78);
            this.CmD_LongDrinkMixer.Name = "CmD_LongDrinkMixer";
            this.CmD_LongDrinkMixer.Size = new System.Drawing.Size(130, 68);
            this.CmD_LongDrinkMixer.TabIndex = 1;
            this.CmD_LongDrinkMixer.Text = "Cocktails eintragen";
            this.CmD_LongDrinkMixer.UseVisualStyleBackColor = true;
            this.CmD_LongDrinkMixer.Click += new System.EventHandler(this.CmD_LongDrinkMixer_Click);
            // 
            // CmD_CreateCocktail
            // 
            this.CmD_CreateCocktail.Location = new System.Drawing.Point(129, 302);
            this.CmD_CreateCocktail.Name = "CmD_CreateCocktail";
            this.CmD_CreateCocktail.Size = new System.Drawing.Size(111, 43);
            this.CmD_CreateCocktail.TabIndex = 0;
            this.CmD_CreateCocktail.TabStop = false;
            this.CmD_CreateCocktail.Text = "Tabelle Cocktail erstellen";
            this.CmD_CreateCocktail.UseVisualStyleBackColor = true;
            this.CmD_CreateCocktail.Click += new System.EventHandler(this.CmD_CreateCocktail_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(2, 498);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(957, 5);
            this.label7.TabIndex = 11;
            // 
            // CmB_ComPortsCocktail
            // 
            this.CmB_ComPortsCocktail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmB_ComPortsCocktail.FormattingEnabled = true;
            this.CmB_ComPortsCocktail.Location = new System.Drawing.Point(766, 533);
            this.CmB_ComPortsCocktail.Name = "CmB_ComPortsCocktail";
            this.CmB_ComPortsCocktail.Size = new System.Drawing.Size(121, 32);
            this.CmB_ComPortsCocktail.TabIndex = 15;
            this.CmB_ComPortsCocktail.SelectedIndexChanged += new System.EventHandler(this.CmB_ComPortsCocktail_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(708, 510);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(233, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "COM Port Relais (Cocktailmixer)";
            // 
            // PgB_Backup_Cocktails
            // 
            this.PgB_Backup_Cocktails.Location = new System.Drawing.Point(712, 128);
            this.PgB_Backup_Cocktails.Name = "PgB_Backup_Cocktails";
            this.PgB_Backup_Cocktails.Size = new System.Drawing.Size(238, 23);
            this.PgB_Backup_Cocktails.TabIndex = 5;
            // 
            // PgB_Restore_Cocktails
            // 
            this.PgB_Restore_Cocktails.Location = new System.Drawing.Point(712, 303);
            this.PgB_Restore_Cocktails.Name = "PgB_Restore_Cocktails";
            this.PgB_Restore_Cocktails.Size = new System.Drawing.Size(238, 23);
            this.PgB_Restore_Cocktails.TabIndex = 5;
            // 
            // Frm_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 574);
            this.Controls.Add(this.CmB_ComPortsCocktail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CmB_ComPorts);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CmD_Relais_4);
            this.Controls.Add(this.CmD_Relais_3);
            this.Controls.Add(this.CmD_Relais_2);
            this.Controls.Add(this.CmD_Relais_1);
            this.Controls.Add(this.CmD_UserHistory);
            this.Controls.Add(this.CmD_Dashboard);
            this.Controls.Add(this.CmD_Info);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmB_DatumBackup);
            this.Controls.Add(this.PgB_Restore_Cocktails);
            this.Controls.Add(this.PgB_Restore_History);
            this.Controls.Add(this.PgB_Backup_Cocktails);
            this.Controls.Add(this.PgB_Backup_History);
            this.Controls.Add(this.PgB_Restore_Aufladung);
            this.Controls.Add(this.PgB_Backup_Aufladung);
            this.Controls.Add(this.PgB_Restore_Güter);
            this.Controls.Add(this.PgB_Backup_Güter);
            this.Controls.Add(this.PgB_Restore_Personen);
            this.Controls.Add(this.PgB_Backup_Personen);
            this.Controls.Add(this.TxT_Verschlüsselt);
            this.Controls.Add(this.TxT_Unverschlüsselt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmD_Restore);
            this.Controls.Add(this.CmD_Backup);
            this.Controls.Add(this.CmD_LongDrinkMixer);
            this.Controls.Add(this.CmD_Geldaufladen);
            this.Controls.Add(this.CmD_GüterBearbeiten);
            this.Controls.Add(this.CmD_CreateUser);
            this.Controls.Add(this.CmD_CreateCocktail);
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
        private System.Windows.Forms.ProgressBar PgB_Backup_Aufladung;
        private System.Windows.Forms.ProgressBar PgB_Backup_History;
        private System.Windows.Forms.Button CmD_Restore;
        private System.Windows.Forms.ProgressBar PgB_Restore_Personen;
        private System.Windows.Forms.ProgressBar PgB_Restore_Güter;
        private System.Windows.Forms.ProgressBar PgB_Restore_Aufladung;
        private System.Windows.Forms.ProgressBar PgB_Restore_History;
        private System.Windows.Forms.ComboBox CmB_DatumBackup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CmD_Info;
        private System.Windows.Forms.Button CmD_Dashboard;
        private System.Windows.Forms.Button CmD_Relais_1;
        private System.Windows.Forms.Button CmD_Relais_2;
        private System.Windows.Forms.Button CmD_Relais_3;
        private System.Windows.Forms.Button CmD_Relais_4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CmD_UserHistory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmB_ComPorts;
        private System.Windows.Forms.Button CmD_LongDrinkMixer;
        private System.Windows.Forms.Button CmD_CreateCocktail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmB_ComPortsCocktail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar PgB_Backup_Cocktails;
        private System.Windows.Forms.ProgressBar PgB_Restore_Cocktails;
    }
}