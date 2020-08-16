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
        }

        private void Frm_CocktailAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            _serialPort.Close();
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
