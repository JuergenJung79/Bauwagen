using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO.Ports;
using System.Threading;
using System.Timers;
using Oracle.ManagedDataAccess.Client;

namespace Bauwagen
{
    public partial class Frm_CocktailAdmin : Form
    {
        SerialPort _serialPort;
        DateTime dStart;
        DateTime dEnd;

        public Frm_CocktailAdmin()
        {
            InitializeComponent();
        }

        private void Frm_CocktailAdmin_Load(object sender, EventArgs e)
        {
            _serialPort = new SerialPort();
            _serialPort.PortName = Properties.Settings.Default.ComRelaisCocktail;

            // Set the read/write timeouts
            _serialPort.BaudRate = 9600;
            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;

            _serialPort.Open();

            ClearData();
            LoadData();

            CmD_Neu.Enabled = false;
            CmD_Sichern.Enabled = false;
        }

        private void Frm_CocktailAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            _serialPort.Close();
        }

        private void CmD_Neu_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void CmD_Sichern_Click(object sender, EventArgs e)
        {
            SaveData();

            DgV_Cocktails.Enabled = true;
            LoadData();
            DgV_Cocktails.Enabled = false;
        }

        private void TxT_Name_TextChanged(object sender, EventArgs e)
        {
            if (TxT_Name.Text.Trim() != "")
            {
                LoadDataEinzeln();

                CmD_Neu.Enabled = true;
                CmD_Sichern.Enabled = true;
            }
        }

        private void DgV_Cocktails_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TxT_Name.Text = DgV_Cocktails.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
            DgV_Cocktails.Enabled = false;
        }

        #region ClearData
        private void ClearData()
        {
            TxT_Name.Text = "";
            DgV_Cocktails.Enabled = true;

            TxT_Preis_Klein_Schwach.Text = "";
            TxT_Preis_Klein_Mittel.Text = "";
            TxT_Preis_Klein_Stark.Text = "";
            TxT_Preis_Gross_Schwach.Text = "";
            TxT_Preis_Gross_Mittel.Text = "";
            TxT_Preis_Gross_Stark.Text = "";

            ChK_Aktiv.Checked = false;

            NuD_Klein_Schwach_01.Value = 0;
            NuD_Klein_Mittel_01.Value = 0;
            NuD_Klein_Stark_01.Value = 0;
            NuD_Groß_Schwach_01.Value = 0;
            NuD_Groß_Mittel_01.Value = 0;
            NuD_Groß_Stark_01.Value = 0;
            NuD_Klein_Schwach_02.Value = 0;
            NuD_Klein_Mittel_02.Value = 0;
            NuD_Klein_Stark_02.Value = 0;
            NuD_Groß_Schwach_02.Value = 0;
            NuD_Groß_Mittel_02.Value = 0;
            NuD_Groß_Stark_02.Value = 0;
            NuD_Klein_Schwach_03.Value = 0;
            NuD_Klein_Mittel_03.Value = 0;
            NuD_Klein_Stark_03.Value = 0;
            NuD_Groß_Schwach_03.Value = 0;
            NuD_Groß_Mittel_03.Value = 0;
            NuD_Groß_Stark_03.Value = 0;
            NuD_Klein_Schwach_04.Value = 0;
            NuD_Klein_Mittel_04.Value = 0;
            NuD_Klein_Stark_04.Value = 0;
            NuD_Groß_Schwach_04.Value = 0;
            NuD_Groß_Mittel_04.Value = 0;
            NuD_Groß_Stark_04.Value = 0;
            NuD_Klein_Schwach_05.Value = 0;
            NuD_Klein_Mittel_05.Value = 0;
            NuD_Klein_Stark_05.Value = 0;
            NuD_Groß_Schwach_05.Value = 0;
            NuD_Groß_Mittel_05.Value = 0;
            NuD_Groß_Stark_05.Value = 0;
            NuD_Klein_Schwach_06.Value = 0;
            NuD_Klein_Mittel_06.Value = 0;
            NuD_Klein_Stark_06.Value = 0;
            NuD_Groß_Schwach_06.Value = 0;
            NuD_Groß_Mittel_06.Value = 0;
            NuD_Groß_Stark_06.Value = 0;
            NuD_Klein_Schwach_07.Value = 0;
            NuD_Klein_Mittel_07.Value = 0;
            NuD_Klein_Stark_07.Value = 0;
            NuD_Groß_Schwach_07.Value = 0;
            NuD_Groß_Mittel_07.Value = 0;
            NuD_Groß_Stark_07.Value = 0;
            NuD_Klein_Schwach_08.Value = 0;
            NuD_Klein_Mittel_08.Value = 0;
            NuD_Klein_Stark_08.Value = 0;
            NuD_Groß_Schwach_08.Value = 0;
            NuD_Groß_Mittel_08.Value = 0;
            NuD_Groß_Stark_08.Value = 0;
            NuD_Klein_Schwach_09.Value = 0;
            NuD_Klein_Mittel_09.Value = 0;
            NuD_Klein_Stark_09.Value = 0;
            NuD_Groß_Schwach_09.Value = 0;
            NuD_Groß_Mittel_09.Value = 0;
            NuD_Groß_Stark_09.Value = 0;
            NuD_Klein_Schwach_10.Value = 0;
            NuD_Klein_Mittel_10.Value = 0;
            NuD_Klein_Stark_10.Value = 0;
            NuD_Groß_Schwach_10.Value = 0;
            NuD_Groß_Mittel_10.Value = 0;
            NuD_Groß_Stark_10.Value = 0;
            NuD_Klein_Schwach_11.Value = 0;
            NuD_Klein_Mittel_11.Value = 0;
            NuD_Klein_Stark_11.Value = 0;
            NuD_Groß_Schwach_11.Value = 0;
            NuD_Groß_Mittel_11.Value = 0;
            NuD_Groß_Stark_11.Value = 0;
            NuD_Klein_Schwach_12.Value = 0;
            NuD_Klein_Mittel_12.Value = 0;
            NuD_Klein_Stark_12.Value = 0;
            NuD_Groß_Schwach_12.Value = 0;
            NuD_Groß_Mittel_12.Value = 0;
            NuD_Groß_Stark_12.Value = 0;
            NuD_Klein_Schwach_13.Value = 0;
            NuD_Klein_Mittel_13.Value = 0;
            NuD_Klein_Stark_13.Value = 0;
            NuD_Groß_Schwach_13.Value = 0;
            NuD_Groß_Mittel_13.Value = 0;
            NuD_Groß_Stark_13.Value = 0;
            NuD_Klein_Schwach_14.Value = 0;
            NuD_Klein_Mittel_14.Value = 0;
            NuD_Klein_Stark_14.Value = 0;
            NuD_Groß_Schwach_14.Value = 0;
            NuD_Groß_Mittel_14.Value = 0;
            NuD_Groß_Stark_14.Value = 0;
            NuD_Klein_Schwach_15.Value = 0;
            NuD_Klein_Mittel_15.Value = 0;
            NuD_Klein_Stark_15.Value = 0;
            NuD_Groß_Schwach_15.Value = 0;
            NuD_Groß_Mittel_15.Value = 0;
            NuD_Groß_Stark_15.Value = 0;
            NuD_Klein_Schwach_16.Value = 0;
            NuD_Klein_Mittel_16.Value = 0;
            NuD_Klein_Stark_16.Value = 0;
            NuD_Groß_Schwach_16.Value = 0;
            NuD_Groß_Mittel_16.Value = 0;
            NuD_Groß_Stark_16.Value = 0;

            CmD_Neu.Enabled = false;
            CmD_Sichern.Enabled = false;
        }
        #endregion

        #region Save Data
        private void SaveData()
        {
            OracleConnection oConnection = new OracleConnection();
            OracleCommand oCommandSelect = new OracleCommand();
            OracleCommand oCommandInsert = new OracleCommand();
            OracleDataReader drReader;

            bool bUpdate = false;
            bool bInsert = false;

            int nResult = 0;

            string sAktiv = "";

            if (ChK_Aktiv.Checked == true) { sAktiv = "1"; } else { sAktiv = "0"; }

            using (oConnection)
            {
                try
                {
                    oConnection.ConnectionString = Frm_Haupt.sDSN;
                    oConnection.Open();

                    oCommandSelect.Connection = oConnection;
                    oCommandInsert.Connection = oConnection;

                    oCommandSelect.CommandText = Cls_Query.GetCocktailRezepte(TxT_Name.Text.Trim());
                    drReader = oCommandSelect.ExecuteReader();
                    if (drReader.HasRows) { bUpdate = true; bInsert = false; } else { bUpdate = false; bInsert = true; }
                    drReader.Close();

                    oCommandInsert.CommandText = Cls_Query.InsertNeuerCocktail(bUpdate, bInsert, TxT_Name.Text.Trim(),
                        LbL_Zutat_01.Text.Trim(),
                        NuD_Klein_Schwach_01.Value.ToString().Trim().Replace(",","."),
                        NuD_Klein_Mittel_01.Value.ToString().Trim().Replace(",", "."),
                        NuD_Klein_Stark_01.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Schwach_01.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Mittel_01.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Stark_01.Value.ToString().Trim().Replace(",", "."),
                        LbL_Zutat_02.Text.Trim(),
                        NuD_Klein_Schwach_02.Value.ToString().Trim().Replace(",", "."),
                        NuD_Klein_Mittel_02.Value.ToString().Trim().Replace(",", "."),
                        NuD_Klein_Stark_02.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Schwach_02.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Mittel_02.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Stark_02.Value.ToString().Trim().Replace(",", "."),
                        LbL_Zutat_03.Text.Trim(),
                        NuD_Klein_Schwach_03.Value.ToString().Trim().Replace(",", "."),
                        NuD_Klein_Mittel_03.Value.ToString().Trim().Replace(",", "."),
                        NuD_Klein_Stark_03.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Schwach_03.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Mittel_03.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Stark_03.Value.ToString().Trim().Replace(",", "."),
                        LbL_Zutat_04.Text.Trim(),
                        NuD_Klein_Schwach_04.Value.ToString().Trim().Replace(",", "."),
                        NuD_Klein_Mittel_04.Value.ToString().Trim().Replace(",", "."),
                        NuD_Klein_Stark_04.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Schwach_04.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Mittel_04.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Stark_04.Value.ToString().Trim().Replace(",", "."),
                        LbL_Zutat_05.Text.Trim(),
                        NuD_Klein_Schwach_05.Value.ToString().Trim().Replace(",", "."),
                        NuD_Klein_Mittel_05.Value.ToString().Trim().Replace(",", "."),
                        NuD_Klein_Stark_05.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Schwach_05.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Mittel_05.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Stark_05.Value.ToString().Trim().Replace(",", "."),
                        LbL_Zutat_06.Text.Trim(),
                        NuD_Klein_Schwach_06.Value.ToString().Trim().Replace(",", "."),
                        NuD_Klein_Mittel_06.Value.ToString().Trim().Replace(",", "."),
                        NuD_Klein_Stark_06.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Schwach_06.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Mittel_06.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Stark_06.Value.ToString().Trim().Replace(",", "."),
                        LbL_Zutat_07.Text.Trim(),
                        NuD_Klein_Schwach_07.Value.ToString().Trim().Replace(",", "."),
                        NuD_Klein_Mittel_07.Value.ToString().Trim().Replace(",", "."),
                        NuD_Klein_Stark_07.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Schwach_07.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Mittel_07.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Stark_07.Value.ToString().Trim().Replace(",", "."),
                        LbL_Zutat_08.Text.Trim(),
                        NuD_Klein_Schwach_08.Value.ToString().Trim().Replace(",", "."),
                        NuD_Klein_Mittel_08.Value.ToString().Trim().Replace(",", "."),
                        NuD_Klein_Stark_08.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Schwach_08.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Mittel_08.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Stark_08.Value.ToString().Trim().Replace(",", "."),
                        LbL_Zutat_09.Text.Trim(),
                        NuD_Klein_Schwach_09.Value.ToString().Trim().Replace(",", "."),
                        NuD_Klein_Mittel_09.Value.ToString().Trim().Replace(",", "."),
                        NuD_Klein_Stark_09.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Schwach_09.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Mittel_09.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Stark_09.Value.ToString().Trim().Replace(",", "."),
                        LbL_Zutat_10.Text.Trim(),
                        NuD_Klein_Schwach_10.Value.ToString().Trim().Replace(",", "."),
                        NuD_Klein_Mittel_10.Value.ToString().Trim().Replace(",", "."),
                        NuD_Klein_Stark_10.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Schwach_10.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Mittel_10.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Stark_10.Value.ToString().Trim().Replace(",", "."),
                        LbL_Zutat_11.Text.Trim(),
                        NuD_Klein_Schwach_11.Value.ToString().Trim().Replace(",", "."),
                        NuD_Klein_Mittel_11.Value.ToString().Trim().Replace(",", "."),
                        NuD_Klein_Stark_11.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Schwach_11.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Mittel_11.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Stark_11.Value.ToString().Trim().Replace(",", "."),
                        LbL_Zutat_12.Text.Trim(),
                        NuD_Klein_Schwach_12.Value.ToString().Trim().Replace(",", "."),
                        NuD_Klein_Mittel_12.Value.ToString().Trim().Replace(",", "."),
                        NuD_Klein_Stark_12.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Schwach_12.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Mittel_12.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Stark_12.Value.ToString().Trim().Replace(",", "."),
                        LbL_Zutat_13.Text.Trim(),
                        NuD_Klein_Schwach_13.Value.ToString().Trim().Replace(",", "."),
                        NuD_Klein_Mittel_13.Value.ToString().Trim().Replace(",", "."),
                        NuD_Klein_Stark_13.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Schwach_13.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Mittel_13.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Stark_13.Value.ToString().Trim().Replace(",", "."),
                        LbL_Zutat_14.Text.Trim(),
                        NuD_Klein_Schwach_14.Value.ToString().Trim().Replace(",", "."),
                        NuD_Klein_Mittel_14.Value.ToString().Trim().Replace(",", "."),
                        NuD_Klein_Stark_14.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Schwach_14.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Mittel_14.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Stark_14.Value.ToString().Trim().Replace(",", "."),
                        LbL_Zutat_15.Text.Trim(),
                        NuD_Klein_Schwach_15.Value.ToString().Trim().Replace(",", "."),
                        NuD_Klein_Mittel_15.Value.ToString().Trim().Replace(",", "."),
                        NuD_Klein_Stark_15.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Schwach_15.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Mittel_15.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Stark_15.Value.ToString().Trim().Replace(",", "."),
                        LbL_Zutat_16.Text.Trim(),
                        NuD_Klein_Schwach_16.Value.ToString().Trim().Replace(",", "."),
                        NuD_Klein_Mittel_16.Value.ToString().Trim().Replace(",", "."),
                        NuD_Klein_Stark_16.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Schwach_16.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Mittel_16.Value.ToString().Trim().Replace(",", "."),
                        NuD_Groß_Stark_16.Value.ToString().Trim().Replace(",", "."),
                        TxT_Preis_Klein_Schwach.Text.Trim().Replace(",", "."),
                        TxT_Preis_Klein_Mittel.Text.Trim().Replace(",", "."),
                        TxT_Preis_Klein_Stark.Text.Trim().Replace(",", "."),
                        TxT_Preis_Gross_Schwach.Text.Trim().Replace(",", "."),
                        TxT_Preis_Gross_Mittel.Text.Trim().Replace(",", "."),
                        TxT_Preis_Gross_Stark.Text.Trim().Replace(",", "."),
                        sAktiv);
                    nResult = oCommandInsert.ExecuteNonQuery();

                    oCommandInsert.CommandText = Cls_Query.SaveGüterDaten(bInsert, bUpdate, TxT_Name.Text.Trim(), "0", "1");
                    nResult = oCommandInsert.ExecuteNonQuery();

                    oConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "GetGüter");
                }
            }
        }
        #endregion

        #region LoadData
        private void LoadData()
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
                    oCommand.CommandText = Cls_Query.GetCocktailRezepte("");
                    drReader = oCommand.ExecuteReader();

                    DgV_Cocktails.AllowUserToAddRows = true;
                    DgV_Cocktails.Rows.Clear();
                    while (drReader.Read())
                    {
                        DataGridViewRow row = (DataGridViewRow)DgV_Cocktails.Rows[0].Clone();
                        row.Cells[0].Value = drReader.GetValue(0).ToString().Trim();
                        DgV_Cocktails.Rows.Add(row);
                    }
                    drReader.Close();
                    DgV_Cocktails.AllowUserToAddRows = false;

                    oConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "GetGüter");
                }
            }
        }
        #endregion

        #region LoadDataEinzeln
        private void LoadDataEinzeln()
        {
            OracleConnection oConnection = new OracleConnection();
            OracleCommand oCommand = new OracleCommand();
            OracleDataReader drReader;

            int nZähler = 0;

            using (oConnection)
            {
                try
                {
                    oConnection.ConnectionString = Frm_Haupt.sDSN;
                    oConnection.Open();

                    oCommand.Connection = oConnection;
                    oCommand.CommandText = Cls_Query.GetCocktailRezepte(TxT_Name.Text.Trim());
                    drReader = oCommand.ExecuteReader();

                    while (drReader.Read())
                    {
                        TxT_Preis_Klein_Schwach.Text = drReader.GetValue(1).ToString().Trim();
                        TxT_Preis_Klein_Mittel.Text = drReader.GetValue(99).ToString().Trim();
                        TxT_Preis_Klein_Stark.Text = drReader.GetValue(100).ToString().Trim();
                        TxT_Preis_Gross_Schwach.Text = drReader.GetValue(101).ToString().Trim();
                        TxT_Preis_Gross_Mittel.Text = drReader.GetValue(102).ToString().Trim();
                        TxT_Preis_Gross_Stark.Text = drReader.GetValue(103).ToString().Trim();
                        if (drReader.GetValue(2).ToString().Trim() == "1") { ChK_Aktiv.Checked = true; } else { ChK_Aktiv.Checked = false; }

                        NuD_Klein_Schwach_01.Value = Convert.ToDecimal(drReader.GetValue(3 + nZähler));
                        NuD_Klein_Mittel_01.Value = Convert.ToDecimal(drReader.GetValue(4 + nZähler));
                        NuD_Klein_Stark_01.Value = Convert.ToDecimal(drReader.GetValue(5 + nZähler));
                        NuD_Groß_Schwach_01.Value = Convert.ToDecimal(drReader.GetValue(6 + nZähler));
                        NuD_Groß_Mittel_01.Value = Convert.ToDecimal(drReader.GetValue(7 + nZähler));
                        NuD_Groß_Stark_01.Value = Convert.ToDecimal(drReader.GetValue(8 + nZähler));
                        nZähler = nZähler + 6;

                        NuD_Klein_Schwach_02.Value = Convert.ToDecimal(drReader.GetValue(3 + nZähler));
                        NuD_Klein_Mittel_02.Value = Convert.ToDecimal(drReader.GetValue(4 + nZähler));
                        NuD_Klein_Stark_02.Value = Convert.ToDecimal(drReader.GetValue(5 + nZähler));
                        NuD_Groß_Schwach_02.Value = Convert.ToDecimal(drReader.GetValue(6 + nZähler));
                        NuD_Groß_Mittel_02.Value = Convert.ToDecimal(drReader.GetValue(7 + nZähler));
                        NuD_Groß_Stark_02.Value = Convert.ToDecimal(drReader.GetValue(8 + nZähler));
                        nZähler = nZähler + 6;

                        NuD_Klein_Schwach_03.Value = Convert.ToDecimal(drReader.GetValue(3 + nZähler));
                        NuD_Klein_Mittel_03.Value = Convert.ToDecimal(drReader.GetValue(4 + nZähler));
                        NuD_Klein_Stark_03.Value = Convert.ToDecimal(drReader.GetValue(5 + nZähler));
                        NuD_Groß_Schwach_03.Value = Convert.ToDecimal(drReader.GetValue(6 + nZähler));
                        NuD_Groß_Mittel_03.Value = Convert.ToDecimal(drReader.GetValue(7 + nZähler));
                        NuD_Groß_Stark_03.Value = Convert.ToDecimal(drReader.GetValue(8 + nZähler));
                        nZähler = nZähler + 6;

                        NuD_Klein_Schwach_04.Value = Convert.ToDecimal(drReader.GetValue(3 + nZähler));
                        NuD_Klein_Mittel_04.Value = Convert.ToDecimal(drReader.GetValue(4 + nZähler));
                        NuD_Klein_Stark_04.Value = Convert.ToDecimal(drReader.GetValue(5 + nZähler));
                        NuD_Groß_Schwach_04.Value = Convert.ToDecimal(drReader.GetValue(6 + nZähler));
                        NuD_Groß_Mittel_04.Value = Convert.ToDecimal(drReader.GetValue(7 + nZähler));
                        NuD_Groß_Stark_04.Value = Convert.ToDecimal(drReader.GetValue(8 + nZähler));
                        nZähler = nZähler + 6;

                        NuD_Klein_Schwach_05.Value = Convert.ToDecimal(drReader.GetValue(3 + nZähler));
                        NuD_Klein_Mittel_05.Value = Convert.ToDecimal(drReader.GetValue(4 + nZähler));
                        NuD_Klein_Stark_05.Value = Convert.ToDecimal(drReader.GetValue(5 + nZähler));
                        NuD_Groß_Schwach_05.Value = Convert.ToDecimal(drReader.GetValue(6 + nZähler));
                        NuD_Groß_Mittel_05.Value = Convert.ToDecimal(drReader.GetValue(7 + nZähler));
                        NuD_Groß_Stark_05.Value = Convert.ToDecimal(drReader.GetValue(8 + nZähler));
                        nZähler = nZähler + 6;

                        NuD_Klein_Schwach_06.Value = Convert.ToDecimal(drReader.GetValue(3 + nZähler));
                        NuD_Klein_Mittel_06.Value = Convert.ToDecimal(drReader.GetValue(4 + nZähler));
                        NuD_Klein_Stark_06.Value = Convert.ToDecimal(drReader.GetValue(5 + nZähler));
                        NuD_Groß_Schwach_06.Value = Convert.ToDecimal(drReader.GetValue(6 + nZähler));
                        NuD_Groß_Mittel_06.Value = Convert.ToDecimal(drReader.GetValue(7 + nZähler));
                        NuD_Groß_Stark_06.Value = Convert.ToDecimal(drReader.GetValue(8 + nZähler));
                        nZähler = nZähler + 6;

                        NuD_Klein_Schwach_07.Value = Convert.ToDecimal(drReader.GetValue(3 + nZähler));
                        NuD_Klein_Mittel_07.Value = Convert.ToDecimal(drReader.GetValue(4 + nZähler));
                        NuD_Klein_Stark_07.Value = Convert.ToDecimal(drReader.GetValue(5 + nZähler));
                        NuD_Groß_Schwach_07.Value = Convert.ToDecimal(drReader.GetValue(6 + nZähler));
                        NuD_Groß_Mittel_07.Value = Convert.ToDecimal(drReader.GetValue(7 + nZähler));
                        NuD_Groß_Stark_07.Value = Convert.ToDecimal(drReader.GetValue(8 + nZähler));
                        nZähler = nZähler + 6;

                        NuD_Klein_Schwach_08.Value = Convert.ToDecimal(drReader.GetValue(3 + nZähler));
                        NuD_Klein_Mittel_08.Value = Convert.ToDecimal(drReader.GetValue(4 + nZähler));
                        NuD_Klein_Stark_08.Value = Convert.ToDecimal(drReader.GetValue(5 + nZähler));
                        NuD_Groß_Schwach_08.Value = Convert.ToDecimal(drReader.GetValue(6 + nZähler));
                        NuD_Groß_Mittel_08.Value = Convert.ToDecimal(drReader.GetValue(7 + nZähler));
                        NuD_Groß_Stark_08.Value = Convert.ToDecimal(drReader.GetValue(8 + nZähler));
                        nZähler = nZähler + 6;

                        NuD_Klein_Schwach_09.Value = Convert.ToDecimal(drReader.GetValue(3 + nZähler));
                        NuD_Klein_Mittel_09.Value = Convert.ToDecimal(drReader.GetValue(4 + nZähler));
                        NuD_Klein_Stark_09.Value = Convert.ToDecimal(drReader.GetValue(5 + nZähler));
                        NuD_Groß_Schwach_09.Value = Convert.ToDecimal(drReader.GetValue(6 + nZähler));
                        NuD_Groß_Mittel_09.Value = Convert.ToDecimal(drReader.GetValue(7 + nZähler));
                        NuD_Groß_Stark_09.Value = Convert.ToDecimal(drReader.GetValue(8 + nZähler));
                        nZähler = nZähler + 6;

                        NuD_Klein_Schwach_10.Value = Convert.ToDecimal(drReader.GetValue(3 + nZähler));
                        NuD_Klein_Mittel_10.Value = Convert.ToDecimal(drReader.GetValue(4 + nZähler));
                        NuD_Klein_Stark_10.Value = Convert.ToDecimal(drReader.GetValue(5 + nZähler));
                        NuD_Groß_Schwach_10.Value = Convert.ToDecimal(drReader.GetValue(6 + nZähler));
                        NuD_Groß_Mittel_10.Value = Convert.ToDecimal(drReader.GetValue(7 + nZähler));
                        NuD_Groß_Stark_10.Value = Convert.ToDecimal(drReader.GetValue(8 + nZähler));
                        nZähler = nZähler + 6;

                        NuD_Klein_Schwach_11.Value = Convert.ToDecimal(drReader.GetValue(3 + nZähler));
                        NuD_Klein_Mittel_11.Value = Convert.ToDecimal(drReader.GetValue(4 + nZähler));
                        NuD_Klein_Stark_11.Value = Convert.ToDecimal(drReader.GetValue(5 + nZähler));
                        NuD_Groß_Schwach_11.Value = Convert.ToDecimal(drReader.GetValue(6 + nZähler));
                        NuD_Groß_Mittel_11.Value = Convert.ToDecimal(drReader.GetValue(7 + nZähler));
                        NuD_Groß_Stark_11.Value = Convert.ToDecimal(drReader.GetValue(8 + nZähler));
                        nZähler = nZähler + 6;

                        NuD_Klein_Schwach_12.Value = Convert.ToDecimal(drReader.GetValue(3 + nZähler));
                        NuD_Klein_Mittel_12.Value = Convert.ToDecimal(drReader.GetValue(4 + nZähler));
                        NuD_Klein_Stark_12.Value = Convert.ToDecimal(drReader.GetValue(5 + nZähler));
                        NuD_Groß_Schwach_12.Value = Convert.ToDecimal(drReader.GetValue(6 + nZähler));
                        NuD_Groß_Mittel_12.Value = Convert.ToDecimal(drReader.GetValue(7 + nZähler));
                        NuD_Groß_Stark_12.Value = Convert.ToDecimal(drReader.GetValue(8 + nZähler));
                        nZähler = nZähler + 6;

                        NuD_Klein_Schwach_13.Value = Convert.ToDecimal(drReader.GetValue(3 + nZähler));
                        NuD_Klein_Mittel_13.Value = Convert.ToDecimal(drReader.GetValue(4 + nZähler));
                        NuD_Klein_Stark_13.Value = Convert.ToDecimal(drReader.GetValue(5 + nZähler));
                        NuD_Groß_Schwach_13.Value = Convert.ToDecimal(drReader.GetValue(6 + nZähler));
                        NuD_Groß_Mittel_13.Value = Convert.ToDecimal(drReader.GetValue(7 + nZähler));
                        NuD_Groß_Stark_13.Value = Convert.ToDecimal(drReader.GetValue(8 + nZähler));
                        nZähler = nZähler + 6;

                        NuD_Klein_Schwach_14.Value = Convert.ToDecimal(drReader.GetValue(3 + nZähler));
                        NuD_Klein_Mittel_14.Value = Convert.ToDecimal(drReader.GetValue(4 + nZähler));
                        NuD_Klein_Stark_14.Value = Convert.ToDecimal(drReader.GetValue(5 + nZähler));
                        NuD_Groß_Schwach_14.Value = Convert.ToDecimal(drReader.GetValue(6 + nZähler));
                        NuD_Groß_Mittel_14.Value = Convert.ToDecimal(drReader.GetValue(7 + nZähler));
                        NuD_Groß_Stark_14.Value = Convert.ToDecimal(drReader.GetValue(8 + nZähler));
                        nZähler = nZähler + 6;

                        NuD_Klein_Schwach_15.Value = Convert.ToDecimal(drReader.GetValue(3 + nZähler));
                        NuD_Klein_Mittel_15.Value = Convert.ToDecimal(drReader.GetValue(4 + nZähler));
                        NuD_Klein_Stark_15.Value = Convert.ToDecimal(drReader.GetValue(5 + nZähler));
                        NuD_Groß_Schwach_15.Value = Convert.ToDecimal(drReader.GetValue(6 + nZähler));
                        NuD_Groß_Mittel_15.Value = Convert.ToDecimal(drReader.GetValue(7 + nZähler));
                        NuD_Groß_Stark_15.Value = Convert.ToDecimal(drReader.GetValue(8 + nZähler));
                        nZähler = nZähler + 6;

                        NuD_Klein_Schwach_16.Value = Convert.ToDecimal(drReader.GetValue(3 + nZähler));
                        NuD_Klein_Mittel_16.Value = Convert.ToDecimal(drReader.GetValue(4 + nZähler));
                        NuD_Klein_Stark_16.Value = Convert.ToDecimal(drReader.GetValue(5 + nZähler));
                        NuD_Groß_Schwach_16.Value = Convert.ToDecimal(drReader.GetValue(6 + nZähler));
                        NuD_Groß_Mittel_16.Value = Convert.ToDecimal(drReader.GetValue(7 + nZähler));
                        NuD_Groß_Stark_16.Value = Convert.ToDecimal(drReader.GetValue(8 + nZähler));
                        nZähler = nZähler + 6;
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
        #endregion

        #region Relaiszeitmessung
        private void CmD_TestRelais1_MouseDown(object sender, MouseEventArgs e)
        {
            dStart = System.DateTime.Now;
            _serialPort.Write(new byte[] { 0xFF, 0x01, 0x01 }, 0, 3);
        }

        private void CmD_TestRelais2_MouseDown(object sender, MouseEventArgs e)
        {
            dStart = System.DateTime.Now;
            _serialPort.Write(new byte[] { 0xFF, 0x02, 0x01 }, 0, 3);
        }

        private void CmD_TestRelais3_MouseDown(object sender, MouseEventArgs e)
        {
            dStart = System.DateTime.Now;
            _serialPort.Write(new byte[] { 0xFF, 0x03, 0x01 }, 0, 3);
        }

        private void CmD_TestRelais4_MouseDown(object sender, MouseEventArgs e)
        {
            dStart = System.DateTime.Now;
            _serialPort.Write(new byte[] { 0xFF, 0x04, 0x01 }, 0, 3);
        }

        private void CmD_TestRelais5_MouseDown(object sender, MouseEventArgs e)
        {
            dStart = System.DateTime.Now;
            _serialPort.Write(new byte[] { 0xFF, 0x05, 0x01 }, 0, 3);
        }

        private void CmD_TestRelais6_MouseDown(object sender, MouseEventArgs e)
        {
            dStart = System.DateTime.Now;
            _serialPort.Write(new byte[] { 0xFF, 0x06, 0x01 }, 0, 3);
        }

        private void CmD_TestRelais7_MouseDown(object sender, MouseEventArgs e)
        {
            dStart = System.DateTime.Now;
            _serialPort.Write(new byte[] { 0xFF, 0x07, 0x01 }, 0, 3);
        }

        private void CmD_TestRelais8_MouseDown(object sender, MouseEventArgs e)
        {
            dStart = System.DateTime.Now;
            _serialPort.Write(new byte[] { 0xFF, 0x08, 0x01 }, 0, 3);
        }

        private void CmD_TestRelais9_MouseDown(object sender, MouseEventArgs e)
        {
            dStart = System.DateTime.Now;
            _serialPort.Write(new byte[] { 0xFF, 0x09, 0x01 }, 0, 3);
        }

        private void CmD_TestRelais10_MouseDown(object sender, MouseEventArgs e)
        {
            dStart = System.DateTime.Now;
            _serialPort.Write(new byte[] { 0xFF, 0x0A, 0x01 }, 0, 3);
        }

        private void CmD_TestRelais11_MouseDown(object sender, MouseEventArgs e)
        {
            dStart = System.DateTime.Now;
            _serialPort.Write(new byte[] { 0xFF, 0x0B, 0x01 }, 0, 3);
        }

        private void CmD_TestRelais1_MouseUp(object sender, MouseEventArgs e)
        {
            TimeSpan dDiff;

            _serialPort.Write(new byte[] { 0xFF, 0x01, 0x00 }, 0, 3);
            dEnd = System.DateTime.Now;

            dDiff = dEnd - dStart;

            LbL_AktivierungR1.Text = "Aktivierungszeit: " + Math.Round(dDiff.TotalSeconds, 2).ToString().Trim() + "s";
        }

        private void CmD_TestRelais2_MouseUp(object sender, MouseEventArgs e)
        {
            TimeSpan dDiff;

            _serialPort.Write(new byte[] { 0xFF, 0x02, 0x00 }, 0, 3);
            dEnd = System.DateTime.Now;

            dDiff = dEnd - dStart;

            LbL_AktivierungR2.Text = "Aktivierungszeit: " + Math.Round(dDiff.TotalSeconds, 2).ToString().Trim() + "s";
        }

        private void CmD_TestRelais3_MouseUp(object sender, MouseEventArgs e)
        {
            TimeSpan dDiff;

            _serialPort.Write(new byte[] { 0xFF, 0x03, 0x00 }, 0, 3);
            dEnd = System.DateTime.Now;

            dDiff = dEnd - dStart;

            LbL_AktivierungR3.Text = "Aktivierungszeit: " + Math.Round(dDiff.TotalSeconds, 2).ToString().Trim() + "s";
        }

        private void CmD_TestRelais4_MouseUp(object sender, MouseEventArgs e)
        {
            TimeSpan dDiff;

            _serialPort.Write(new byte[] { 0xFF, 0x04, 0x00 }, 0, 3);
            dEnd = System.DateTime.Now;

            dDiff = dEnd - dStart;

            LbL_AktivierungR4.Text = "Aktivierungszeit: " + Math.Round(dDiff.TotalSeconds, 2).ToString().Trim() + "s";
        }

        private void CmD_TestRelais5_MouseUp(object sender, MouseEventArgs e)
        {
            TimeSpan dDiff;

            _serialPort.Write(new byte[] { 0xFF, 0x05, 0x00 }, 0, 3);
            dEnd = System.DateTime.Now;

            dDiff = dEnd - dStart;

            LbL_AktivierungR5.Text = "Aktivierungszeit: " + Math.Round(dDiff.TotalSeconds, 2).ToString().Trim() + "s";
        }

        private void CmD_TestRelais6_MouseUp(object sender, MouseEventArgs e)
        {
            TimeSpan dDiff;

            _serialPort.Write(new byte[] { 0xFF, 0x06, 0x00 }, 0, 3);
            dEnd = System.DateTime.Now;

            dDiff = dEnd - dStart;

            LbL_AktivierungR6.Text = "Aktivierungszeit: " + Math.Round(dDiff.TotalSeconds, 2).ToString().Trim() + "s";
        }

        private void CmD_TestRelais7_MouseUp(object sender, MouseEventArgs e)
        {
            TimeSpan dDiff;

            _serialPort.Write(new byte[] { 0xFF, 0x07, 0x00 }, 0, 3);
            dEnd = System.DateTime.Now;

            dDiff = dEnd - dStart;

            LbL_AktivierungR7.Text = "Aktivierungszeit: " + Math.Round(dDiff.TotalSeconds, 2).ToString().Trim() + "s";
        }

        private void CmD_TestRelais8_MouseUp(object sender, MouseEventArgs e)
        {
            TimeSpan dDiff;

            _serialPort.Write(new byte[] { 0xFF, 0x08, 0x00 }, 0, 3);
            dEnd = System.DateTime.Now;

            dDiff = dEnd - dStart;

            LbL_AktivierungR8.Text = "Aktivierungszeit: " + Math.Round(dDiff.TotalSeconds, 2).ToString().Trim() + "s";
        }

        private void CmD_TestRelais9_MouseUp(object sender, MouseEventArgs e)
        {
            TimeSpan dDiff;

            _serialPort.Write(new byte[] { 0xFF, 0x09, 0x00 }, 0, 3);
            dEnd = System.DateTime.Now;

            dDiff = dEnd - dStart;

            LbL_AktivierungR9.Text = "Aktivierungszeit: " + Math.Round(dDiff.TotalSeconds, 2).ToString().Trim() + "s";
        }

        private void CmD_TestRelais10_MouseUp(object sender, MouseEventArgs e)
        {
            TimeSpan dDiff;

            _serialPort.Write(new byte[] { 0xFF, 0x0A, 0x00 }, 0, 3);
            dEnd = System.DateTime.Now;

            dDiff = dEnd - dStart;

            LbL_AktivierungR10.Text = "Aktivierungszeit: " + Math.Round(dDiff.TotalSeconds, 2).ToString().Trim() + "s";
        }

        private void CmD_TestRelais11_MouseUp(object sender, MouseEventArgs e)
        {
            TimeSpan dDiff;

            _serialPort.Write(new byte[] { 0xFF, 0x0B, 0x00 }, 0, 3);
            dEnd = System.DateTime.Now;

            dDiff = dEnd - dStart;

            LbL_AktivierungR11.Text = "Aktivierungszeit: " + Math.Round(dDiff.TotalSeconds, 2).ToString().Trim() + "s";
        }
        #endregion
    }
}
