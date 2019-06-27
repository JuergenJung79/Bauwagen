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
    public partial class Frm_ChangePassword : Form
    {
        public Frm_ChangePassword()
        {
            InitializeComponent();
        }

        private void CmD_OK_Click(object sender, EventArgs e)
        {
            OracleConnection oConnection = new OracleConnection();
            OracleCommand oCommandUpdate = new OracleCommand();
            OracleDataReader drReader;

            int nResult = 0;

            string sPassword = Cls_Procedure.XorEncrypt(TxT_Password_1.Text.Trim(), Bauwagen.Properties.Settings.Default.Key);

            if (TxT_Password_1.Text.Trim() == TxT_Password_2.Text.Trim())
            {
                using (oConnection)
                {
                    try
                    {
                        oConnection.ConnectionString = Frm_Haupt.sDSN;
                        oConnection.Open();

                        oCommandUpdate.Connection = oConnection;
                        oCommandUpdate.CommandText = Cls_Query.UpdateBadLogonAnwender(LbL_Username.Text.Trim(), false, sPassword);
                        nResult = oCommandUpdate.ExecuteNonQuery();

                        oConnection.Close();

                        this.DialogResult = DialogResult.OK;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "CmD_OK_Click");
                    }
                }
            }
            else
            {
                MessageBox.Show("Passwörter stimmen nicht überein!", "Fehler");
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
