using System;
using System.Drawing;
using System.Threading.Tasks;

namespace OX_Logic
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Board b = new Board();
            _ = b.PutMark(PlayersMarks.x, new Point(0, 0));
            _ = b.PutMark(PlayersMarks.x, new Point(0, 1));
            _ = b.PutMark(PlayersMarks.x, new Point(1, 1));
            Console.WriteLine(await b.GetWinner());

        }
    }
}
