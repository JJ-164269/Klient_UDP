using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace Klient_UDP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            string host = Address.Text;
            int port = Convert.ToInt32(My_Port.Value);

            try
            {
                UdpClient klient = new UdpClient(host, port);
                Byte[] dane = Encoding.ASCII.GetBytes(Message.Text);
                klient.Send(dane, dane.Length);
                Info_connect.Items.Add("Wysłanie wiadomości do hosta " + host + ": " + port);
                klient.Close();
            }
            catch (Exception ex)
            {
                Info_connect.Items.Add("Błąd: nie udało sie wysłać wiadomości!");
                MessageBox.Show(ex.ToString(), "Error!");
            }

        }
    }
}
