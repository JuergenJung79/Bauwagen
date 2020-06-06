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
    public partial class Frm_Aufladen : Form
    {
        public Frm_Aufladen()
        {
            InitializeComponent();
        }

        private void Frm_Aufladen_Load(object sender, EventArgs e)
        {
            LbL_Aufladung.Text = "0,00 €";

            CmD_Plus.BackColor = Color.Green;
            CmD_Minus.BackColor = Color.Gray;

            GetUser();
        }

        private void CmD_Minus_Click(object sender, EventArgs e)
        {
            CmD_Plus.BackColor = Color.Gray;
            CmD_Minus.BackColor = Color.Green;
        }

        private void CmD_Plus_Click(object sender, EventArgs e)
        {
            CmD_Plus.BackColor = Color.Green;
            CmD_Minus.BackColor = Color.Gray;
        }

        private void CmD_NullKommaFünfzig_Click(object sender, EventArgs e)
        {
            CalculatAufladung(0.5);
        }

        private void CmD_Eins_Click(object sender, EventArgs e)
        {
            CalculatAufladung(1);
        }

        private void CmD_Zwei_Click(object sender, EventArgs e)
        {
            CalculatAufladung(2);
        }

        private void CmD_Fünf_Click(object sender, EventArgs e)
        {
            CalculatAufladung(5);
        }

        private void CmD_Zehn_Click(object sender, EventArgs e)
        {
            CalculatAufladung(10);
        }

        private void CmD_Zwanzig_Click(object sender, EventArgs e)
        {
            CalculatAufladung(20);
        }

        private void CmD_Fünfzig_Click(object sender, EventArgs e)
        {
            CalculatAufladung(50);
        }

        private void CmD_Hundert_Click(object sender, EventArgs e)
        {
            CalculatAufladung(100);
        }

        private void GetUser()
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
                    oCommand.CommandText = Cls_Query.GetAnwenderDaten("", false);
                    drReader = oCommand.ExecuteReader();

                    CmB_User.Items.Clear();
                    while (drReader.Read())
                    {
                        if (Convert.ToDouble(drReader.GetValue(6)) <= 5)
                        {
                            CmB_User.Items.Add(drReader.GetValue(1).ToString().Trim() + " " + drReader.GetValue(2).ToString().Trim());
                        }
                    }
                    drReader.Close();

                    oConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "GetUser");
                }
            }
        }

        private void CalculatAufladung(double nValue)
        {
            double nAufladung = 0;

            string sAufladung = LbL_Aufladung.Text.Trim().Substring(0, LbL_Aufladung.Text.Trim().Length - 2);

            nAufladung = Convert.ToDouble(sAufladung);

            if (CmD_Minus.BackColor == Color.Green)
            {
                nAufladung = nAufladung - nValue;
            }
            else if (CmD_Plus.BackColor == Color.Green)
            {
                nAufladung = nAufladung + nValue;
            }

            LbL_Aufladung.Text = String.Format("{0:0.00}", nAufladung) + " €";
        }

        private void CmD_Aufladen_Click(object sender, EventArgs e)
        {
            OracleConnection oConnection = new OracleConnection();
            OracleCommand oCommandUpdate = new OracleCommand();
            int nResult = 0;

            string sUser = "";
            string sBetrag = "";

            if (CmB_User.Text != "")
            {
                using (oConnection)
                {
                    try
                    {
                        oConnection.ConnectionString = Frm_Haupt.sDSN;
                        oConnection.Open();

                        sUser = CmB_User.Text.Trim();
                        sBetrag = LbL_Aufladung.Text.Trim().Replace("€"," ").Trim();

                        oCommandUpdate.Connection = oConnection;
                        oCommandUpdate.CommandText = Cls_Query.InsertAufladung(sUser, sBetrag);
                        nResult = oCommandUpdate.ExecuteNonQuery();

                        if (nResult > 0)
                        {
                            nResult = 0;
                            oCommandUpdate.CommandText = Cls_Query.UpdateUserAufladung(sUser, sBetrag);
                            nResult = oCommandUpdate.ExecuteNonQuery();
                        }

                        LbL_Aufladung.Text = "0,00 €";
                        MessageBox.Show("Aufladung erfolgreich", "Info");

                        oConnection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "CmD_Aufladen_Click");
                    }
                }
            }
            else
            {
                MessageBox.Show("Es ist kein Anwender ausgewählt", "Fehler");
            }
        }

    }
}
