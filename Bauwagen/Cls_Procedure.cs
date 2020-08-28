using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bauwagen
{
    class Cls_Procedure
    {
        public static string XorEncrypt(string text, int key)
        {
            string newText = "";

            for (int i = 0; i < text.Length; i++)
            {
                int charValue = Convert.ToInt32(text[i]); //get the ASCII value of the character
                charValue ^= key; //xor the value

                newText += char.ConvertFromUtf32(charValue); //convert back to string
            }

            return newText;
        }

        public static void BackupData()
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
            StreamWriter swCocktails = new StreamWriter(Frm_Haupt.sBackupPfad + System.DateTime.Now.Year.ToString().Trim() + "_" + System.DateTime.Now.Month.ToString().Trim().PadLeft(2, '0') + "_" + System.DateTime.Now.Day.ToString().Trim().PadLeft(2, '0') + "_Cocktails.csv");

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

                        nCounter++;
                    }
                    drReader.Close();
                    swPersonen.Write(sb.ToString());
                    swPersonen.Close();
                    sb.Clear();

                    nCounter = 0;
                    #endregion

                    #region Backup Datenbank Güter
                    oCommand.CommandText = Cls_Query.GetGüterDatenBackup("");
                    drReader = oCommand.ExecuteReader();
                    while (drReader.Read())
                    {
                        nCounter++;
                    }
                    drReader.Close();

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

                        nCounter++;
                    }
                    drReader.Close();
                    swHistory.Write(sb.ToString());
                    swHistory.Close();
                    sb.Clear();

                    nCounter = 0;
                    #endregion

                    #region Backup Datenbank Cocktails
                    oCommand.CommandText = Cls_Query.GetCocktailRezepte("", "");
                    drReader = oCommand.ExecuteReader();
                    while (drReader.Read())
                    {
                        nCounter++;
                    }
                    drReader.Close();

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

                        nCounter++;
                    }
                    drReader.Close();
                    swCocktails.Write(sb.ToString());
                    swCocktails.Close();
                    sb.Clear();

                    nCounter = 0;
                    #endregion

                    oConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cls_Procedure.CmD_Backup_Click");
            }
        }

    }
}
