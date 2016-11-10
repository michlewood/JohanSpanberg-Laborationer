using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_9___TicTacToe
{
    interface IGrid
    {
        void PlaceMarker(
            int row, 
            int col, 
            int player, 
            Node[,] playerNodes, 
            Runtime runtime);
    }
}
