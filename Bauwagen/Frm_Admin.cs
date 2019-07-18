using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

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

                    //Tabelle Personen löschen
                    try
                    {
                        oCommand.CommandText = Cls_Query.DropTableNamen();
                        nResult = oCommand.ExecuteNonQuery();
                    }
                    catch { }

                    //Tabelle Personen erstellen
                    try
                    {
                        oCommand.CommandText = Cls_Query.CreateTableNamen();
                        nResult = oCommand.ExecuteNonQuery();
                    }
                    catch { }

                    //Sequence Personen löschen
                    try
                    {
                        oCommand.CommandText = Cls_Query.DropSequenceUserID();
                        nResult = oCommand.ExecuteNonQuery();
                    }
                    catch { }

                    //Sequence Personen erstellen
                    try
                    {
                        oCommand.CommandText = Cls_Query.CreateSequenceUserID();
                        nResult = oCommand.ExecuteNonQuery();
                    }
                    catch { }

                    //Tabelle Verbrauch löschen
                    try
                    {
                        oCommand.CommandText = Cls_Query.DropTableGüterdaten();
                        nResult = oCommand.ExecuteNonQuery();
                    }
                    catch { }

                    //Tabelle Verbrauch erstellen
                    try
                    {
                        oCommand.CommandText = Cls_Query.CreateTableGüter();
                        nResult = oCommand.ExecuteNonQuery();
                    }
                    catch { }

                    //Tabelle History erstellen
                    try
                    {
                        oCommand.CommandText = Cls_Query.CreateTableHistory();
                        nResult = oCommand.ExecuteNonQuery();
                    }
                    catch { }

                    //Tabelle Aufladungen erstellen
                    try
                    {
                        oCommand.CommandText = Cls_Query.CreateTableAufladungen();
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

        }
    }
}
