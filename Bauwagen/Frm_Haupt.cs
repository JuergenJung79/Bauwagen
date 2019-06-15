using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Bauwagen
{
    public partial class Frm_Haupt : Form
    {
        public static string sDSN = "";
        public static string sSchema = "";
        public static string sDatabase = "";
        public static string sListenerPort = "";

        public static int nAnzahlAnwender = 0;
        public static int nAnzahlGüter = 0;

        public Frm_Haupt()
        {
            InitializeComponent();
        }

        private void Frm_Haupt_Load(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Settings.xml");

            XmlNode nodeSchema = doc.SelectSingleNode("/Database/Schema");
            sSchema = nodeSchema.FirstChild.Value;
            XmlNode nodeDatabase = doc.SelectSingleNode("/Database/Adress");
            sDatabase = nodeDatabase.FirstChild.Value;
            XmlNode nodeListener = doc.SelectSingleNode("/Database/ListenerPort");
            sListenerPort = nodeListener.FirstChild.Value;

            sDSN = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=" + sDatabase + ")(PORT=" + sListenerPort + ")))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id="+ sSchema + "; Password=bauwagen;";

            LbL_Summe.Text = "0,00 €";

            CreateButtons();
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

            int nAnzahlButtonsNamen = 0;
            int nAnzahlButtonsGüter = 0;

            using (oConnection)
            {
                oConnection.ConnectionString = sDSN;
                oConnection.Open();

                #region Buttons für User erstellen
                oCommand.Connection = oConnection;
                oCommand.CommandText = Cls_Query.GetMaxAnderID();
                drReader = oCommand.ExecuteReader();

                while (drReader.Read())
                {
                    nAnzahlButtonsNamen = Convert.ToInt32(drReader.GetValue(0));
                }
                drReader.Close();

                System.Windows.Forms.Button[] ButtonNamen = new System.Windows.Forms.Button[nAnzahlButtonsNamen];

                oCommand.CommandText = Cls_Query.GetAnwenderDaten("");
                drReader = oCommand.ExecuteReader();

                while (drReader.Read())
                {
                    ButtonNamen[a] = new Button();

                    ButtonNamen[a].Height = 70;
                    ButtonNamen[a].Width = 120;

                    nLocationY = (5 + ButtonNamen[a].Height) * (a - nOffset) + nOffsetY;
                    nLocationX = (12 + ButtonNamen[a].Width) * nSpalte + nOffsetX;

                    ButtonNamen[a].Location = new Point(nLocationX, nLocationY);
                    ButtonNamen[a].Name = "CmD_Anwender_" + a.ToString().PadLeft(2, '0');
                    ButtonNamen[a].Text = drReader.GetValue(1).ToString().Trim() + " " + drReader.GetValue(2).ToString().Trim();
                    ButtonNamen[a].Tag = drReader.GetValue(6).ToString().Trim();
                    ButtonNamen[a].Font = new Font("Microsoft Sans Serif", 14.25f);
                    ButtonNamen[a].Click += new EventHandler(buttonNamen_Clicked);

                    FlW_Anwender.Controls.Add(ButtonNamen[a]);

                    if (Convert.ToInt32(drReader.GetValue(5)) == 1 | Convert.ToInt32(drReader.GetValue(6)) > 5) { ButtonNamen[a].Enabled = false; }

                    if (nLocationY > 550) { nOffset = a + 1; nSpalte += 1; }
                    a++;
                }

                nAnzahlAnwender = a;
                #endregion

                #region Buttons für Verbrauchsgüter erstellen
                nSpalte = 6;
                nOffset = 0;

                oCommand.Connection = oConnection;
                oCommand.CommandText = Cls_Query.GetMaxGüterID();
                drReader = oCommand.ExecuteReader();

                while (drReader.Read())
                {
                    nAnzahlButtonsGüter = Convert.ToInt32(drReader.GetValue(0));
                }
                drReader.Close();

                System.Windows.Forms.Button[] ButtonGüter = new System.Windows.Forms.Button[nAnzahlButtonsGüter];

                oCommand.CommandText = Cls_Query.GetGüterDaten("");
                drReader = oCommand.ExecuteReader();

                while (drReader.Read())
                {
                    ButtonGüter[b] = new Button();

                    ButtonGüter[b].Height = 70;
                    ButtonGüter[b].Width = 120;

                    nLocationY = (5 + ButtonGüter[b].Height) * (b - nOffset) + nOffsetY;
                    nLocationX = (12 + ButtonGüter[b].Width) * nSpalte + nOffsetX;

                    ButtonGüter[b].Location = new Point(nLocationX, nLocationY);
                    ButtonGüter[b].Name = "CmD_Gueter_" + b.ToString().PadLeft(2, '0'); ;
                    ButtonGüter[b].Text = drReader.GetValue(0).ToString().Trim();
                    ButtonGüter[b].Tag = drReader.GetValue(0).ToString().Trim();
                    ButtonGüter[b].Font = new Font("Microsoft Sans Serif", 14.25f);
                    ButtonGüter[b].Click += new EventHandler(buttonGüter_Clicked);

                    FlW_Verbrauchsgüter.Controls.Add(ButtonGüter[b]);

                    ButtonGüter[b].Enabled = false;

                    if (nLocationY > 550) { nOffset = b + 1; nSpalte += 1; }

                    b++;
                }

                nAnzahlGüter = b;
                #endregion

                oConnection.Close();
            }
        }

        private void buttonNamen_Clicked(object sender, EventArgs e)
        {
            Button angeklickterButton = (Button)sender;

            Frm_Login frm_login = new Frm_Login();

            frm_login.LbL_Status.Text = "user";
            frm_login.LbL_Username.Text = angeklickterButton.Text;

            if (frm_login.ShowDialog() == DialogResult.OK)
            {
                EnableGüter();
            }
            else
            {
                DisableGüter();
            }
        }

        private void buttonGüter_Clicked(object sender, EventArgs e)
        {
            OracleConnection oConnection = new OracleConnection();
            OracleCommand oCommandSelect = new OracleCommand();
            OracleDataReader drReader;

            Button angeklickterButton = (Button)sender;

            string sItem = angeklickterButton.Text;

            int nAnzahl = 0;
            int nIndex = 0;

            bool bFound = false;

            double nPreis = 0;
            double nSumme = 0;
            double nWarenkorbSumme = 0;

            angeklickterButton.Enabled = false;

            using (oConnection)
            {
                try
                {
                    oConnection.ConnectionString = sDSN;
                    oConnection.Open();

                    oCommandSelect.Connection = oConnection;
                    oCommandSelect.CommandText = Cls_Query.GetGüterDaten(sItem);
                    drReader = oCommandSelect.ExecuteReader();

                    while (drReader.Read())
                    {
                        for (int i = 0; i < DgV_Warenkorb.Rows.Count; i++)
                        {
                            if (sItem == DgV_Warenkorb.Rows[i].Cells[0].Value.ToString().Trim())
                            {
                                nAnzahl = Convert.ToInt32(DgV_Warenkorb.Rows[i].Cells[1].Value) + 1;
                                nIndex = i;
                                bFound = true;
                            }
                        }

                        nPreis = Convert.ToDouble(drReader.GetValue(1));
                        nSumme = Math.Round(nPreis * nAnzahl, 2);
                    }
                    drReader.Close();

                    DgV_Warenkorb.AllowUserToAddRows = true;

                    if (bFound == false)
                    {
                        DataGridViewRow row = (DataGridViewRow)DgV_Warenkorb.Rows[0].Clone();
                        row.Cells[0].Value = sItem;
                        row.Cells[1].Value = 1;
                        row.Cells[2].Value = nPreis;
                        row.Cells[3].Value = nPreis;
                        DgV_Warenkorb.Rows.Add(row);
                    }
                    else
                    {
                        DgV_Warenkorb.Rows[nIndex].Cells[1].Value = nAnzahl;
                        DgV_Warenkorb.Rows[nIndex].Cells[2].Value = nPreis;
                        DgV_Warenkorb.Rows[nIndex].Cells[3].Value = nSumme;
                    }

                    for (int i = 0; i < DgV_Warenkorb.Rows.Count; i++)
                    {
                        nWarenkorbSumme += Convert.ToDouble(DgV_Warenkorb.Rows[i].Cells[3].Value);
                    }

                    LbL_Summe.Text = String.Format("{0:0.00}", nWarenkorbSumme) + " €";

                    DgV_Warenkorb.AllowUserToAddRows = false;

                    oConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "buttonGüter_Clicked");
                }
            }

            angeklickterButton.Enabled = true;
        }

        private void CmD_Logout_Click(object sender, EventArgs e)
        {
            DisableGüter();

            LbL_Summe.Text = "0,00 €";
            DgV_Warenkorb.Rows.Clear();
        }

        private void CmD_Buchen_Click(object sender, EventArgs e)
        {

        }

        private void CmD_Systemsteuerung_Click(object sender, EventArgs e)
        {
            Frm_Login frm_login = new Frm_Login();
            Frm_Admin frm_admin = new Frm_Admin();

            frm_login.LbL_Status.Text = "admin";
            if (frm_login.ShowDialog() == DialogResult.OK)
            {
                frm_admin.ShowDialog();
            }
        }

        private void EnableGüter()
        {
            for (int i = 0; i < nAnzahlAnwender; i++)
            {
                GetAnwenderControlByName("CmD_Anwender_" + i.ToString().PadLeft(2, '0')).Enabled = false;
            }

            for (int i = 0; i < nAnzahlGüter; i++)
            {
                GetGüterControlByName("CmD_Gueter_" + i.ToString().PadLeft(2, '0')).Enabled = true;
            }

            CmD_Buchen.Enabled = true;
            CmD_Logout.Enabled = true;
        }

        private void DisableGüter()
        {
            for (int i = 0; i < nAnzahlAnwender; i++)
            {
                if (Convert.ToInt32(GetAnwenderControlByName("CmD_Anwender_" + i.ToString().PadLeft(2, '0')).Tag) <= 5)
                {
                    GetAnwenderControlByName("CmD_Anwender_" + i.ToString().PadLeft(2, '0')).Enabled = true;
                }
            }

            for (int i = 0; i < nAnzahlGüter; i++)
            {
                GetGüterControlByName("CmD_Gueter_" + i.ToString().PadLeft(2, '0')).Enabled = false;
            }

            CmD_Buchen.Enabled = false;
            CmD_Logout.Enabled = false;
        }

        Control GetAnwenderControlByName(string Name)
        {
            foreach (Control c in FlW_Anwender.Controls)
                if (c.Name == Name)
                    return c;

            return null;
        }

        Control GetGüterControlByName(string Name)
        {
            foreach (Control c in FlW_Verbrauchsgüter.Controls)
                if (c.Name == Name)
                    return c;

            return null;
        }

        private void CmD_Buchen_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Das ist ein Test");
        }
    }
}
