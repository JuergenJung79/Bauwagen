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
        public Frm_UserAnlegen()
        {
            InitializeComponent();
        }

        private void Frm_UserAnlegen_Load(object sender, EventArgs e)
        {

        }

        private void CmD_Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Den Vorgang wirklich beenden und alle Fenster schliesen?", "Beenden", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void CmD_Create_Click(object sender, EventArgs e)
        {
            OracleConnection oConnection = new OracleConnection();
            OracleCommand oCommandInsert = new OracleCommand();

            int nResult = 0;

            string sPassword = Cls_Procedure.XorEncrypt(TxT_Password.Text.Trim(), Bauwagen.Properties.Settings.Default.Key);


            using (oConnection)
            {
                try
                {
                    oConnection.ConnectionString = Frm_Haupt.sDSN;
                    oConnection.Open();

                    oCommandInsert.Connection = oConnection;
                    oCommandInsert.CommandText = Cls_Query.InsertUser(TxT_Name.Text.Trim(), TxT_Vorname.Text.Trim(), sPassword,
                        TxT_Budget.Text.Trim(), TxT_Kredit.Text.Trim());
                    nResult = oCommandInsert.ExecuteNonQuery();

                    MessageBox.Show("User erfolgreich angelegt", "Info");
                    oConnection.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "CmD_Create_Click");
                }
            }

            this.Close();
        }

    }
}
