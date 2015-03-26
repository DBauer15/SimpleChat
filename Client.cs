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
using System.Threading;
using System.IO;

namespace SimpleChat
{
    public partial class Client : Form
    {
        string IP, nickname;
        int port;

        TcpClient client;
        NetworkStream stream;
        byte[] data;
        int length;

        string toPrint = "";
        Thread receiverThread;

        private delegate void CloseMe();
        private CloseMe closeMe;

        bool lostConnection = false;
        bool showNotify = false;

        Color cRemoteMsg, cLocalMsg, cWhisper, cSystem;

        public Client()
        {
            InitializeComponent();

            #region Some other Init-work
            cRemoteMsg = Color.FromArgb(186, 121, 37);
            cLocalMsg = Color.FromArgb(240, 172, 55);
            cWhisper = Color.FromArgb(255, 128, 255);
            cSystem = Color.FromArgb(255, 255, 0);
            panel1.BackColor = Color.FromArgb(70, 70, 70);
            userList.BackColor = Color.FromArgb(70, 70, 70);
            this.t_message.KeyDown += new KeyEventHandler(Client_KeyDown);
            this.AcceptButton = this.btn_send;
            closeMe = new CloseMe(delegate { this.Close(); });
            #endregion
        }

        #region Initialization
        public void OverloadValues(string nickname, string IP, int port)
        {
            this.nickname = nickname;
            this.IP = IP;
            this.port = port;

            if (nickname == "[ADMIN]" && IP != "127.0.0.1" && IP != "localhost")
            {
                MessageBox.Show("Only the one hosting the server can log in as [ADMIN]");
                this.Close();
            }
            else if (nickname.IndexOf(' ') != -1)
            {
                MessageBox.Show("The nickname must not contain spaces!");
                this.Close();
            }
            else
            {
                if (!InitConnection())
                    this.Close();
                else
                {
                    if (nickname == "[ADMIN]")
                        btn_kick.Enabled = true;

                    this.Text = "Connected as " + nickname + " @ " + IP + ":" + port;

                    receiverThread = new Thread(ReceiveMessages);
                    receiverThread.IsBackground = true;

                    receiverThread.Start();
                }
            }
        }

        private bool InitConnection()
        {
            try
            {
                client = new TcpClient(IP, port);
                stream = client.GetStream();
            }
            catch (SocketException)
            {
                MessageBox.Show("Could not connect to the server!");
                return false;
            }
            catch (Exception)
            {
                MessageBox.Show("An unknown error occured!");
                return false;
            }


            try
            {
                data = new byte[1024];

                data = Encoding.Default.GetBytes(nickname);
                stream.Write(data, 0, data.Length);
            }
            catch (Exception)
            {
                MessageBox.Show("Es ist ein Fehler aufgetreten.");
                return false;
            }

            return true;
        }
        #endregion

        private void ReceiveMessages()
        {
            while (true)
            {
                data = new byte[1024];
                length = 0;

                try
                {
                    length = stream.Read(data, 0, data.Length);
                }
                catch (IOException)
                {
                    MessageBox.Show("There was a problem with your connection.\nThe client will be closed.");
                    lostConnection = true;
                    this.Invoke(closeMe);
                }
                if (length == 0)
                    continue;

                toPrint += Encoding.Default.GetString(data).Trim(new char[] { (char)0 }) + "\r\n";
            }
        }
         
        #region User Sending
        private void SendData()
        {
            if (t_message.Text.Length > 0)
            {
                if (t_message.Text == ".quit")
                    this.Close();
                else
                {
                    
                    string message = t_message.Text;

                    if (message.IndexOf("\r\n") != -1)
                        message = message.Replace("\r\n", "´");

                    message += "\r\n";
                    stream.Write(Encoding.Default.GetBytes(message), 0, message.Length);
                }
                t_message.Text = "";
            }

            userList.SelectedIndex = -1;
        }
        private void SendData(string message)
        {
            if (message.Length > 0)
            {
                message += "\r\n";
                stream.Write(Encoding.Default.GetBytes(message), 0, message.Length);
            }

            userList.SelectedIndex = -1;
        }
        #endregion

        #region Parsing & Printing messages
        private void timer1_Tick(object sender, EventArgs e)
        {
            string[] toPrintLines = toPrint.Split(new char [] {'\r', '\n'});
            toPrint = "";

            for (int i = 0; i < toPrintLines.Length; i++)
            {
                showNotify = false;

                if (toPrintLines[i].Length > 0)
                {
                    toPrintLines[i] = toPrintLines[i].Replace("´", "\r\n");

                    if (!ParseMessage(ref toPrintLines[i]))
                    {
                        if (this.WindowState == FormWindowState.Minimized)
                            showNotify = true;

                        if (toPrintLines[i].IndexOf('<') > -1)
                        {
                            if (toPrintLines[i].Substring(toPrintLines[i].IndexOf('<') + 1, toPrintLines[i].IndexOf('>') - toPrintLines[i].IndexOf('<') - 1) == nickname)
                                t_main.AppendText(toPrintLines[i] + "\r\n", cLocalMsg);
                            else
                                t_main.AppendText(toPrintLines[i] + "\r\n", cRemoteMsg);
                        }
                        else
                            t_main.AppendText(toPrintLines[i] + "\r\n", cSystem);

                        t_main.SelectionStart = t_main.Text.Length;
                        t_main.ScrollToCaret();
                    }

                    if (showNotify)
                        chatNotify.ShowBalloonTip(2000, "SimpleChat - New Message", toPrintLines[i], ToolTipIcon.Info);
                }

            }
        }

        private bool ParseMessage(ref string message)
        {
            switch (message.Substring(0, 1))
            {
                case "/":
                    if (this.WindowState == FormWindowState.Minimized)
                        showNotify = true;
                    message = "[" + message.Substring(1, message.IndexOf(' ', message.IndexOf(' ') + 1) - 1) + "] " + message.Substring(message.IndexOf(' ', message.IndexOf(' ') + 1) + 1) + "\r\n";
                    t_main.AppendText(message, cWhisper);
                    t_main.SelectionStart = t_main.Text.Length;
                    t_main.ScrollToCaret();
                    return true;

                case ".":
                    if (message.Substring(0, 3) == ".!#")
                    {
                        if (message.Substring(3, 1) == "+")
                            userList.Items.Add(message.Substring(4));
                        else if (message.Substring(3, 1) == "-")
                            userList.Items.Remove(message.Substring(4));
                        else if (message.Substring(3, 1) == "k")
                        {
                            MessageBox.Show("You got kicked by the ADMIN!");
                            lostConnection = true;
                            this.Close();
                        }
                    }
                    return true;
            }

            return false;
        }
        #endregion

        #region Eventhandler methods
        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (receiverThread != null)
                receiverThread.Abort();

            if (stream != null)
            {
                if (!lostConnection)
                    stream.Write(Encoding.Default.GetBytes(".quit"), 0, (".quit").Length);
                stream.Close();
            }

            if (client != null)
                client.Close();

            chatNotify.Dispose();
        }

        private void t_main_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(e.LinkText);
            }
            catch (Win32Exception)
            {
                MessageBox.Show("Der Link konnte nicht geöffnet werden!");
            }
            finally
            {
                t_message.Focus();
            }
        }

        private void btn_whisper_Click(object sender, EventArgs e)
        {
            if (userList.SelectedIndex > -1)
            {
                t_message.Text = "/" + userList.SelectedItem + " ";
                userList.SelectedIndex = -1;
            }

        }

        private void btn_kick_Clicked(object sender, EventArgs e)
        {
            if (userList.SelectedIndex > -1)
                SendData(".kick " + userList.SelectedItem);
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click the whisper button, double click a name in the list\nor use the command '/<name>' to whisper to a specific user.\nType '.quit' or just close the window to leave the chat.\nIf you are logged in as the admin you also have\naccess to the KICK button and '.kick <name>' kick command.", "Info");
        }

        private void userList_DoubleClick(object sender, EventArgs e)
        {
            if (userList.SelectedIndex > -1)
                t_message.Text = "/" + userList.SelectedItem + " ";
        }

        private void chatNotify_BalloonTipClicked(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            SendData();
        }

        private void Client_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                SendData();
            }
        }
        #endregion
    }
}
