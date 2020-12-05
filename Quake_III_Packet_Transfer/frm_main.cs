/************************************************************************************
___________________________Quake_III_Packet_Transfer__________________________******
***********************************************************************************
**
** - Name        : frm_main.cs Code
** - Description : simple .net app to send udp packet with IDTech 3 Header 
**                    and print recv message if any
** - Author      : Hosseinpourziyaie
** - Note        : -----------------
** - Started on  : N/A        | Ended on : N/A
**
** 
**
************************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Net;
using System.Net.Sockets;

namespace Quake_III_Packet_Transfer
{
    public partial class frm_main : Form
    {
        Thread PacketSendThread;
        string OOBHeader = "\xff\xff\xff\xff";

        public frm_main()
        {
            InitializeComponent();
        }
        private void frm_main_Load(object sender, EventArgs e)
        {
            if (File.Exists("Quake_III_Packet_Transfer.ini"))
            {
                try
                {
                    StreamReader reader = new StreamReader("Quake_III_Packet_Transfer.ini");
                    this.txt_address.Text = reader.ReadLine();
                    this.txt_data.Text = reader.ReadLine();
                    reader.Close();
                }
                catch (Exception)
                {
                    //throw;
                }
            }
        }
        private void frm_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                PacketSendThread.Abort();
            }
            catch (Exception)
            {

            }
            using (StreamWriter writer = new StreamWriter("Quake_III_Packet_Transfer.ini"))
            {
                writer.WriteLine(this.txt_address.Text);
                writer.WriteLine(this.txt_data.Text);
                writer.Close();
            }
        }

        public void SetResponseText(string text)
        {
            this.Invoke(new MethodInvoker(delegate() { rtxt_serverresponse.Text = text; }));
            // Invoke((Action)(() => { notifyIcon.ShowBalloonTip(3, caption, text, ToolTipIcon.Info); }));
        }
        public void ShowMessage(string text, string caption)
        {
            MessageBox.Show(text, caption);
            this.Invoke(new MethodInvoker(delegate() { notifyIcon.ShowBalloonTip(3, caption, text, ToolTipIcon.Info); }));
            // Invoke((Action)(() => { notifyIcon.ShowBalloonTip(3, caption, text, ToolTipIcon.Info); }));
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            string[] explode = this.txt_address.Text.Split(':');

            if (explode.Length < 2 || !Utils.Validate_IP(explode[0]) || !Utils.Validate_Port(explode[1])/*explode[0].Length == 0 || explode[1].Length == 0*/)
            {
                notifyIcon.ShowBalloonTip(3, "Quake_III_Packet_Transfer", "[ ERROR ] something wrong with server address you entered", ToolTipIcon.Error);
                //MessageBox.Show("[ ERROR ] something wrong with server address you entered", "Quake_III_Packet_Transfer");
                rtxt_serverresponse.Text = "[ ERROR ] something wrong with server address you entered";
                return;
            }

            PacketSendThread = new Thread(new ThreadStart(Quake_III_Packet));
            PacketSendThread.Start();
        }

        private void Quake_III_Packet()
        {
            string[] explode = this.txt_address.Text.Split(':');

            //Send_Quake_III_Packet(explode[0], int.Parse(explode[1]), txt_data.Text);
            //rtxt_serverresponse.Text = Send_Quake_III_Packet(txt_ip.Text, int.Parse(this.txt_port.Text), txt_data.Text);

            SetResponseText(Send_Quake_III_Packet(explode[0], int.Parse(explode[1]), txt_data.Text));
        }

        private string Send_Quake_III_Packet(string ipAddress, int port, string data)
        {
            try
            {
                IPEndPoint _ip = new IPEndPoint(IPAddress.Parse(ipAddress), port);
                byte[] status_pac;

                status_pac = char2byte((OOBHeader + data).ToCharArray());

                UdpClient _udp = new UdpClient();
                _udp.Client.ReceiveTimeout = 2000;
                _udp.Client.SendTimeout = 2000;

                _udp.Connect(_ip);

                int now = Environment.TickCount;
                _udp.Send(status_pac, status_pac.Length);

                byte[] Rdata = _udp.Receive(ref _ip);

                _udp.Close();

                string Sdata = ASCIIEncoding.ASCII.GetString(Rdata);

                return Sdata;
            }
            catch (Exception ex)
            {
                return "[ ERROR ] something went wrong with transferring packet:\n" + ex;

                //throw;
            }    
        }

        private static byte[] char2byte(char[] chr)
        {
            byte[] b = new byte[chr.Length];
            for (int i = 0; i < chr.Length; i++)
                b[i] = (byte)chr[i];
            return b;
        }
    }
}