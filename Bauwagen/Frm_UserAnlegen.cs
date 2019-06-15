using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bauwagen
{
    public partial class Frm_UserAnlegen : Form
    {
        public Frm_UserAnlegen()
        {
            InitializeComponent();
        }

        private void Frm_UserAnlegen_Load(object sender, EventArgs e)
        {

        }

        private void CmD_Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Den Vorgang wirklich beenden und alle Fenster schliesen?", "Beenden", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void CmD_Create_Click(object sender, EventArgs e)
        {

        }

    }
}
