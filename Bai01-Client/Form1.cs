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

namespace Bai01_Client
{
    public partial class Form1 : Form
    {
        Socket client;
        IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9050);
        byte[] nhan = new byte[1024 * 24];
        string gui, stringData, stringGui, cgui;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            client.Close();
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
            txtClientIP.Text = ipep.Address.ToString();
         
        }

        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            client.Send(Encoding.ASCII.GetBytes(txtMessage.Text));
            stringGui = ("CLIENT: " + txtMessage.Text);
            lBoxMessage.Items.Add(stringGui);
            nhan = new byte[1024*24];
            int rec = client.Receive(nhan);
            stringData = Encoding.UTF8.GetString(nhan, 0, rec);
            gui = ("SERVER: " + stringData);
            lBoxMessage.Items.Add(gui);
            txtMessage.Clear();

        }
        
    }
}
