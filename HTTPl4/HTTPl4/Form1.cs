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
using System.Text.RegularExpressions;



namespace HTTPl4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SockFunc SF = new SockFunc();
        Socket Connected;
        Regex regex = new Regex(@"([0-9]{1,3}[\.]){3}[0-9]{1,3}");
       


        private void ConnectBut_Click(object sender, EventArgs e)
        {
                string ip_addr = IPA.Text;
                MatchCollection matches = regex.Matches(ip_addr);

            if (matches.Count > 0)
            {
                try
                {
                    Connected = SF.Connect(ip_addr);
                }
                catch
                {
                    MessageBox.Show("Cannot connect to the server");
                }
            }
            else
            {
                MessageBox.Show("Wrong IP");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string ip_addr = IPA.Text;
            MatchCollection matches = regex.Matches(ip_addr);
            if (!SF.IsSocketConnected(Connected) && (matches.Count > 0))
            {
                try
                {
                    Connected = SF.Connect(ip_addr);
                }
                catch
                {
                    MessageBox.Show("Cannot connect to the server");
                }
            }
            else if(matches.Count==0)
            {
                MessageBox.Show("Socket is not connected. Input correct IP");
            }

            if (SF.IsSocketConnected(Connected) && (matches.Count > 0))
            {
                string[] uRequest = UserRequests.Lines;
                byte[] data;
                //string msg = UserRequests.Text+"\r\n\r\n";
                uRequest[uRequest.Length - 1] += "\r\n";
                for (int i = 0; i < uRequest.Length; i++)
                {
                    uRequest[i] += "\r\n";
                    data = Encoding.ASCII.GetBytes(uRequest[i]);
                    if (SF.IsSocketConnected(Connected))
                    {
                        Connected.Send(data);
                    }
                    else
                    {
                        Connected = SF.Connect(ip_addr);
                        Connected.Send(data);
                    }
                }
                data = new byte[256];
                int bytes = 0;

                ServerCommunication.AppendText("\nClient:\n");
                for (int i = 0; i < uRequest.Length; i++)
                {
                    ServerCommunication.AppendText(uRequest[i]);
                }
                ServerCommunication.AppendText("Server:\n");

                do
                {
                    bytes = Connected.Receive(data, data.Length, 0);
                    ServerCommunication.AppendText(Encoding.ASCII.GetString(data, 0, bytes));
                }
                while (Connected.Available > 0);
                // ServerCommunication.Text = stringBuilder.ToString();
            }
         
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Connected.Shutdown(SocketShutdown.Both);
                Connected.Close();
            }
            catch{

            }
        }
    }
}
