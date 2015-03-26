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
    public partial class Server : Form
    {
        int port;
        string greeting;

        List<ChatUser> users;

        Thread listnerThread;
        Thread providerThread;
        TcpListener listener;

        List<string> messages;

        string infos;
        object locker = new object();

        public Server()
        {
            InitializeComponent();
        }

        public void OverloadValues(int port, string greeting)
        {
            this.port = port;
            this.greeting = greeting;
            users = new List<ChatUser>();
            infos = "";
            messages = new List<string>();


            this.Text = "Server listening @ Port " + port;

            listnerThread = new Thread(ListenForClients);
            listnerThread.IsBackground = true;
            providerThread = new Thread(ProvideMessages);
            providerThread.IsBackground = true;

            listnerThread.Start();
            providerThread.Start();

            infos += "Server started...\r\n";

            this.WindowState = FormWindowState.Minimized;
        }

        #region Retrieving, Parsing and Forwarding messages
        private void ProvideMessages()
        {
            int mlength = 0;
            byte[] data = new byte[1024];

            string datePrefix, currentMessage;


            while (true)
            {
                #region Get data from all clients
                for (int i = 0; i < users.Count; i++)
                {
                    if (users[i].Stream != null && users[i].Stream.DataAvailable)
                    {
                        mlength = 0;
                        data = new byte[1024];
                        currentMessage = "";

                        mlength = users[i].Stream.Read(data, 0, data.Length);

                        if (mlength == 0)
                            continue;

                        currentMessage = Encoding.Default.GetString(data).Trim(new char[] { (char)0 });
                        if (!ParseMessage(currentMessage, users[i].Nickname))
                        {
                            messages.Add("<" + users[i].Nickname + ">   " + Encoding.Default.GetString(data).Trim(new char[] { (char)0 }));

                            PrintToConsole(users[i].Nickname + " has posted.");
                        }
                    }
                }
                #endregion

                #region Send available messages to all clients
                if (messages.Count > 0)
                {
                    foreach (string s in messages)
                    {
                        datePrefix = "[" + DateTime.Now.ToShortTimeString() + "]";
                        PrintToAll(datePrefix + s, false);
                    }
                    messages.Clear();
                }
                #endregion

                Thread.Sleep(100);
            }
        }

        private bool UserInChat(string nickname)
        {
            foreach (ChatUser user in users)
            {
                if (user.Nickname == nickname)
                    return true;
            }

            return false;
        }

        private bool ParseMessage(string s, string sender)
        {
            switch (s.Substring(0, 1))
            {
                case "/":

                    if (s.IndexOf(' ') < 0)
                        break;

                    string nickname = s.Substring(1, s.IndexOf(' ') - 1);
                    string message = s.Substring(s.IndexOf(' ') + 1);

                    if (UserInChat(nickname))
                    {
                        PrintTo(sender, "/To " + nickname + " " + message);
                        if (nickname != sender)
                            PrintTo(nickname, "/From " + sender + " " + message);
                    }
                    else
                    {
                        PrintTo(sender, "There is no user '" + nickname + "' in this chat!");
                    }
                    return true;
                    
                case ".":

                    if (s.Length < 5)
                        break;

                    if (s.Substring(0, 5) == ".kick" && sender == "[ADMIN]" && s.IndexOf(' ') < 0)
                    {
                        for (int i = 0; i < users.Count; i++)
                        {
                            if (users[i].Nickname == s.Substring(6, s.IndexOf('\r') - 6))
                            {
                                users[i].Stream.Write(Encoding.Default.GetBytes(".!#k"), 0, (".!#k").Length);
                                RemoveUser(i);
                            }
                        }
                    }
                    else if (s.Substring(0, 5) == ".quit")
                    {
                        for (int i = 0; i < users.Count; i++)
                        {
                            if (users[i].Nickname == sender)
                                RemoveUser(i);
                        }
                    }
                    return true;
            }

            return false;
        }
        #endregion

        #region Different send, user and console management methods
        private void PrintTo(string user, string message)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Nickname == user && users[i] != null)
                {
                    try
                    {
                        users[i].Stream.Write(Encoding.Default.GetBytes(message), 0, Encoding.Default.GetBytes(message).Length);
                    }
                    catch (Exception)
                    {
                        RemoveUser(i);
                        i--; //Wenn ein Stream rausgenommen wird is ja ne Lücke - da muss man weiter hinten weitermachen.
                    }
                }
            }
        }

        private void PrintToAll(string s, bool printToConsole)
        {
            if (s != "")
            {
                for (int i = 0; i < users.Count; i++)
                {
                    if (users[i] != null)
                    {
                        try
                        {
                            users[i].Stream.Write(Encoding.Default.GetBytes(s), 0, Encoding.Default.GetBytes(s).Length);
                        }
                        catch (Exception)
                        {
                            RemoveUser(i);
                            i--; //Wenn ein Stream rausgenommen wird is ja ne Lücke - da muss man weiter hinten weitermachen.
                        }
                    }
                }

                if (printToConsole)
                    infos += s + "\r\n";
            }
        }

        private void RemoveUser(int index)
        {
            string tempNick = users[index].Nickname;

            lock (users)
            {
                users[index].Stream.Flush();
                users[index].Stream.Close();
                users.Remove(users[index]);

                PrintToAll(".!#-" + tempNick, false);
                PrintToAll("User " + tempNick + " has left the chat.\r\n", true);
            }


        }

        private void PrintToConsole(string s)
        {
            infos += s+"\r\n";
        }
        #endregion

        private void ListenForClients()
        {
            listener = new TcpListener(IPAddress.Any, port);

            listener.Start();
            
            string nickname = "";
            string realGreeting = "";

            while (true)
            {

                #region Listen
                byte[] newData = new byte[1024];
                infos += "Waiting for Client...\r\n";
                TcpClient client = listener.AcceptTcpClient();
                NetworkStream stream = client.GetStream();
                #endregion

                #region Get Username (first sent message)
                stream.Read(newData, 0, newData.Length);
                nickname = Encoding.Default.GetString(newData, 0, newData.Length).Trim(new char[] { (char)0 });
                realGreeting = greeting.Replace("#", nickname) + "\r\n";
                #endregion


                #region Send greeting und add user to list

                //Print notification that the user has joined.
                infos += "User " + nickname + " joined the chat.\r\n";
                PrintToAll("User " + nickname + " joined the chat.\r\n", false);


                //Greet the user individually
                stream.Write(Encoding.Default.GetBytes(realGreeting), 0, realGreeting.Length);

                //Notify users to update their userlist and add the new user to the local userlist
                PrintToAll(".!#+" + nickname, false);

                lock (users)
                {
                    users.Add(new ChatUser(nickname, stream));
                }

                //Submit all current users to the new user to have him add them to his empty list
                for (int i = 0; i < users.Count; i++)
                    stream.Write(Encoding.Default.GetBytes(".!#+" + users[i].Nickname + "\r\n"), 0, (".!#+" + users[i].Nickname + "\r\n").Length);

                #endregion


                Thread.Sleep(100);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string[] infoLines = infos.Split(new char[] { '\r', '\n' });
            infos = "";

            foreach (string line in infoLines)
            {
                if (line.Length > 0)
                {
                    textBox1.Text += line + "\r\n";
                    textBox1.SelectionStart = textBox1.Text.Length;
                    textBox1.ScrollToCaret();
                }
            }


        }

        #region Eventhandler methods
        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            listnerThread.Abort();
            providerThread.Abort();
            listener.Stop();
        }

        private void btn_savelog_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false);

                sw.Write(textBox1.Text);

                sw.Flush();
                sw.Close();
            }
        }
        #endregion
    }
}
