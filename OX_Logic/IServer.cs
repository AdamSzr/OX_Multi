using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace OX_Logic
{
    interface IServer
    {
        public Task Start();
        public Task Stop();
        public Task<bool> SendBoard(Socket Client);

    }
}
