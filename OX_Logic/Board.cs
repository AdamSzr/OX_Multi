using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace OX_Logic
{
    class Board : IBoard
    {
        PlayersMarks[,] fields;
        PlayersMarks lastMove;

        public Board()
        {
            this.fields = new PlayersMarks[3, 3];
        }
        public Task<PlayersMarks> GetWinner()
        {
            bool result =
                   this.fields[0, 0] == this.fields[0, 1] && this.fields[0, 1] == this.fields[0, 2] && this.fields[0, 0] != PlayersMarks.none // columns
                || this.fields[1, 0] == this.fields[1, 1] && this.fields[1, 1] == this.fields[1, 2] && this.fields[1, 0] != PlayersMarks.none
                || this.fields[2, 0] == this.fields[2, 1] && this.fields[2, 1] == this.fields[2, 2] && this.fields[2, 0] != PlayersMarks.none

                || this.fields[0, 0] == this.fields[1, 0] && this.fields[1, 0] == this.fields[2, 0] && this.fields[0, 0] != PlayersMarks.none// rows
                || this.fields[0, 1] == this.fields[1, 1] && this.fields[1, 1] == this.fields[2, 1] && this.fields[0, 1] != PlayersMarks.none
                || this.fields[0, 2] == this.fields[1, 2] && this.fields[1, 2] == this.fields[2, 2] && this.fields[0, 2] != PlayersMarks.none

                || this.fields[0, 0] == this.fields[1, 1] && this.fields[1, 1] == this.fields[2, 2] && this.fields[0, 0] != PlayersMarks.none // diagonal
                || this.fields[0, 2] == this.fields[1, 1] && this.fields[1, 1] == this.fields[2, 0] && this.fields[0, 2] != PlayersMarks.none;

            if (result)
                return Task.FromResult(this.lastMove);
            else
                return Task.FromResult(PlayersMarks.none);
        }
        public Task<bool> PutMark(PlayersMarks player, Point where)
        {
            if (this.fields[where.X, where.Y] != PlayersMarks.none)
                Task.FromResult(false);


            this.lastMove = player;
            this.fields[where.X, where.Y] = player;
            return Task.FromResult(true);

        }
        public Task Erase(Point where)
        {
            this.fields[where.X, where.Y] = PlayersMarks.none;
            return Task.CompletedTask;
        }
        public Task ResetAll()
        {
            Array.Clear(fields, 0, fields.Length);
            return  Task.CompletedTask;
        }
    }
}
