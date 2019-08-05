﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Data.OleDb;
using System.Globalization;

namespace Bauwagen
{
    public partial class Frm_Admin : Form
    {
        public Frm_Admin()
        {
            InitializeComponent();
        }

        private void CmD_CreateTables_Click(object sender, EventArgs e)
        {
            RecreateTables();
        }

        private void RecreateTables()
        {
            OracleConnection oConnection = new OracleConnection();
            OracleCommand oCommand = new OracleCommand();

            int nResult = 0;

            if (MessageBox.Show("ACHTUNG!!\n\nTabellen werden neu erstellt und vorhande Daten gelöscht! Wirklich durchführen?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (oConnection)
                {
                    oConnection.ConnectionString = Frm_Haupt.sDSN;
                    oConnection.Open();

                    oCommand.Connection = oConnection;

                    //Tabelle Aufladungen erstellen
                    try
                    {
                        oCommand.CommandText = Cls_Query.DropTableAufladungen();
                        nResult = oCommand.ExecuteNonQuery();
                        oCommand.CommandText = Cls_Query.CreateTableAufladungen();
                        nResult = oCommand.ExecuteNonQuery();
                    }
                    catch { }

                    //Tabelle History erstellen
                    try
                    {
                        oCommand.CommandText = Cls_Query.DropTableHistorydaten();
                        nResult = oCommand.ExecuteNonQuery();
                        oCommand.CommandText = Cls_Query.CreateTableHistory();
                        nResult = oCommand.ExecuteNonQuery();
                    }
                    catch { }

                    //Tabelle Verbrauch erstellen
                    try
                    {
                        oCommand.CommandText = Cls_Query.DropTableGüterdaten();
                        nResult = oCommand.ExecuteNonQuery();
                        oCommand.CommandText = Cls_Query.CreateTableGüter();
                        nResult = oCommand.ExecuteNonQuery();
                    }
                    catch { }

                    //Tabelle Personen erstellen
                    try
                    {
                        oCommand.CommandText = Cls_Query.DropTableNamen();
                        nResult = oCommand.ExecuteNonQuery();
                        oCommand.CommandText = Cls_Query.CreateTableNamen();
                        nResult = oCommand.ExecuteNonQuery();
                    }
                    catch { }

                    //Sequence Personen erstellen
                    try
                    {
                        oCommand.CommandText = Cls_Query.DropSequenceUserID();
                        nResult = oCommand.ExecuteNonQuery();
                        oCommand.CommandText = Cls_Query.CreateSequenceUserID("1");
                        nResult = oCommand.ExecuteNonQuery();
                    }
                    catch { }

                    //Constraints erstellen
                    try
                    {
                        oCommand.CommandText = Cls_Query.AddUniqueConstraintPersonen();
                        nResult = oCommand.ExecuteNonQuery();
                        oCommand.CommandText = Cls_Query.AddForeignKeyAufladungen();
                        nResult = oCommand.ExecuteNonQuery();
                        oCommand.CommandText = Cls_Query.AddForeignKeyHistory();
                        nResult = oCommand.ExecuteNonQuery();
                    }
                    catch { }

                    oConnection.Close();
                }
            }
        }

        private void CmD_CreateUser_Click(object sender, EventArgs e)
        {
            Frm_UserAnlegen frm_useranlegen = new Frm_UserAnlegen();
            frm_useranlegen.ShowDialog();
        }

        private void CmD_Geldaufladen_Click(object sender, EventArgs e)
        {
            Frm_Aufladen frm_aufladen = new Frm_Aufladen();
            frm_aufladen.ShowDialog();
        }

        private void CmD_GüterBearbeiten_Click(object sender, EventArgs e)
        {
            Frm_GüterHinzufügen frm_güterhinzufügen = new Frm_GüterHinzufügen();
            frm_güterhinzufügen.ShowDialog();
        }

        private void TxT_Unverschlüsselt_TextChanged(object sender, EventArgs e)
        {
            string sAdminPassword = Cls_Procedure.XorEncrypt(TxT_Unverschlüsselt.Text.Trim(), Bauwagen.Properties.Settings.Default.Key);

            TxT_Verschlüsselt.Text = sAdminPassword;
        }

        private void CmD_Backup_Click(object sender, EventArgs e)
        {
            BackupData(true);
            GetRestoreDaten();
        }

        public void BackupData(bool bVisu)
        {
            OracleConnection oConnection = new OracleConnection();
            OracleCommand oCommand = new OracleCommand();
            OracleDataReader drReader;

            int nCounter = 0;

            StringBuilder sb = new StringBuilder();
            StreamWriter swPersonen = new StreamWriter(Frm_Haupt.sBackupPfad + System.DateTime.Now.Year.ToString().Trim() + "_" + System.DateTime.Now.Month.ToString().Trim().PadLeft(2, '0') + "_" + System.DateTime.Now.Day.ToString().Trim().PadLeft(2, '0') + "_Personen.csv");
            StreamWriter swGüter = new StreamWriter(Frm_Haupt.sBackupPfad + System.DateTime.Now.Year.ToString().Trim() + "_" + System.DateTime.Now.Month.ToString().Trim().PadLeft(2, '0') + "_" + System.DateTime.Now.Day.ToString().Trim().PadLeft(2, '0') + "_Güter.csv");
            StreamWriter swAufladung = new StreamWriter(Frm_Haupt.sBackupPfad + System.DateTime.Now.Year.ToString().Trim() + "_" + System.DateTime.Now.Month.ToString().Trim().PadLeft(2, '0') + "_" + System.DateTime.Now.Day.ToString().Trim().PadLeft(2, '0') + "_Aufladung.csv");
            StreamWriter swHistory = new StreamWriter(Frm_Haupt.sBackupPfad + System.DateTime.Now.Year.ToString().Trim() + "_" + System.DateTime.Now.Month.ToString().Trim().PadLeft(2, '0') + "_" + System.DateTime.Now.Day.ToString().Trim().PadLeft(2, '0') + "_History.csv");

            if (bVisu == true) { PgB_Backup_Personen.Value = 0; }

            try
            {
                using (oConnection)
                {
                    oConnection.ConnectionString = Frm_Haupt.sDSN;
                    oConnection.Open();

                    oCommand.Connection = oConnection;

                    #region Backup Datenbank Personen
                    oCommand.CommandText = Cls_Query.GetAnwenderDaten("", true);
                    drReader = oCommand.ExecuteReader();
                    while (drReader.Read())
                    {
                        nCounter++;
                    }
                    drReader.Close();

                    if (bVisu == true)
                    {
                        PgB_Backup_Personen.Maximum = nCounter;
                    }

                    nCounter = 0;

                    drReader = oCommand.ExecuteReader();
                    while (drReader.Read())
                    {
                        for (int i = 0; i < drReader.FieldCount; i++)
                        {
                            string value = drReader[i].ToString();
                            if (value.Contains(","))
                                value = value.Replace(",", ".");

                            sb.Append(value.Replace(Environment.NewLine, " ") + ";");
                        }

                        sb.Length--; // Remove the last comma
                        sb.AppendLine();

                        if (bVisu == true)
                        {
                            PgB_Backup_Personen.Value = nCounter + 1;
                        }
                        nCounter++;
                    }
                    drReader.Close();
                    swPersonen.Write(sb.ToString());
                    swPersonen.Close();
                    sb.Clear();

                    nCounter = 0;
                    #endregion

                    #region Backup Datenbank Personen
                    oCommand.CommandText = Cls_Query.GetGüterDaten("");
                    drReader = oCommand.ExecuteReader();
                    while (drReader.Read())
                    {
                        nCounter++;
                    }
                    drReader.Close();

                    if (bVisu == true)
                    {
                        PgB_Backup_Güter.Maximum = nCounter;
                    }
                    nCounter = 0;

                    drReader = oCommand.ExecuteReader();
                    while (drReader.Read())
                    {
                        for (int i = 0; i < drReader.FieldCount; i++)
                        {
                            string value = drReader[i].ToString();
                            if (value.Contains(","))
                                value = value.Replace(",", ".");

                            sb.Append(value.Replace(Environment.NewLine, " ") + ";");
                        }

                        sb.Length--; // Remove the last comma
                        sb.AppendLine();

                        if (bVisu == true)
                        {
                            PgB_Backup_Güter.Value = nCounter + 1;
                        }
                        nCounter++;
                    }
                    drReader.Close();
                    swGüter.Write(sb.ToString());
                    swGüter.Close();
                    sb.Clear();

                    nCounter = 0;
                    #endregion

                    #region Backup Datenbank Aufladung
                    oCommand.CommandText = Cls_Query.GetAufladungDaten("", "", "");
                    drReader = oCommand.ExecuteReader();
                    while (drReader.Read())
                    {
                        nCounter++;
                    }
                    drReader.Close();

                    if (bVisu == true)
                    {
                        PgB_Backup_Aufladung.Maximum = nCounter;
                    }
                    nCounter = 0;

                    drReader = oCommand.ExecuteReader();
                    while (drReader.Read())
                    {
                        for (int i = 0; i < drReader.FieldCount; i++)
                        {
                            string value = drReader[i].ToString();
                            if (value.Contains(","))
                                value = value.Replace(",", ".");

                            sb.Append(value.Replace(Environment.NewLine, " ") + ";");
                        }

                        sb.Length--; // Remove the last comma
                        sb.AppendLine();

                        if (bVisu == true)
                        {
                            PgB_Backup_Aufladung.Value = nCounter + 1;
                        }
                        nCounter++;
                    }
                    drReader.Close();
                    swAufladung.Write(sb.ToString());
                    swAufladung.Close();
                    sb.Clear();

                    nCounter = 0;
                    #endregion

                    #region Backup Datenbank History
                    oCommand.CommandText = Cls_Query.GetHistoryDaten("", "", "");
                    drReader = oCommand.ExecuteReader();
                    while (drReader.Read())
                    {
                        nCounter++;
                    }
                    drReader.Close();

                    if (bVisu == true)
                    {
                        PgB_Backup_History.Maximum = nCounter;
                    }
                    nCounter = 0;

                    drReader = oCommand.ExecuteReader();
                    while (drReader.Read())
                    {
                        for (int i = 0; i < drReader.FieldCount; i++)
                        {
                            string value = drReader[i].ToString();
                            if (value.Contains(","))
                                value = value.Replace(",", ".");

                            sb.Append(value.Replace(Environment.NewLine, " ") + ";");
                        }

                        sb.Length--; // Remove the last comma
                        sb.AppendLine();

                        if (bVisu == true)
                        {
                            PgB_Backup_History.Value = nCounter + 1;
                        }
                        nCounter++;
                    }
                    drReader.Close();
                    swHistory.Write(sb.ToString());
                    swHistory.Close();
                    sb.Clear();

                    nCounter = 0;
                    #endregion

                    oConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CmD_Backup_Click");
            }
        }

        private void Frm_Admin_Load(object sender, EventArgs e)
        {
            GetRestoreDaten();
        }

        private void GetRestoreDaten()
        {
            System.IO.DirectoryInfo ParentDirectory = new System.IO.DirectoryInfo(Frm_Haupt.sRestorePfad);

            string sTempString = "";
            string sFile = "";
            string sText = "";

            CmB_DatumBackup.Items.Clear();

            foreach(System.IO.FileInfo f in ParentDirectory.GetFiles())
            {
                sFile = f.Name.Substring(0, 10);

                if (sTempString != sFile)
                {
                    sText = sFile.Substring(8, 2) + "." + sFile.Substring(5, 2) + "." + sFile.Substring(0, 4);

                    CmB_DatumBackup.Items.Add(sText);
                }

                sTempString = sFile;
            }
        }

        private void CmD_Restore_Click(object sender, EventArgs e)
        {
            OracleConnection oConnection = new OracleConnection();
            OracleCommand oCommandSelect = new OracleCommand();
            OracleCommand oCommandExecute = new OracleCommand();
            OracleDataReader drReader;

            int nCounter = 1;
            int nResult = 0;

            string sFileDatum = CmB_DatumBackup.Text.Substring(6, 4) + "_" + CmB_DatumBackup.Text.Substring(3, 2) + "_" + CmB_DatumBackup.Text.Substring(0, 2);

            try
            {
                DataTable dtPersonen = GetTableFromCSV(Frm_Haupt.sRestorePfad + sFileDatum + "_Personen.csv", false);
                DataTable dtGueter = GetTableFromCSV(Frm_Haupt.sRestorePfad + sFileDatum + "_Güter.csv", false);
                DataTable dtAufadung = GetTableFromCSV(Frm_Haupt.sRestorePfad + sFileDatum + "_Aufladung.csv", false);
                DataTable dtHistory = GetTableFromCSV(Frm_Haupt.sRestorePfad + sFileDatum + "_History.csv", false);

                RecreateTables();

                using (oConnection)
                {
                    oConnection.ConnectionString = Frm_Haupt.sDSN;
                    oConnection.Open();

                    oCommandSelect.Connection = oConnection;
                    oCommandExecute.Connection = oConnection;

                    PgB_Restore_Personen.Value = 0;
                    PgB_Restore_Güter.Value = 0;
                    PgB_Restore_Aufladung.Value = 0;
                    PgB_Restore_History.Value = 0;

                    try { PgB_Restore_Personen.Maximum = dtPersonen.Rows.Count; } catch { }
                    try
                    {
                        PgB_Restore_Güter.Maximum = dtGueter.Rows.Count;
                    }
                    catch { }
                    try
                    {
                        PgB_Restore_Aufladung.Maximum = dtAufadung.Rows.Count;
                    }
                    catch { }
                    try
                    {
                        PgB_Restore_History.Maximum = dtHistory.Rows.Count;
                    }
                    catch { }

                    #region Restore der Tabelle Personen
                    nCounter = 1;
                    try
                    {
                        if (dtPersonen.Rows.Count > 0)
                        {
                            if (File.Exists(Frm_Haupt.sRestorePfad + sFileDatum + "_Personen.csv"))
                            {
                                string[] lines = File.ReadAllLines(Frm_Haupt.sRestorePfad + sFileDatum + "_Personen.csv");
                                string[][] parts = new string[lines.Length][];

                                for (int i = 0; i < lines.Length; i++)
                                {
                                    parts[i] = lines[i].Split(';');
                                    oCommandExecute.CommandText = Cls_Query.InsertUserRestore(parts[i][1], parts[i][3], parts[i][4], parts[i][5],
                                        parts[i][6], parts[i][7], parts[i][8], parts[i][9], parts[i][10], parts[i][11]);
                                    nResult = oCommandExecute.ExecuteNonQuery();

                                    PgB_Restore_Personen.Value = nCounter;
                                    nCounter++;
                                }
                            }
                        }
                    }
                    catch { }
                    #endregion

                    #region Restore der Tabelle Güter
                    nCounter = 1;
                    try
                    {
                        if (dtGueter.Rows.Count > 0)
                        {
                            if (File.Exists(Frm_Haupt.sRestorePfad + sFileDatum + "_Güter.csv"))
                            {
                                string[] lines = File.ReadAllLines(Frm_Haupt.sRestorePfad + sFileDatum + "_Güter.csv");
                                string[][] parts = new string[lines.Length][];

                                for (int i = 0; i < lines.Length; i++)
                                {
                                    parts[i] = lines[i].Split(';');
                                    oCommandExecute.CommandText = Cls_Query.InsertGüterRestore(parts[i][0], parts[i][1], parts[i][2], parts[i][3],
                                        parts[i][4], parts[i][5], parts[i][6]);
                                    nResult = oCommandExecute.ExecuteNonQuery();

                                    PgB_Restore_Güter.Value = nCounter;
                                    nCounter++;
                                }
                            }
                        }
                    }
                    catch { }
                    #endregion

                    #region Restore der Tabelle Aufladungen
                    nCounter = 1;
                    try
                    {
                        if (dtAufadung.Rows.Count > 0)
                        {
                            if (File.Exists(Frm_Haupt.sRestorePfad + sFileDatum + "_Aufladung.csv"))
                            {
                                string[] lines = File.ReadAllLines(Frm_Haupt.sRestorePfad + sFileDatum + "_Aufladung.csv");
                                string[][] parts = new string[lines.Length][];

                                for (int i = 0; i < lines.Length; i++)
                                {
                                    parts[i] = lines[i].Split(';');
                                    oCommandExecute.CommandText = Cls_Query.InsertAufladungenRestore(parts[i][0], parts[i][1], parts[i][2]);
                                    nResult = oCommandExecute.ExecuteNonQuery();

                                    PgB_Restore_Aufladung.Value = nCounter;
                                    nCounter++;
                                }
                            }
                        }
                    }
                    catch { }
                    #endregion

                    #region Restore der Tabelle History
                    nCounter = 1;
                    try
                    {
                        if (dtHistory.Rows.Count > 0)
                        {
                            if (File.Exists(Frm_Haupt.sRestorePfad + sFileDatum + "_History.csv"))
                            {
                                string[] lines = File.ReadAllLines(Frm_Haupt.sRestorePfad + sFileDatum + "_History.csv");
                                string[][] parts = new string[lines.Length][];

                                for (int i = 0; i < lines.Length; i++)
                                {
                                    parts[i] = lines[i].Split(';');
                                    oCommandExecute.CommandText = Cls_Query.InsertHistoryRestore(parts[i][0], parts[i][1], parts[i][2], parts[i][3],
                                        parts[i][4], parts[i][5]);
                                    nResult = oCommandExecute.ExecuteNonQuery();

                                    PgB_Restore_History.Value = nCounter;
                                    nCounter++;
                                }
                            }
                        }
                    }
                    catch { }
                    #endregion

                    oConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CmD_Restore_Click");
            }
        }

        static DataTable GetTableFromCSV(string path, bool isFirstRowHeader)
        {
            string header = isFirstRowHeader ? "Yes" : "No";

            string pathOnly = Path.GetDirectoryName(path);
            string fileName = Path.GetFileName(path);

            string sql = @"SELECT * FROM [" + fileName + "]";

            using (OleDbConnection connection = new OleDbConnection(
                      @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathOnly +
                      ";Extended Properties=\"Text;HDR=" + header + "\""))
            using (OleDbCommand command = new OleDbCommand(sql, connection))
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
            {
                try
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Locale = CultureInfo.CurrentCulture;
                    adapter.Fill(dataTable);
                    return dataTable;
                }
                catch
                {
                    return null;
                }
            }
        }

        private void CmD_Info_Click(object sender, EventArgs e)
        {
            Frm_AboutBox frm_aboutbox = new Frm_AboutBox();
            frm_aboutbox.ShowDialog();
        }
    }
}
