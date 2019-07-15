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
        internal static bool bLoad = true;
        internal static bool bDataExists = false;

        public Frm_GüterHinzufügen()
        {
            InitializeComponent();
        }

        private void Frm_GüterHinzufügen_Load(object sender, EventArgs e)
        {
            GetGüter();
            bLoad = false;
        }

        private void CmD_Save_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void CmB_Güter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bLoad == false)
            {
                TxT_Preis.Text = "";
                ChK_Aktiv.Checked = true;
                bDataExists = false;

                LoadData();
            }
        }

        private void CmB_Güter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxT_Preis.Text = "";
                ChK_Aktiv.Checked = true;
                bDataExists = false;

                LoadData();
            }
        }

        private void CmB_Güter_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void SaveData()
        {
            OracleConnection oConnection = new OracleConnection();
            OracleCommand oCommand = new OracleCommand();

            int nResult = 0;

            bool bInsert = false;
            bool bUpdate = false;

            string sLocked = "0";

            if (bDataExists == true)
            {
                bUpdate = true;
                bInsert = false;
            }
            else
            {
                bUpdate = false;
                bInsert = true;
            }

            if (ChK_Aktiv.Checked == true) { sLocked = "0"; } else { sLocked = "1"; }

            try
            {
                using (oConnection)
                {
                    oConnection.ConnectionString = Frm_Haupt.sDSN;
                    oConnection.Open();

                    oCommand.Connection = oConnection;
                    oCommand.CommandText = Cls_Query.SaveGüterDaten(bInsert, bUpdate, CmB_Güter.Text.Trim(), TxT_Preis.Text.Trim().Replace(",", "."), sLocked);
                    nResult = oCommand.ExecuteNonQuery();

                    oConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LoadData");
            }
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

                    oCommand.Connection = oConnection;
                    oCommand.CommandText = Cls_Query.GetGüterDaten(CmB_Güter.Text.Trim());
                    drReader = oCommand.ExecuteReader();

                    while (drReader.Read())
                    {
                        TxT_Preis.Text = drReader.GetValue(1).ToString().Trim();

                        if (drReader.GetValue(5).ToString().Trim() == "1") { ChK_Aktiv.Checked = false; } else { ChK_Aktiv.Checked = true; }
                        bDataExists = true;
                    }
                    drReader.Close();

                    oConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LoadData");
            }
        }

    }
}
