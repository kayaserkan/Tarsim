using System;
using System.IO.Ports;
using System.Windows.Forms;

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
            tbPcAdi.Text = Properties.Settings.Default.pcAdi;
            tbBaslangic.Text = Properties.Settings.Default.AgirlikBaslangic.ToString(); 
            tbUzunluk.Text = Properties.Settings.Default.AgirlikBitis.ToString();
            tbSeparator.Text = Properties.Settings.Default.KesmeBaslangic.ToString();

            if (Properties.Settings.Default.rb2m == true)
            {
                rbR2M.Checked = true;
            }
            else
            {
                rbR2.Checked = true;
            }
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
                Properties.Settings.Default.rb2m = false;

            }
            else if (rbR2M.Checked == true)
            {
                Properties.Settings.Default.AgirlikBaslangic = 29;
                Properties.Settings.Default.AgirlikBitis = 7;
                Properties.Settings.Default.baudRate = 4800;
                Properties.Settings.Default.rb2m = true;
            }

            else if (rbDiger.Checked == true)
            {
                Properties.Settings.Default.AgirlikBaslangic = Convert.ToInt16(tbBaslangic.Text);
                Properties.Settings.Default.AgirlikBitis = Convert.ToInt16(tbUzunluk.Text);
                Properties.Settings.Default.baudRate = Convert.ToInt16(cbBaudRate.Text);
                Properties.Settings.Default.rb2m = true;
            }


            if (rbR2.Checked == true)
            {
                Properties.Settings.Default.KesmeBaslangic = 11;
            }
            else if (rbR2M.Checked == true)
            {
                Properties.Settings.Default.KesmeBaslangic = 35;
            }
            else if (rbDiger.Checked == true)
            {
                Properties.Settings.Default.KesmeBaslangic = Convert.ToInt16(tbSeparator.Text);

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
