using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace TarsimLog
{
    public partial class WeightForm : Form
    {
        SerialPort port = new SerialPort(Properties.Settings.Default.portName.ToString());
        string[] _recordBarkod= new string[1000];
        string[] _recordValue = new string[1000];
        string[] _recordTime = new string[1000];
        int _counter = 0;
        int startByte, stopByte, kesmeBaslangic;
        DataTable dataTable= new DataTable();
        bool changed = false;
        public WeightForm()
        {
            CheckForIllegalCrossThreadCalls = false; // seri port dan hata alınmaması için kullanılan metod
            InitializeComponent();
            port.DataReceived += new SerialDataReceivedEventHandler(MyDataReceivedHandler);
        }

        private void WeightForm_Load(object sender, EventArgs e)
        {
            try
            {
                startByte = Properties.Settings.Default.AgirlikBaslangic;
                stopByte = Properties.Settings.Default.AgirlikBitis;
                kesmeBaslangic = Properties.Settings.Default.KesmeBaslangic;
                port.BaudRate = Properties.Settings.Default.baudRate;
                port.Open();
                gridViewLog.ColumnCount = 3;

                gridViewLog.Columns[0].Name = "Barkod";
                gridViewLog.Columns[1].Name = "Tartım Değeri";
                gridViewLog.Columns[2].Name = "Tarih";
                gridViewLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                tbBarkod.Focus();
            }
            catch { }   
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbBarkod.Text != "")
            {
                DateTime dt = DateTime.Now;
                _recordBarkod[_counter] = tbBarkod.Text;
                _recordValue[_counter] = lblAgirlikDegeri.Text;
                _recordTime[_counter] = dt.ToString();

                for (int i = 0; i < _counter; i++)
                {
                    if (_recordBarkod[i] == tbBarkod.Text)
                    {
                        _recordValue[i] = lblAgirlikDegeri.Text;
                        gridViewLog.Rows[i].Cells[1].Value = lblAgirlikDegeri.Text;
                        changed = true;
                        break;
                    }
                }
                if (changed != true)
                {
                    gridViewLog.Rows.Add(tbBarkod.Text, lblAgirlikDegeri.Text, dt.ToString());
                    tbBarkod.Text = "";
                    tbBarkod.Focus();
                    _counter++;
                }
                else
                {
                    changed = false;
                }
            }
            else
            {
                MessageBox.Show("Barkod Okutulmadı");
            }
        }

        private void WeightForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            port.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gridViewLog.Rows[2].Cells[1].Value = "12232343";
        }

        private void WeightForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            port.Close();
        }

        private void btnFileCreate_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dt = DateTime.Now;
                SaveFileDialog save = new SaveFileDialog();
                save.CreatePrompt = true; // dosya yoksa üret
                save.Title = "Metin Dosyaları";
                save.DefaultExt = "txt";
                save.Filter = "txt Dosyaları (*.txt)|*.txt|Tüm Dosyalar(*.*)|*.*";
                save.FileName = Properties.Settings.Default.pcAdi + dt.Day.ToString() + "-" + dt.Month.ToString() + "-" + dt.Year.ToString() + "-" + dt.Hour.ToString() + dt.Minute.ToString() + dt.Second.ToString();

                if (save.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter Kayit = new StreamWriter(save.FileName);
                    for (int i = 0; i < _counter; i++)
                    {
                        Kayit.Write(_recordBarkod[i]);
                        Kayit.Write("-");
                        Kayit.Write(_recordValue[i]);
                        Kayit.Write("-");
                        Kayit.WriteLine(_recordTime[i]);
                    }
                    Kayit.Close();
                    for (int i = 0; i < _recordBarkod.Length; i++)
                    {
                        _recordBarkod[i] = "";
                        _recordValue[i] = "";
                        _recordTime[i] = "";
                    }
                    _counter = 0;
                    gridViewLog.Rows.Clear();
                }
            }
            catch (Exception cd) 
            {
                MessageBox.Show(cd.Message);
            }
        }

        void MyDataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string Agirlik = port.ReadLine();
                string tempStr = Agirlik.Remove(kesmeBaslangic, 1);
                tempStr = tempStr.Remove(kesmeBaslangic + 1, 1);
                lblAgirlikDegeri.Text = tempStr.Substring(startByte, stopByte);
            }
            catch { }

            //lblAgirlikDegeri.Text = Agirlik.Substring(8, 7);
        }
    }
}
