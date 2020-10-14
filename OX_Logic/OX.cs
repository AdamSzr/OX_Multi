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
    class OX
    {
        public Tuple<IPlayer, IPlayer> Gamers;
        public IBoard board;


        public Task<bool> IsGameEnd()
        {
            return Task.FromResult(true);
        }



    }
}
