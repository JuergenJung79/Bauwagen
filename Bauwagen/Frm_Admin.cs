using System;
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
            OracleConnection oConnection = new OracleConnection();
            OracleCommand oCommand = new OracleCommand();
            OracleDataReader drReader;

            int nCounter = 0;

            StringBuilder sb = new StringBuilder();
            StreamWriter swPersonen = new StreamWriter(Frm_Haupt.sBackupPfad + System.DateTime.Now.Year.ToString().Trim() + "_" + System.DateTime.Now.Month.ToString().Trim().PadLeft(2, '0') + "_" + System.DateTime.Now.Day.ToString().Trim().PadLeft(2, '0') + "_Personen.csv");
            StreamWriter swGüter = new StreamWriter(Frm_Haupt.sBackupPfad + System.DateTime.Now.Year.ToString().Trim() + "_" + System.DateTime.Now.Month.ToString().Trim().PadLeft(2,'0') + "_" + System.DateTime.Now.Day.ToString().Trim().PadLeft(2, '0') + "_Güter.csv");
            StreamWriter swAufladung = new StreamWriter(Frm_Haupt.sBackupPfad + System.DateTime.Now.Year.ToString().Trim() + "_" + System.DateTime.Now.Month.ToString().Trim().PadLeft(2, '0') + "_" + System.DateTime.Now.Day.ToString().Trim().PadLeft(2, '0') + "_Aufladung.csv");
            StreamWriter swHistory = new StreamWriter(Frm_Haupt.sBackupPfad + System.DateTime.Now.Year.ToString().Trim() + "_" + System.DateTime.Now.Month.ToString().Trim().PadLeft(2, '0') + "_" + System.DateTime.Now.Day.ToString().Trim().PadLeft(2, '0') + "_History.csv");

            PgB_Backup_Personen.Value = 0;

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

                    PgB_Backup_Personen.Maximum = nCounter;
                    nCounter = 0;

                    drReader = oCommand.ExecuteReader();
                    while (drReader.Read())
                    {
                        for (int i = 0; i < drReader.FieldCount; i++)
                        {
                            string value = drReader[i].ToString();
                            if (value.Contains(","))
                                value = value.Replace(",",".");

                            sb.Append(value.Replace(Environment.NewLine, " ") + ";");
                        }

                        sb.Length--; // Remove the last comma
                        sb.AppendLine();

                        PgB_Backup_Personen.Value = nCounter + 1;
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

                    PgB_Backup_Güter.Maximum = nCounter;
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

                        PgB_Backup_Güter.Value = nCounter + 1;
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

                    PgB_Backup_Aufladung.Maximum = nCounter;
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

                        PgB_Backup_Aufladung.Value = nCounter + 1;
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

                    PgB_Backup_History.Maximum = nCounter;
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

                        PgB_Backup_History.Value = nCounter + 1;
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

            GetRestoreDaten();
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

            int nCounter = 0;
            int nResult = 0;

            string sFileDatum = CmB_DatumBackup.Text.Substring(6, 4) + "_" + CmB_DatumBackup.Text.Substring(3, 2) + CmB_DatumBackup.Text.Substring(0, 2);

            try
            {
                DataTable dtPersonen = GetTableFromCSV(Frm_Haupt.sRestorePfad + sFileDatum + "_Personen.csv");
                DataTable dtGueter = GetTableFromCSV(Frm_Haupt.sRestorePfad + sFileDatum + "_Güter.csv");
                DataTable dtAufadung = GetTableFromCSV(Frm_Haupt.sRestorePfad + sFileDatum + "_Aufladung.csv");
                DataTable dtHistory = GetTableFromCSV(Frm_Haupt.sRestorePfad + sFileDatum + "_History.csv");

                RecreateTables();

                using (oConnection)
                {
                    oConnection.ConnectionString = Frm_Haupt.sDSN;
                    oConnection.Open();

                    oCommandSelect.Connection = oConnection;
                    oCommandExecute.Connection = oConnection;

                    /* Sequence neu erstellen mit neuer max ID
                    oCommandExecute.CommandText = Cls_Query.DropSequenceUserID();
                    nResult = oCommandExecute.ExecuteNonQuery();
                    oCommandExecute.CommandText = Cls_Query.CreateSequenceUserID("1");
                    nResult = oCommandExecute.ExecuteNonQuery();
                    */

                    oConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CmD_Restore_Click");
            }
        }

        private DataTable GetTableFromCSV(string sPfad)
        {
            if (!File.Exists(sPfad))
            {
                throw new FileNotFoundException(@"Die CSV-Datei existiert nicht!", sPfad);
            }

            string sCsv = File.ReadAllText(sPfad, Encoding.Default);
            string sTmp = "Tmp.csv";

            sCsv = sCsv.Replace(";", ",");
            File.WriteAllText(sTmp, sCsv, Encoding.Default);

            DataTable dataTable = new DataTable();
            OleDbConnectionStringBuilder b = new OleDbConnectionStringBuilder();
            b.Provider = "Microsoft.Jet.OLEDB.4.0";
            b.DataSource = Directory.GetParent(sPfad).FullName;
            b["Extended Properties"] = "Text;";

            OleDbConnection con = new OleDbConnection(b.ToString());
            OleDbDataAdapter da = new OleDbDataAdapter(string.Format("select * from [{0}]", sTmp), con);
            da.Fill(dataTable);

            if (File.Exists(sTmp))
            {
                File.Delete(sTmp);
            }

            return dataTable;
        }

        private void CmD_Info_Click(object sender, EventArgs e)
        {
            Frm_AboutBox frm_aboutbox = new Frm_AboutBox();
            frm_aboutbox.ShowDialog();
        }
    }
}
