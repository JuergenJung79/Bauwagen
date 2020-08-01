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

namespace Bauwagen
{
    public partial class Frm_CocktailAdmin : Form
    {
        public Frm_CocktailAdmin()
        {
            InitializeComponent();
        }

        private void Frm_CocktailAdmin_Load(object sender, EventArgs e)
        {
            ClearData();
            LoadData();
        }

        private void CmD_Neu_Click(object sender, EventArgs e)
        {

        }

        private void CmD_Sichern_Click(object sender, EventArgs e)
        {

        }

        private void DgV_Cocktails_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClearData()
        {

        }

        private void LoadData()
        {

        }

    }
}
