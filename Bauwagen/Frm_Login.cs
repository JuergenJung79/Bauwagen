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
                string sAdminPassword = Cls_Procedure.XorEncrypt("놩놊놞놜놊놌놎놅뇙뇛뇚뇒뇊", Bauwagen.Properties.Settings.Default.Key);

                if (sAdminPassword == TxT_Password.Text)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Password falsch!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.Abort;
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

                using (oConnection)
                {
                    oConnection.ConnectionString = Frm_Haupt.sDSN;
                    oConnection.Open();

                    oCommandSelect.Connection = oConnection;
                    oCommandUpdate.Connection = oConnection;

                    oCommandSelect.CommandText = Cls_Query.GetAnwenderDaten(LbL_Username.Text.Trim());
                    drReader = oCommandSelect.ExecuteReader();

                    while (drReader.Read())
                    {
                        sPassword = Cls_Procedure.XorEncrypt(drReader.GetValue(3).ToString().Trim(), Bauwagen.Properties.Settings.Default.Key);
                    }
                    drReader.Close();

                    if (sPassword == TxT_Password.Text)
                    {
                        oCommandUpdate.CommandText = Cls_Query.UpdateBadLogonAnwender(LbL_Username.Text.Trim(), false);
                        nResult = oCommandUpdate.ExecuteNonQuery();
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Password falsch!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        oCommandUpdate.CommandText = Cls_Query.UpdateBadLogonAnwender(LbL_Username.Text.Trim(), true);
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
