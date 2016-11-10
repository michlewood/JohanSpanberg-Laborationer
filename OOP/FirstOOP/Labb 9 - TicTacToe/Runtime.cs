using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_9___TicTacToe
{
    class Runtime
    {
        public char Player { get; set; } = 'O';
        public bool IsWin { get; set; } = false;

        internal void Start()
        {
            var gameBoard = new Board();
            var gameResults = new GameResults();
            var playerNodes = gameBoard.NodeGenerator();

            var counter = new Counter { Threshold = 9 };

            char input = '0';

            counter.ThresholdReached += (sender, e) =>
            {
                IsWin = true;
                Console.WriteLine("Draw!");
                gameResults.PlayAgainQuestion(this, counter, playerNodes, gameBoard);
            };

            while (true)
            {

                bool gameErrorController = true;
                while (gameErrorController)
                {
                    Console.Clear();
                    gameBoard.PlayerBoard(playerNodes);

                    Console.WriteLine("");
                    Console.WriteLine("Player {0}", Player);

                    input = Convert.ToChar(Console.ReadLine());

                    /*if (input > 9 || input < 1)
                    {
                        Console.WriteLine("Wrong input, press <ENTER> to try again.");
                        Console.ReadLine();
                    }
                    else
                    {*/
                        gameErrorController = false;
                    //}
                }

                gameResults.CheckInput(playerNodes, gameBoard, input, this, counter);
                gameResults.CheckWin(this, playerNodes);

                if (IsWin == true)
                {
                    char player = 'X';

                    if (Player == 'X')
                        player = 'O';

                    else
                        player = 'X';

                    Console.WriteLine("Congratulations {0}! You won!", player);
                    gameResults.PlayAgainQuestion(this, counter, playerNodes, gameBoard);
                }

                if (counter.Total == 9 && IsWin == true)
                {
                    char player = 'X';

                    if (Player == 'X')
                        player = 'O';

                    else
                        player = 'X';

                    Console.WriteLine("Congratulations {0}! You won!", player);
                    gameResults.PlayAgainQuestion(this, counter, playerNodes, gameBoard);
                }

                else if (counter.Total == 9 && IsWin == false)
                {
                    counter.OnThresholdReached(EventArgs.Empty);
                }
            }
        }
    }
}
