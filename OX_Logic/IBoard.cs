using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace OX_Logic
{
    interface IBoard
    {
        public Task<bool> PutMark(char player, Point where);
        public Task<bool> AddPlayer(IPlayer player);
        public Task<char> GetBoard();
        
    }
}
