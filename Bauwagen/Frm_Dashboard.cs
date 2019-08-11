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
    public partial class Frm_Dashboard : Form
    {
        internal static bool bLoad = true;

        public Frm_Dashboard()
        {
            InitializeComponent();
        }

        private void Frm_Dashboard_Load(object sender, EventArgs e)
        {
            ClearData();
            LoadUserKomplett();
            bLoad = false;
        }

        private void CmB_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bLoad == false)
            {
                ClearData();

                LoadUser();
            }
        }

        private void ClearData()
        {
            ChT_Verbrauch.Series[0].Points.Clear();
            ChT_Verbrauch.Series[1].Points.Clear();

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
                    oCommand.CommandText = Cls_Query.GetAnwenderDaten("", true);
                    drReader = oCommand.ExecuteReader();

                    CmB_Name.Items.Clear();
                    while (drReader.Read())
                    {
                        CmB_Name.Items.Add(drReader.GetValue(1).ToString().Trim() + " " + drReader.GetValue(2).ToString().Trim());
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
                    oCommand.CommandText = Cls_Query.GetUserDashboardHistory(CmB_Name.Text.Trim());
                    drReader = oCommand.ExecuteReader();

                    while (drReader.Read())
                    {
                        if (drReader.GetValue(2).ToString().Trim() == "Verbrauch")
                        {
                            ChT_Verbrauch.Series[0].Points.AddXY(Convert.ToDateTime(drReader.GetValue(1)), Convert.ToDouble(drReader.GetValue(0)));
                        }
                        else if (drReader.GetValue(2).ToString().Trim() == "Aufladung")
                        {

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

    }
}
