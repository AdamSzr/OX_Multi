using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace OX_Logic
{
    class Board : IBoard
    {
        public Task<bool> AddPlayer(IPlayer player)
        {
            throw new NotImplementedException();
        }

        public Task<char> GetBoard()
        {
            throw new NotImplementedException();
        }

        public Task<bool> PutMark(char player, Point where)
        {
            throw new NotImplementedException();
        }
    }
}
