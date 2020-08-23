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
    public partial class Frm_CocktailMixer : Form
    {
        public static int nAnzahlAnwender = 0;
        public static int nAnzahlButtonsCocktails = 0;

        public static bool bBlockRefresh = false;

        public string sButtonClicked = "";

        public Frm_CocktailMixer()
        {
            InitializeComponent();
        }

        private void Frm_CocktailMixer_Load(object sender, EventArgs e)
        {
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

            try
            {
                using (oConnection)
                {
                    oConnection.ConnectionString = Frm_Haupt.sDSN;
                    oConnection.Open();

                    #region Buttons für User erstellen
                    oCommand.Connection = oConnection;
                    oCommand.CommandText = Cls_Query.GetNumberOfCocktails();
                    drReader = oCommand.ExecuteReader();

                    while (drReader.Read())
                    {
                        nAnzahlButtonsCocktails = Convert.ToInt32(drReader.GetValue(0));
                    }
                    drReader.Close();

                    System.Windows.Forms.Button[] ButtonCocktails = new System.Windows.Forms.Button[nAnzahlButtonsCocktails];

                    oCommand.CommandText = Cls_Query.GetCocktailRezepte("");
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

                        if (Convert.ToInt32(drReader.GetValue(5)) == 1 | Convert.ToInt32(drReader.GetValue(6)) > 5) { ButtonCocktails[a].Enabled = false; }

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
            bBlockRefresh = true;

            Button angeklickterButton = (Button)sender;

            string sName = angeklickterButton.Text.Trim();
            sButtonClicked = angeklickterButton.Name;
            
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
        }

        Control GetAnwenderControlByName(string Name)
        {
            foreach (Control c in FlW_Cocktails.Controls)
                if (c.Name == Name)
                    return c;

            return null;
        }

        private void CmD_Klein_Schawach_Click(object sender, EventArgs e)
        {
            CmD_Klein_Schwach.BackColor = Color.Green;
            CmD_klein_mittel.BackColor = Color.LightGray;
            CmD_Klein_Stark.BackColor = Color.LightGray;
            CmD_Groß_schwach.BackColor = Color.LightGray;
            CmD_Groß_mittel.BackColor = Color.LightGray;
            CmD_Groß_stark.BackColor = Color.LightGray;
        }
    }
}
