using System;
using System.Net;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Web;
using System.Text.Encodings;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace OX_Logic
{
    class OX_Server : IServer
    {

        #region Server fields
        Socket socket_server;
        int counter_client;
        EndPoint ep;
        IPAddress ip;
        int port;
        bool isRunning = false;
        #endregion


        public OX_Server(string address = "127.0.0.1", int port = 99)
        {
            this.socket_server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            this.ip = IPAddress.Parse(address);
            this.port = port;
            this.ep = new IPEndPoint(this.ip, this.port);
            this.socket_server.Bind(this.ep);
            this.socket_server.Listen(10);
        }
        private void Display( string mess, string side = "Server")
        {
            string disp = $"[{side}] {mess}";
            Console.WriteLine(disp);
        }
        public async Task Start()
        {
            this.isRunning = true;
            Display("ON");

            while (isRunning)
            {
                var clinet = await this.socket_server.AcceptAsync(); // poczeka na klienta
                Display($"Accepted {clinet.RemoteEndPoint.ToString()}");


            }
        }

        public Task Stop()
        {
            this.isRunning = false;
            return Task.CompletedTask;
        }

        public Task<bool> SendBoard(Socket Client)
        {
            throw new NotImplementedException();
        }
    }
}
