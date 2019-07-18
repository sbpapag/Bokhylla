using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centraldator
{
    public partial class CentralDator : Form
    {
        private int port = 12345;
        private TcpClient client;
        private TcpListener listener;

        List<string> books = new List<string>();

        public CentralDator()
        {
            InitializeComponent();
            //StartListning();
        }

        private void btnSaveText_Click(object sender, EventArgs e)
        {
            string file = "";

            foreach (string item in books)
            {
                file += item + "\r\n";
            }

            System.IO.File.WriteAllText(@"Text.txt", file);
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            lbxCentral.Items.Clear();
            books.Clear();
        }

        private void btnDelMark_Click(object sender, EventArgs e)
        {
            int index = lbxCentral.SelectedIndex;

            if (index > -1)
            {
                books.RemoveAt(index);

                lbxCentral.Items.Clear();
                foreach (string item in books)
                {
                    lbxCentral.Items.Add(item);
                }
            }
        }
        
        private void btnServer_Click(object sender, EventArgs e)
        {
            StartListning();
            btnServer.BackColor = Color.LightYellow;
            btnServer.Text = "Väntar bokhyllan";
        }

        private async void StartListning()
        {
            listener = new TcpListener(IPAddress.Any, port);
            listener.Start();

            try
            {
                client = await listener.AcceptTcpClientAsync();
                btnServer.BackColor = Color.LightGreen;
                btnServer.Text = "Bokhyllan kopplats";
                btnDelMark.Enabled = true;
                btnDelAll.Enabled = true;
                btnSaveText.Enabled = true;

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, this.Text);
                return;
            }            

            StartReading(client);
        }

        private async void StartReading(TcpClient k)
        {
            try
            {
                byte[] indata = new byte[2048];
                int n = await k.GetStream().ReadAsync(indata, 0, indata.Length);
                string message = Encoding.Unicode.GetString(indata, 0, n);
                
                string[] separator = new string[] { " , " };
                string[] bookList = message.Split( separator, StringSplitOptions.None );

                foreach (var item in bookList)
                {
                    books.Add(item);
                    lbxCentral.Items.Add(item);                                       
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, this.Text);
                return;
            }

            StartReading(k);
        }

        
    }
}
