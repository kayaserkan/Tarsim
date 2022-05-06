using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace TarsimLog
{
    public partial class SettingsForm : Form
    {
        SerialPort port = new SerialPort();
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            string[] sp = SerialPort.GetPortNames();
            foreach (string port in sp)
            {
                cbPortName.Items.Add(port);
            }
            cbPortName.Text = Properties.Settings.Default.portName;
            cbBaudRate.Text = Properties.Settings.Default.baudRate.ToString();
            cbParity.Text = Properties.Settings.Default.parity;
        }

        private void btnPortKaydet_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.portName = cbPortName.Text;
            Properties.Settings.Default.baudRate = Convert.ToInt16(cbBaudRate.Text);
            Properties.Settings.Default.parity = cbParity.Text;
            if (rbR2.Checked == true)
            {
                Properties.Settings.Default.AgirlikBaslangic = 5;
                Properties.Settings.Default.AgirlikBitis = 7;
                Properties.Settings.Default.baudRate = 9600;
            }
            else
            {
                Properties.Settings.Default.AgirlikBaslangic = 29;
                Properties.Settings.Default.AgirlikBitis = 7;
                Properties.Settings.Default.baudRate = 4800;
            }
            if (rbR2.Checked == true)
            {
                Properties.Settings.Default.KesmeBaslangic = 11;
            }
            else
            {
                Properties.Settings.Default.KesmeBaslangic = 35;
            }

            Properties.Settings.Default.Save();
        }

        private void btnPcKayit_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.pcAdi = tbPcAdi.Text;
            Properties.Settings.Default.Save();
        }
    }
}
