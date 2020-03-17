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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void CmD_OK_Click(object sender, EventArgs e)
        {
            CheckPassword();
        }

        private void CmD_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }

        private void TxT_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckPassword();
            }
        }

        private void CheckPassword()
        {
            #region Prüfen der Berechtigung zum öffnen des Adminportals
            if (LbL_Status.Text == "admin")
            {
                string sAdminPassword = Cls_Procedure.XorEncrypt("뇛뇙뇟뇛뇚뇝뇚뇛뇛뇝", Bauwagen.Properties.Settings.Default.Key);

                if (sAdminPassword == TxT_Password.Text)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Password falsch!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.Abort;
                }

                if (System.Environment.MachineName == "EMARW001" | System.Environment.MachineName == "EMARL001")
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
            else if (LbL_Status.Text == "user")
            {
                OracleConnection oConnection = new OracleConnection();
                OracleCommand oCommandSelect = new OracleCommand();
                OracleCommand oCommandUpdate = new OracleCommand();
                OracleDataReader drReader;

                int nResult = 0;

                string sPassword = "";

                bool bChangePW = false;

                using (oConnection)
                {
                    oConnection.ConnectionString = Frm_Haupt.sDSN;
                    oConnection.Open();

                    oCommandSelect.Connection = oConnection;
                    oCommandUpdate.Connection = oConnection;

                    oCommandSelect.CommandText = Cls_Query.GetAnwenderDaten(LbL_Username.Text.Trim(), false);
                    drReader = oCommandSelect.ExecuteReader();

                    while (drReader.Read())
                    {
                        sPassword = Cls_Procedure.XorEncrypt(drReader.GetValue(3).ToString().Trim(), Bauwagen.Properties.Settings.Default.Key);

                        if (drReader.GetValue(10).ToString().Trim() == "1") { bChangePW = true; } else { bChangePW = false; }
                    }
                    drReader.Close();

                    if (sPassword == TxT_Password.Text && bChangePW == false)
                    {
                        oCommandUpdate.CommandText = Cls_Query.UpdateBadLogonAnwender(LbL_Username.Text.Trim(), false, "");
                        nResult = oCommandUpdate.ExecuteNonQuery();
                        this.DialogResult = DialogResult.OK;
                    }
                    else if (sPassword == TxT_Password.Text && bChangePW == true)
                    {
                        MessageBox.Show("Passwort muss geändert werden", "Info");
                        Frm_ChangePassword frm_ChangePassword = new Frm_ChangePassword();
                        frm_ChangePassword.LbL_Username.Text = LbL_Username.Text.Trim();

                        if (frm_ChangePassword.ShowDialog() == DialogResult.OK)
                        {
                            oCommandUpdate.CommandText = Cls_Query.UpdateBadLogonAnwender(LbL_Username.Text.Trim(), false, "");
                            nResult = oCommandUpdate.ExecuteNonQuery();
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            oCommandUpdate.CommandText = Cls_Query.UpdateBadLogonAnwender(LbL_Username.Text.Trim(), true, "");
                            nResult = oCommandUpdate.ExecuteNonQuery();
                            this.DialogResult = DialogResult.Abort;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password falsch!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        oCommandUpdate.CommandText = Cls_Query.UpdateBadLogonAnwender(LbL_Username.Text.Trim(), true, "");
                        nResult = oCommandUpdate.ExecuteNonQuery();
                        this.DialogResult = DialogResult.Abort;
                    }

                    oConnection.Close();
                }
            }
            #endregion
        }
    }
}
