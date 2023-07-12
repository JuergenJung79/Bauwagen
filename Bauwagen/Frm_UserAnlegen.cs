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
    public partial class Frm_UserAnlegen : Form
    {
        internal static bool bLoad = true;

        public Frm_UserAnlegen()
        {
            InitializeComponent();
        }

        private void Frm_UserAnlegen_Load(object sender, EventArgs e)
        {
            ClearData();
            LoadUserKomplett();
            bLoad = false;
        }

        private void CmB_User_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bLoad == false)
            {
                ClearData();

                LoadUser();
            }
        }

        private void LoadUserKomplett()
        {
            OracleConnection oConnection = new OracleConnection();
            OracleCommand oCommand = new OracleCommand();
            OracleDataReader drReader;

            try
            {
                using (oConnection)
                {
                    oConnection.ConnectionString = Frm_Haupt.sDSN;
                    oConnection.Open();

                    oCommand.Connection = oConnection;
                    oCommand.CommandText = Cls_Query.GetAnwenderDaten("", true, "");
                    drReader = oCommand.ExecuteReader();

                    CmB_User.Items.Clear();
                    while (drReader.Read())
                    {
                        CmB_User.Items.Add(drReader.GetValue(1).ToString().Trim() + " " + drReader.GetValue(2).ToString().Trim());
                    }
                    drReader.Close();

                    oConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LoadUser");
            }
        }

        private void LoadUser()
        {
            OracleConnection oConnection = new OracleConnection();
            OracleCommand oCommand = new OracleCommand();
            OracleDataReader drReader;

            try
            {
                using (oConnection)
                {
                    oConnection.ConnectionString = Frm_Haupt.sDSN;
                    oConnection.Open();

                    oCommand.Connection = oConnection;
                    oCommand.CommandText = Cls_Query.GetAnwenderDaten(CmB_User.Text.Trim(), true, "");
                    drReader = oCommand.ExecuteReader();

                    if (drReader.HasRows)
                    {
                        while (drReader.Read())
                        {
                            string sPassword = Cls_Procedure.XorEncrypt(drReader.GetValue(3).ToString().Trim(), Bauwagen.Properties.Settings.Default.Key);

                            TxT_Vorname.Text = drReader.GetValue(1).ToString().Trim();

                            TxT_Password.Text = sPassword;

                            TxT_Budget.Text = drReader.GetValue(8).ToString().Trim();
                            TxT_Kredit.Text = drReader.GetValue(9).ToString().Trim();

                            TxT_TokenID.Text = drReader.GetValue(11).ToString().Trim();

                            NuD_Layer.Value = Convert.ToDecimal(drReader.GetValue(12));

                            if (drReader.GetValue(10).ToString().Trim() == "1") { ChK_ChangePW.Checked = true; } else { ChK_ChangePW.Checked = false; }
                            if (Convert.ToInt32(drReader.GetValue(6)) <= 5) { ChK_Aktiv.Checked = true; } else { ChK_Aktiv.Checked = false; }
                        }
                    }
                    drReader.Close();

                    oConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LoadUser");
            }
        }

        private void ClearData()
        {
            TxT_Vorname.Text = "";

            TxT_Password.Text = "";

            TxT_Budget.Text = "";
            TxT_Kredit.Text = "";

            TxT_TokenID.Text = "";

            NuD_Layer.Value = 1;

            ChK_Aktiv.Checked = true;
            ChK_ChangePW.Checked = true;
        }

        private void CmD_Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Den Vorgang wirklich beenden und alle Fenster schliesen?", "Beenden", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void CmD_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Benutzer wirklich löschen?", "Frage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (DeleteUser() == true)
                {
                    bLoad = true;
                    CmB_User.Text = "";

                    ClearData();
                    LoadUserKomplett();
                    bLoad = false;
                }
                else
                {
                    MessageBox.Show("Der User kann nicht gelöscht werden, bitte prüfen ob alle Transaktionsdaten bereinigt sind", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void CmD_Create_Click(object sender, EventArgs e)
        {
            OracleConnection oConnection = new OracleConnection();
            OracleCommand oCommandInsert = new OracleCommand();
            OracleCommand oCommandSelect = new OracleCommand();
            OracleDataReader drReader;

            int nResult = 0;

            bool bValid = false;
            bool bUpdate = false;

            string sPassword = Cls_Procedure.XorEncrypt(TxT_Password.Text.Trim(), Bauwagen.Properties.Settings.Default.Key);
            string sChangePW = "";
            string sAktiv = "";

            if (ChK_ChangePW.Checked) { sChangePW = "1"; } else { sChangePW = "0"; }
            if (ChK_Aktiv.Checked) { sAktiv = "1"; } else { sAktiv = "0"; }

            if (NuD_Layer.Value > 0 && NuD_Layer.Value <= 2) { bValid = true; } else { bValid = false; }

            if (bValid == true)
            {
                using (oConnection)
                {
                    try
                    {
                        oConnection.ConnectionString = Frm_Haupt.sDSN;
                        oConnection.Open();

                        oCommandInsert.Connection = oConnection;
                        oCommandSelect.Connection = oConnection;

                        oCommandSelect.CommandText = Cls_Query.GetAnwenderDaten(TxT_Vorname.Text.Trim(), true, "");
                        drReader = oCommandSelect.ExecuteReader();

                        while (drReader.Read())
                        {
                            bUpdate = true;
                        }
                        drReader.Close();

                        oCommandInsert.CommandText = Cls_Query.InsertUser(bUpdate, TxT_Vorname.Text.Trim(), sPassword,
                            TxT_Budget.Text.Trim(), TxT_Kredit.Text.Trim(), TxT_TokenID.Text.Trim(), sChangePW, sAktiv, Convert.ToInt32(NuD_Layer.Value));
                        nResult = oCommandInsert.ExecuteNonQuery();

                        MessageBox.Show("Erfolgreich gespeichert", "Info");
                        oConnection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "CmD_Create_Click");
                    }
                }
            }
            else
            {
                MessageBox.Show("Eingaben üngültig bitte das Layer prüfen", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool DeleteUser()
        {
            bool bReturn = false;


            OracleConnection oConnection = new OracleConnection();
            OracleTransaction transaction;
            OracleCommand oCommandDelete = new OracleCommand();

            using (oConnection)
            {
                oConnection.ConnectionString = Frm_Haupt.sDSN;
                oConnection.Open();

                transaction = oConnection.BeginTransaction(IsolationLevel.ReadCommitted);
                oCommandDelete.Connection = oConnection;

                int nResult = 0;

                try
                {
                    //Löschen der Daten in Aufladungen
                    oCommandDelete.CommandText = Cls_Query.DeleteUserTranskation_History(TxT_Vorname.Text.Trim());
                    nResult = oCommandDelete.ExecuteNonQuery();
                    
                    //Löschen der Daten in History
                    oCommandDelete.CommandText = Cls_Query.DeleteUserTranskation_Aufladungen(TxT_Vorname.Text.Trim());
                    nResult = oCommandDelete.ExecuteNonQuery();

                    //Löschen des Users
                    oCommandDelete.CommandText = Cls_Query.DeleteUser(TxT_Vorname.Text.Trim());
                    nResult = oCommandDelete.ExecuteNonQuery();

                    transaction.Commit();
                    bReturn = true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    bReturn = false;
                }

                return bReturn;
            }
        }

    }
}
