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

namespace Bai02_Server
{
    public partial class Form1 : Form
    {
        Socket newsock;
        Socket client;
        IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 9050);
        IPEndPoint clientep;
        byte[] nhan;
        string k = "Keo";
        string b = "Bua";
        string ba = "Bao"; 
        public Form1()
        {
            InitializeComponent();
        }
        static int XuLyKetQuaKEO(string client,string keo, string bua, string bao)
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
            byte[] gui = Encoding.UTF8.GetBytes(txtSelection.Text);
            client.Send(gui, gui.Length, SocketFlags.None);
           
        }

        private void btnBua_Click(object sender, EventArgs e)
        {
            txtSelection.Text = btnBua.Text;
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
            byte[] gui = Encoding.UTF8.GetBytes(txtSelection.Text);
            client.Send(gui, gui.Length, SocketFlags.None);
        }

        private void btnBao_Click(object sender, EventArgs e)
        {
            txtSelection.Text = btnBao.Text;
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
            byte[] gui = Encoding.UTF8.GetBytes(txtSelection.Text);
            client.Send(gui, gui.Length, SocketFlags.None);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            newsock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            newsock.Bind(ipep);
            newsock.Listen(4);
            client = newsock.Accept();
            clientep = (IPEndPoint)client.RemoteEndPoint;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            newsock.Close();
        }
    }
}
