using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Bauwagen
{
    public partial class Frm_CocktailMixer : Form
    {
        public static int nAnzahlAnwender = 0;
        public static int nAnzahlButtonsCocktails = 0;

        public static bool bBlockRefresh = false;
        public static bool bLoad = false;

        public string sButtonClicked = "";
        public string sCocktailName = "";
        public string sCocktailGröße = "";
        public string sCocktailPreis = "";

        SerialPort _serialPort;

        public Frm_CocktailMixer()
        {
            InitializeComponent();
        }

        private void Frm_CocktailMixer_Load(object sender, EventArgs e)
        {
            try
            {
                _serialPort = new SerialPort();
                _serialPort.PortName = Properties.Settings.Default.ComRelaisCocktail;

                // Set the read/write timeouts
                _serialPort.BaudRate = 9600;
                _serialPort.ReadTimeout = 500;
                _serialPort.WriteTimeout = 500;

                _serialPort.Open();

                CreateButtons();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Frm_CocktailMixer_Load()");
                this.Close();
            }
        }

        private void Frm_CocktailMixer_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                _serialPort.Close();
            }
            catch
            {
            }
        }

        private void CreateButtons()
        {
            OracleConnection oConnection = new OracleConnection();
            OracleCommand oCommand = new OracleCommand();
            OracleDataReader drReader;

            int nLocationX = 0;
            int nLocationY = 0;
            int nOffset = 0;
            int nSpalte = 0;
            int nOffsetX = 10;
            int nOffsetY = 10;
            int a = 0;
            int b = 0;

            try
            {
                using (oConnection)
                {
                    oConnection.ConnectionString = Frm_Haupt.sDSN;
                    oConnection.Open();

                    #region Buttons für Cocktails erstellen
                    oCommand.Connection = oConnection;
                    oCommand.CommandText = Cls_Query.GetNumberOfCocktails();
                    drReader = oCommand.ExecuteReader();

                    while (drReader.Read())
                    {
                        nAnzahlButtonsCocktails = Convert.ToInt32(drReader.GetValue(0));
                    }
                    drReader.Close();

                    System.Windows.Forms.Button[] ButtonCocktails = new System.Windows.Forms.Button[nAnzahlButtonsCocktails];

                    oCommand.CommandText = Cls_Query.GetCocktailRezepte("", "1");
                    drReader = oCommand.ExecuteReader();

                    while (drReader.Read())
                    {
                        ButtonCocktails[a] = new Button();

                        ButtonCocktails[a].Height = 70;
                        ButtonCocktails[a].Width = 140;

                        nLocationY = (5 + ButtonCocktails[a].Height) * (a - nOffset) + nOffsetY;
                        nLocationX = (12 + ButtonCocktails[a].Width) * nSpalte + nOffsetX;

                        ButtonCocktails[a].Location = new Point(nLocationX, nLocationY);
                        ButtonCocktails[a].Name = "CmD_Cocktail_" + a.ToString().PadLeft(2, '0');
                        ButtonCocktails[a].Text = drReader.GetValue(0).ToString().Trim();
                        ButtonCocktails[a].Tag = drReader.GetValue(0).ToString().Trim();
                        ButtonCocktails[a].Font = new Font("Microsoft Sans Serif", 14.25f);
                        ButtonCocktails[a].Click += new EventHandler(buttonCocktail_Clicked);

                        FlW_Cocktails.Controls.Add(ButtonCocktails[a]);

                        //if (Convert.ToInt32(drReader.GetValue(5)) == 1 | Convert.ToInt32(drReader.GetValue(6)) > 5) { ButtonCocktails[a].Enabled = false; }

                        if (nLocationY > 550) { nOffset = a + 1; nSpalte += 1; }
                        a++;
                    }

                    nAnzahlAnwender = a;
                    #endregion

                    oConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CreateButtons");
            }
        }

        private void buttonCocktail_Clicked(object sender, EventArgs e)
        {
            OracleConnection oConnection = new OracleConnection();
            OracleCommand oCommand = new OracleCommand();
            OracleDataReader drReader;

            bBlockRefresh = true;

            Button angeklickterButton = (Button)sender;

            string sName = angeklickterButton.Text.Trim();
            sButtonClicked = angeklickterButton.Name;

            sCocktailName = sName;

            for (int i = 0; i < nAnzahlButtonsCocktails; i++)
            {
                if (GetAnwenderControlByName("CmD_Cocktail_" + i.ToString().PadLeft(2, '0')).Name == angeklickterButton.Name)
                {
                    GetAnwenderControlByName("CmD_Cocktail_" + i.ToString().PadLeft(2, '0')).BackColor = Color.Green;
                }
                else
                {
                    GetAnwenderControlByName("CmD_Cocktail_" + i.ToString().PadLeft(2, '0')).BackColor = Color.LightGray;
                }
            }

            try
            {
                using (oConnection)
                {
                    string sButtonTag = angeklickterButton.Tag.ToString().Trim();
                    
                    oConnection.ConnectionString = Frm_Haupt.sDSN;
                    oConnection.Open();

                    oCommand.Connection = oConnection;
                    oCommand.CommandText = Cls_Query.GetCocktailRezepte(sButtonTag, "1");
                    drReader = oCommand.ExecuteReader();

                    while (drReader.Read())
                    {
                        if (drReader.GetValue(1).ToString().Trim() == "0") { CmD_Klein_Schwach.Visible = false; } else { CmD_Klein_Schwach.Visible = true; }
                        if (drReader.GetValue(99).ToString().Trim() == "0") { CmD_klein_mittel.Visible = false; } else { CmD_klein_mittel.Visible = true; }
                        if (drReader.GetValue(100).ToString().Trim() == "0") { CmD_Klein_Stark.Visible = false; } else { CmD_Klein_Stark.Visible = true; }
                        if (drReader.GetValue(101).ToString().Trim() == "0") { CmD_Groß_schwach.Visible = false; } else { CmD_Groß_schwach.Visible = true; }
                        if (drReader.GetValue(102).ToString().Trim() == "0") { CmD_Groß_mittel.Visible = false; } else { CmD_Groß_mittel.Visible = true; }
                        if (drReader.GetValue(103).ToString().Trim() == "0") { CmD_Groß_stark.Visible = false; } else { CmD_Groß_stark.Visible = true; }

                        CmD_Klein_Schwach.Text = "schwach\n" + String.Format("{0:0.00}", Convert.ToDouble(drReader.GetValue(1))) + " €";
                        CmD_klein_mittel.Text = "mittel\n" + String.Format("{0:0.00}", Convert.ToDouble(drReader.GetValue(99))) + " €";
                        CmD_Klein_Stark.Text = "stark\n" + String.Format("{0:0.00}", Convert.ToDouble(drReader.GetValue(100))) + " €";
                        CmD_Groß_schwach.Text = "schwach\n" + String.Format("{0:0.00}", Convert.ToDouble(drReader.GetValue(101))) + " €";
                        CmD_Groß_mittel.Text = "mittel\n" + String.Format("{0:0.00}", Convert.ToDouble(drReader.GetValue(102))) + " €";
                        CmD_Groß_stark.Text = "stark\n" + String.Format("{0:0.00}", Convert.ToDouble(drReader.GetValue(103))) + " €";
                    }
                    drReader.Close();

                    oConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "buttonCocktail_Clicked");
            }
        }

        Control GetAnwenderControlByName(string Name)
        {
            foreach (Control c in FlW_Cocktails.Controls)
                if (c.Name == Name)
                    return c;

            return null;
        }

        #region Buttons für die größe des Cocktails nach Auswahl einfärben
        private void CmD_Klein_Schwach_Click(object sender, EventArgs e)
        {
            if (CmD_Klein_Schwach.Text.Trim().IndexOf("\n") > 0)
            {
                CmD_Klein_Schwach.BackColor = Color.Green;
                CmD_klein_mittel.BackColor = Color.LightGray;
                CmD_Klein_Stark.BackColor = Color.LightGray;
                CmD_Groß_schwach.BackColor = Color.LightGray;
                CmD_Groß_mittel.BackColor = Color.LightGray;
                CmD_Groß_stark.BackColor = Color.LightGray;

                sCocktailGröße = "KLEIN_SCHWACH";
                sCocktailPreis = CmD_Klein_Schwach.Text.Trim().Substring(CmD_Klein_Schwach.Text.Trim().IndexOf("\n") + 1, CmD_Klein_Schwach.Text.Trim().Length - CmD_Klein_Schwach.Text.Trim().IndexOf("\n") - 3);
            }
        }

        private void CmD_klein_mittel_Click(object sender, EventArgs e)
        {
            if (CmD_klein_mittel.Text.Trim().IndexOf("\n") > 0)
            {
                CmD_Klein_Schwach.BackColor = Color.LightGray;
                CmD_klein_mittel.BackColor = Color.Green;
                CmD_Klein_Stark.BackColor = Color.LightGray;
                CmD_Groß_schwach.BackColor = Color.LightGray;
                CmD_Groß_mittel.BackColor = Color.LightGray;
                CmD_Groß_stark.BackColor = Color.LightGray;

                sCocktailGröße = "KLEIN_MITTEL";
                sCocktailPreis = CmD_klein_mittel.Text.Trim().Substring(CmD_klein_mittel.Text.Trim().IndexOf("\n") + 1, CmD_klein_mittel.Text.Trim().Length - CmD_klein_mittel.Text.Trim().IndexOf("\n") - 3);
            }
        }

        private void CmD_Klein_Stark_Click(object sender, EventArgs e)
        {
            if (CmD_Klein_Stark.Text.Trim().IndexOf("\n") > 0)
            {
                CmD_Klein_Schwach.BackColor = Color.LightGray;
                CmD_klein_mittel.BackColor = Color.LightGray;
                CmD_Klein_Stark.BackColor = Color.Green;
                CmD_Groß_schwach.BackColor = Color.LightGray;
                CmD_Groß_mittel.BackColor = Color.LightGray;
                CmD_Groß_stark.BackColor = Color.LightGray;

                sCocktailGröße = "KLEIN_STARK";
                sCocktailPreis = CmD_Klein_Stark.Text.Trim().Substring(CmD_Klein_Stark.Text.Trim().IndexOf("\n") + 1, CmD_Klein_Stark.Text.Trim().Length - CmD_Klein_Stark.Text.Trim().IndexOf("\n") - 3);
            }
        }

        private void CmD_Groß_schwach_Click(object sender, EventArgs e)
        {
            if (CmD_Groß_schwach.Text.Trim().IndexOf("\n") > 0)
            {
                CmD_Klein_Schwach.BackColor = Color.LightGray;
                CmD_klein_mittel.BackColor = Color.LightGray;
                CmD_Klein_Stark.BackColor = Color.LightGray;
                CmD_Groß_schwach.BackColor = Color.Green;
                CmD_Groß_mittel.BackColor = Color.LightGray;
                CmD_Groß_stark.BackColor = Color.LightGray;

                sCocktailGröße = "GROSS_SCHWACH";
                sCocktailPreis = CmD_Groß_schwach.Text.Trim().Substring(CmD_Groß_schwach.Text.Trim().IndexOf("\n") + 1, CmD_Groß_schwach.Text.Trim().Length - CmD_Groß_schwach.Text.Trim().IndexOf("\n") - 3);
            }
        }

        private void CmD_Groß_mittel_Click(object sender, EventArgs e)
        {
            if (CmD_Groß_mittel.Text.Trim().IndexOf("\n") > 0)
            {
                CmD_Klein_Schwach.BackColor = Color.LightGray;
                CmD_klein_mittel.BackColor = Color.LightGray;
                CmD_Klein_Stark.BackColor = Color.LightGray;
                CmD_Groß_schwach.BackColor = Color.LightGray;
                CmD_Groß_mittel.BackColor = Color.Green;
                CmD_Groß_stark.BackColor = Color.LightGray;

                sCocktailGröße = "GROSS_MITTEL";
                sCocktailPreis = CmD_Groß_mittel.Text.Trim().Substring(CmD_Groß_mittel.Text.Trim().IndexOf("\n") + 1, CmD_Groß_mittel.Text.Trim().Length - CmD_Groß_mittel.Text.Trim().IndexOf("\n") - 3);
            }
        }

        private void CmD_Groß_stark_Click(object sender, EventArgs e)
        {
            if (CmD_Groß_stark.Text.Trim().IndexOf("\n") > 0)
            {
                CmD_Klein_Schwach.BackColor = Color.LightGray;
                CmD_klein_mittel.BackColor = Color.LightGray;
                CmD_Klein_Stark.BackColor = Color.LightGray;
                CmD_Groß_schwach.BackColor = Color.LightGray;
                CmD_Groß_mittel.BackColor = Color.LightGray;
                CmD_Groß_stark.BackColor = Color.Green;

                sCocktailGröße = "GROSS_STARK";
                sCocktailPreis = CmD_Groß_stark.Text.Trim().Substring(CmD_Groß_stark.Text.Trim().IndexOf("\n") + 1, CmD_Groß_stark.Text.Trim().Length - CmD_Groß_stark.Text.Trim().IndexOf("\n") - 3);
            }
        }
        #endregion

        private void CalculatVerfügbar()
        {
            if (bLoad == false)
            {
                double nBudget = 0;
                double nWarenkorb = 0;
                double nVerfügbar = 0;

                string sBudget = LbL_Budget.Text.Trim().Substring(0, LbL_Budget.Text.Trim().Length - 2);
                string sWarenkorb = LbL_Summe.Text.Trim().Substring(0, LbL_Summe.Text.Trim().Length - 2);

                nBudget = Convert.ToDouble(sBudget);
                nWarenkorb = Convert.ToDouble(sWarenkorb);

                nVerfügbar = nBudget - nWarenkorb;

                LbL_Verfügbar.Text = String.Format("{0:0.00}", nVerfügbar) + " €";
            }
        }

        private void LbL_Summe_TextChanged(object sender, EventArgs e)
        {
            CalculatVerfügbar();
        }

        private void CmD_LöschenWarenkorb_Click(object sender, EventArgs e)
        {
            DgV_Warenkorb.Rows.Clear();
            LbL_Summe.Text = "0,00 €";
        }

        private void CmD_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmD_InDenWarenkorb_Click(object sender, EventArgs e)
        {
            double nPreis = 0;
            double nSumme = 0;

            if (sCocktailName != "" && sCocktailGröße != "" && sCocktailPreis != "")
            {
                DgV_Warenkorb.AllowUserToAddRows = true;

                DataGridViewRow row = (DataGridViewRow)DgV_Warenkorb.Rows[0].Clone();
                row.Height = 45;
                row.Cells[0].Value = sCocktailName;
                row.Cells[1].Value = sCocktailGröße;
                row.Cells[2].Value = sCocktailPreis;
                row.Cells[3].Value = sCocktailPreis;
                DgV_Warenkorb.Rows.Add(row);

                DgV_Warenkorb.AllowUserToAddRows = false;
            }

            for (int i = 0; i < DgV_Warenkorb.Rows.Count; i++)
            {
                nPreis = Convert.ToDouble(DgV_Warenkorb.Rows[i].Cells[3].Value);
                nSumme += nPreis;
            }

            LbL_Summe.Text = String.Format("{0:0.00}", nSumme) + " €";
        }

        private void CmD_Buchen_Click(object sender, EventArgs e)
        {
            OracleConnection oConnection = new OracleConnection();
            OracleCommand oCommand = new OracleCommand();
            OracleCommand oCommandUpdate = new OracleCommand();
            OracleDataReader drReader;

            int nDauerRelais = 0;
            int nResult = 0;

            string sUser = "";
            string sItem = "";
            string sAnzahl = "";
            string sEinzelpreis = "";
            string sSumme = "";

            CmD_Buchen.Enabled = false;
            CmD_InDenWarenkorb.Enabled = false;
            CmD_LöschenWarenkorb.Enabled = false;
            CmD_Logout.Enabled = false;

            try
            {
                using (oConnection)
                {
                    oConnection.ConnectionString = Frm_Haupt.sDSN;
                    oConnection.Open();

                    oCommand.Connection = oConnection;

                    for (int i = 0; i < DgV_Warenkorb.Rows.Count; i++)
                    {
                        oCommand.CommandText = Cls_Query.GetCocktailRezepte(DgV_Warenkorb.Rows[i].Cells[0].Value.ToString().Trim(), "1");
                        drReader = oCommand.ExecuteReader();

                        while (drReader.Read())
                        {
                            #region Klein Schwach
                            if (DgV_Warenkorb.Rows[i].Cells[1].Value.ToString().Trim() == "KLEIN_SCHWACH")
                            {
                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(3)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x01, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x01, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(3 + 6)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x02, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x02, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(3 + 12)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x03, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x03, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(3 + 18)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x04, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x04, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(3 + 24)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x05, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x05, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(3 + 30)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x06, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x06, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(3 + 36)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x07, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x07, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(3 + 42)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x08, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x08, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(3 + 48)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x09, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x09, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(3 + 54)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x0A, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x0A, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(3 + 60)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x0B, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x0B, 0x00 }, 0, 3);
                            }
                            #endregion
                            #region Klein Mittel
                            if (DgV_Warenkorb.Rows[i].Cells[1].Value.ToString().Trim() == "KLEIN_MITTEL")
                            {
                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(4)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x01, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x01, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(4 + 6)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x02, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x02, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(4 + 12)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x03, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x03, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(4 + 18)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x04, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x04, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(4 + 24)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x05, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x05, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(4 + 30)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x06, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x06, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(4 + 36)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x07, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x07, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(4 + 42)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x08, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x08, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(4 + 48)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x09, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x09, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(4 + 54)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x0A, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x0A, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(4 + 60)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x0B, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x0B, 0x00 }, 0, 3);
                            }
                            #endregion
                            #region Klein Stark
                            if (DgV_Warenkorb.Rows[i].Cells[1].Value.ToString().Trim() == "KLEIN_STARK")
                            {
                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(5)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x01, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x01, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(5 + 6)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x02, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x02, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(5 + 12)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x03, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x03, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(5 + 18)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x04, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x04, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(5 + 24)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x05, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x05, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(5 + 30)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x06, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x06, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(5 + 36)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x07, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x07, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(5 + 42)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x08, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x08, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(5 + 48)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x09, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x09, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(5 + 54)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x0A, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x0A, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(5 + 60)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x0B, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x0B, 0x00 }, 0, 3);
                            }
                            #endregion
                            #region Groß Schwach
                            if (DgV_Warenkorb.Rows[i].Cells[1].Value.ToString().Trim() == "GROSS_SCHWACH")
                            {
                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(6)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x01, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x01, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(6 + 6)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x02, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x02, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(6 + 12)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x03, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x03, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(6 + 18)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x04, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x04, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(6 + 24)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x05, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x05, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(6 + 30)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x06, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x06, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(6 + 36)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x07, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x07, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(6 + 42)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x08, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x08, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(6 + 48)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x09, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x09, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(6 + 54)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x0A, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x0A, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(6 + 60)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x0B, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x0B, 0x00 }, 0, 3);
                            }
                            #endregion
                            #region Groß Mittel
                            if (DgV_Warenkorb.Rows[i].Cells[1].Value.ToString().Trim() == "GROSS_MITTEL")
                            {
                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(7)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x01, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x01, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(7 + 6)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x02, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x02, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(7 + 12)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x03, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x03, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(7 + 18)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x04, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x04, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(7 + 24)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x05, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x05, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(7 + 30)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x06, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x06, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(7 + 36)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x07, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x07, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(7 + 42)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x08, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x08, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(7 + 48)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x09, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x09, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(7 + 54)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x0A, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x0A, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(7 + 60)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x0B, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x0B, 0x00 }, 0, 3);
                            }
                            #endregion
                            #region Groß Stark
                            if (DgV_Warenkorb.Rows[i].Cells[1].Value.ToString().Trim() == "GROSS_STARK")
                            {
                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(8)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x01, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x01, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(8 + 6)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x02, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x02, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(8 + 12)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x03, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x03, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(8 + 18)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x04, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x04, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(8 + 24)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x05, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x05, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(8 + 30)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x06, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x06, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(8 + 36)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x07, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x07, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(8 + 42)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x08, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x08, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(8 + 48)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x09, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x09, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(8 + 54)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x0A, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x0A, 0x00 }, 0, 3);

                                nDauerRelais = Convert.ToInt32(Convert.ToDouble(drReader.GetValue(8 + 60)) * 1000);
                                _serialPort.Write(new byte[] { 0xFF, 0x0B, 0x01 }, 0, 3);
                                Thread.Sleep(nDauerRelais);
                                _serialPort.Write(new byte[] { 0xFF, 0x0B, 0x00 }, 0, 3);
                            }
                            #endregion
                        }
                        drReader.Close();

                        sUser = LbL_User.Text.Trim();
                        sItem = DgV_Warenkorb.Rows[i].Cells[0].Value.ToString().Trim();
                        sAnzahl = "1";
                        sEinzelpreis = DgV_Warenkorb.Rows[i].Cells[2].Value.ToString().Trim();
                        sSumme = DgV_Warenkorb.Rows[i].Cells[3].Value.ToString().Trim();

                        oCommandUpdate.Connection = oConnection;
                        oCommandUpdate.CommandText = Cls_Query.InsertHistory(sUser, sItem, sAnzahl, sEinzelpreis, sSumme);
                        nResult = oCommandUpdate.ExecuteNonQuery();

                        if (nResult > 0)
                        {
                            nResult = 0;
                            oCommandUpdate.CommandText = Cls_Query.UpdateUserBudget(sUser, sSumme);
                            nResult = oCommandUpdate.ExecuteNonQuery();
                        }

                        MessageBox.Show("Cocktail fertig bitte entnehmen!\nFalls gewählt wird nach Bestätigung der nächste\nCocktail gemixt.");
                    }

                    oConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CmD_Buchen_Click");
            }

            CmD_Buchen.Enabled = true;
            CmD_InDenWarenkorb.Enabled = true;
            CmD_LöschenWarenkorb.Enabled = true;
            CmD_Logout.Enabled = true;

            this.Close();
        }

    }
}
