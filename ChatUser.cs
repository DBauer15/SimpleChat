using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;

namespace SimpleChat
{
    class ChatUser
    {
        NetworkStream stream;
        string nickname;

        public ChatUser(string nickname, NetworkStream stream)
        {
            this.stream = stream;
            this.nickname = nickname;
        }

        public NetworkStream Stream
        {
            get { return stream; }
        }

        public string Nickname
        {
            get { return nickname; }
        }
    }
}
