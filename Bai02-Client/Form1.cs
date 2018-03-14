using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02_Client
{
    public partial class Form1 : Form
    {
        Socket client;
        IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9050);
        byte[] nhan = new byte[1024];
        string k = "Keo";
        string b = "Bua";
        string ba = "Bao";
        public Form1()
        {
            InitializeComponent();
        }
        static int XuLyKetQuaKEO(string client, string keo, string bua, string bao)
        {
            if (client == keo)
                return 0;
            else if (client == bua)
                return -1;
            return 1;
        }
        static int XuLyKetQuaBUA(string client, string keo, string bua, string bao)
        {
            if (client == bua)
                return 0;
            else if (client == bao)
                return -1;
            return 1;
        }
        static int XuLyKetQuaBAO(string client, string keo, string bua, string bao)
        {
            if (client == bao)
                return 0;
            else if (client == keo)
                return -1;
            return 1;
        }
        private void btnKeo_Click(object sender, EventArgs e)
        {
            txtSelection.Text = btnKeo.Text;
            client.Send(Encoding.ASCII.GetBytes(txtSelection.Text));
            nhan = new byte[1024];
            int rec = client.Receive(nhan);
            string stringData = Encoding.UTF8.GetString(nhan, 0, rec);
            int i = XuLyKetQuaKEO(stringData, k, b, ba);
            if (i == 0)
                txtResult.Text = "Hoa";
            else if (i == -1)
                txtResult.Text = "Thua";
            else
                txtResult.Text = "Thang";
        }

        private void btnBua_Click(object sender, EventArgs e)
        {
            txtSelection.Text = btnBua.Text;            
            client.Send(Encoding.ASCII.GetBytes(txtSelection.Text));
            nhan = new byte[1024];
            int rec = client.Receive(nhan);
            string stringData = Encoding.UTF8.GetString(nhan, 0, rec);
            int i = XuLyKetQuaBUA(stringData, k, b, ba);
            if (i == 0)
                txtResult.Text = "Hoa";
            else if (i == -1)
                txtResult.Text = "Thua";
            else
                txtResult.Text = "Thang";
        }

        private void btnBao_Click(object sender, EventArgs e)
        {
            txtSelection.Text = btnBao.Text;
            client.Send(Encoding.ASCII.GetBytes(txtSelection.Text));
            nhan = new byte[1024];
            int rec = client.Receive(nhan);
            string stringData = Encoding.UTF8.GetString(nhan, 0, rec);
            int i = XuLyKetQuaBAO(stringData, k, b, ba);
            if (i == 0)
                txtResult.Text = "Hoa";
            else if (i == -1)
                txtResult.Text = "Thua";
            else
                txtResult.Text = "Thang";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                client.Connect(ipep);
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            client.Close();
        }
    }
}
