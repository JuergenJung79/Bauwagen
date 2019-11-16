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
    public partial class Frm_UserListe : Form
    {
        public Frm_UserListe()
        {
            InitializeComponent();
        }

        private void Frm_UserListe_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void TmR_Refresh_Tick(object sender, EventArgs e)
        {
            TmR_Refresh.Enabled = false;

            LoadData();
        }

        private void LoadData()
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

                    DgV_UserHistory.AllowUserToAddRows = true;

                    oCommand.Connection = oConnection;
                    oCommand.CommandText = Cls_Query.GetUserHistory();
                    drReader = oCommand.ExecuteReader();

                    while (drReader.Read())
                    {
                        DataGridViewRow row = (DataGridViewRow)DgV_UserHistory.Rows[0].Clone();
                        row.Height = 45;
                        row.Cells[0].Value = drReader.GetValue(0);
                        row.Cells[1].Value = drReader.GetValue(1);
                        row.Cells[2].Value = drReader.GetValue(2);
                        row.Cells[3].Value = drReader.GetValue(3);
                        row.Cells[4].Value = drReader.GetValue(4);
                        row.Cells[5].Value = drReader.GetValue(5);

                        if (drReader.GetValue(1).ToString() == "Aufladung")
                        {
                            for (int i = 0; i <= 5; i++)
                            {
                                row.Cells[i].Style.BackColor = Color.LightGreen;
                            }
                        }
                        else
                        {
                            for (int i = 0; i <= 5; i++)
                            {
                                row.Cells[i].Style.BackColor = Color.LightYellow;
                            }
                        }

                        DgV_UserHistory.Rows.Add(row);
                    }
                    drReader.Close();

                    DgV_UserHistory.AllowUserToAddRows = false;
                    oConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
