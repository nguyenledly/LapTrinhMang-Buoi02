using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace Bai01_Server
{
    public partial class Form1 : Form
    {
        Socket newsock;
        Socket client;
        IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 9050);
        IPEndPoint clientep;
        byte[] nhan;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            newsock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            newsock.Bind(ipep);
            newsock.Listen(4);
            client = newsock.Accept();
            clientep = (IPEndPoint)client.RemoteEndPoint;
            txtClientIP.Text = clientep.Address.ToString();
        }

        private void lBoxMessage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            nhan = new byte[1024 * 24];
            int rec = client.Receive(nhan);
            string stringData = Encoding.UTF8.GetString(nhan, 0, rec);
            string sgui = ("CLIENT: " + stringData);
            lBoxMessage.Items.Add(sgui);
            byte[] gui = Encoding.UTF8.GetBytes(txtMessage.Text);
            client.Send(gui, gui.Length, SocketFlags.None);
            string stringGui = ("SERVER: " + txtMessage.Text);
            lBoxMessage.Items.Add(stringGui);
            txtMessage.Clear();
        }

        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            newsock.Close();
        }
    }
}
