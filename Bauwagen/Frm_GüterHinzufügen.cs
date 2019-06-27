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
    public partial class Frm_GüterHinzufügen : Form
    {
        public Frm_GüterHinzufügen()
        {
            InitializeComponent();
        }

        private void Frm_GüterHinzufügen_Load(object sender, EventArgs e)
        {
            GetGüter();
        }

        private void GetGüter()
        {
            OracleConnection oConnection = new OracleConnection();
            OracleCommand oCommand = new OracleCommand();
            OracleDataReader drReader;

            using (oConnection)
            {
                try
                {
                    oConnection.ConnectionString = Frm_Haupt.sDSN;
                    oConnection.Open();

                    oCommand.Connection = oConnection;
                    oCommand.CommandText = Cls_Query.GetGüterDaten("");
                    drReader = oCommand.ExecuteReader();

                    CmB_Güter.Items.Clear();
                    while (drReader.Read())
                    {
                        if (Convert.ToDouble(drReader.GetValue(5)) <= 0)
                        {
                            CmB_Güter.Items.Add(drReader.GetValue(0).ToString().Trim());
                        }
                    }
                    drReader.Close();

                    oConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "GetGüter");
                }
            }
        }

    }
}
