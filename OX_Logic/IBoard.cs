using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace OX_Logic
{
    interface IBoard
    {
        public Task<bool> PutMark(PlayersMarks player, Point where);
        public Task Erase(Point where);
        public Task<PlayersMarks> GetWinner();
        public Task ResetAll();
    }
}
