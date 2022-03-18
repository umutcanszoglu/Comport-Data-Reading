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
using System.Threading;

namespace DataReading
{
    public partial class Form1 : Form
    {

        string[] ports = System.IO.Ports.SerialPort.GetPortNames();            // port bilgisinin tutulduğu yer

        public Form1()
        {
            InitializeComponent();

            FormClosing += Form1_FormClosing;
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialPort1_DataRecieved);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string port in ports)                              // pc ye takılı olan device ların portlarını ekle
            {
                CmbPort.Items.Add(port);
            }

            // baudrate leri yükle
            CmbBaudRate.Items.Add("300");
            CmbBaudRate.Items.Add("600");
            CmbBaudRate.Items.Add("1200");
            CmbBaudRate.Items.Add("2400");
            CmbBaudRate.Items.Add("4800");
            CmbBaudRate.Items.Add("9600");
            CmbBaudRate.Items.Add("19200");
            CmbBaudRate.Items.Add("57600");
            CmbBaudRate.Items.Add("115200");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
            }
        }

        private void SerialPort1_DataRecieved(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(30);

            string data = serialPort1.ReadLine();       // bufferdan verileri oku

            if (TxtGelen.InvokeRequired)
            {
                TxtGelen.Invoke(new MethodInvoker(delegate { TxtGelen.Text += data + "\r\n"; }));
            }
        }

        private void BtnBaglan_Click(object sender, EventArgs e)
        {
            if (BtnBaglan.Text == "Bağlan")
            {
                BtnBaglan.Text = "Bağlantıyı Kes";
                LabelBaglanti.Text = CmbPort.Text + "," + CmbBaudRate.Text + ", Hat Açık";
                serialPort1.PortName = CmbPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(CmbBaudRate.Text);
                serialPort1.Open();
            }
            else// bağlan
            {
                BtnBaglan.Text = "Bağlan";
                LabelBaglanti.Text = "Hat Kapalı";
                serialPort1.Close();
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtGelen.Clear();
        }

        private void BtnGonder_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write(TxtGiden.Text + "\n");
            }
            else
            {
                MessageBox.Show("Port kapalıyken data gönderilemez!");
            }
        }
    }
}
    

