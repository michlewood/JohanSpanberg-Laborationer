using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_9___TicTacToe
{
    class Board : Node, IGrid
    {


        public Node[,] NodeGenerator()
        {
            var nodeOne = new Node { Player = '1' };
            var nodeTwo = new Node { Player = '2' };
            var nodeThree = new Node { Player = '3' };
            var nodeFour = new Node { Player = '4' };
            var nodeFive = new Node { Player = '5' };
            var nodeSix = new Node { Player = '6' };
            var nodeSeven = new Node { Player = '7' };
            var nodeEight = new Node { Player = '8' };
            var nodeNine = new Node { Player = '9' };

            Node[,] playerNodes = new Node[,] { { nodeOne, nodeTwo, nodeThree },
                                        { nodeFour, nodeFive, nodeSix },
                                        { nodeSeven, nodeEight, nodeNine }


        };
            return playerNodes;


        }

        public void PlayerBoard(Node[,] playerNodes)
        {
            Console.WriteLine("┏━━━┳━━━┳━━━┓");
            Console.WriteLine("┃ {0} ┃ {1} ┃ {2} ┃", playerNodes[0, 0].Player, playerNodes[0, 1].Player, playerNodes[0, 2].Player);
            Console.WriteLine("┣━━━╋━━━╋━━━┫");
            Console.WriteLine("┃ {0} ┃ {1} ┃ {2} ┃", playerNodes[1, 0].Player, playerNodes[1, 1].Player, playerNodes[1, 2].Player);
            Console.WriteLine("┣━━━╋━━━╋━━━┫");
            Console.WriteLine("┃ {0} ┃ {1} ┃ {2} ┃", playerNodes[2, 0].Player, playerNodes[2, 1].Player, playerNodes[2, 2].Player);
            Console.WriteLine("┗━━━┻━━━┻━━━┛");
        }


        public void PlaceMarker(int row, int col, int player, Node[,] playerNodes, Runtime runtime)
        {
            if (runtime.Player == 'X')
            {
                playerNodes[row, col].Player = 'X';

            }
            else
            {
                playerNodes[row, col].Player = 'O';
            }
        }
        public void ResetPlayerNodes(Node[,] playerNodes)
        {
            playerNodes[0, 0].Player = '1';
            playerNodes[0, 1].Player = '2';
            playerNodes[0, 2].Player = '3';
            playerNodes[1, 0].Player = '4';
            playerNodes[1, 1].Player = '5';
            playerNodes[1, 2].Player = '6';
            playerNodes[2, 0].Player = '7';
            playerNodes[2, 1].Player = '8';
            playerNodes[2, 2].Player = '9';
        }
    }
}
