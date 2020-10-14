using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace OX_Logic
{
    class Player:IPlayer
    {
        Socket Socket;

        bool playerSygnature;

        public Player(Socket socket, bool playerSygnature)
        {
            Socket = socket;
            this.playerSygnature = playerSygnature;
        }

        public Task Disconnect()
        {
            this.Socket.Shutdown(SocketShutdown.Both);
            this.Socket.Disconnect(true);
            return Task.CompletedTask;
        }

        public Point GetMove()
        {
            Console.WriteLine("Put mark on position [XY] \r\nWrite 2 dig num 00/22 max");
            int value = int.Parse(Console.ReadLine());
            return new Point(value % 10, value / 10);
        }
    }
}
