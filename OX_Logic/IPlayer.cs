using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OX_Logic
{
    interface IPlayer
    {
        public System.Drawing.Point GetMove();
        public Task Disconnect();

    }
}
