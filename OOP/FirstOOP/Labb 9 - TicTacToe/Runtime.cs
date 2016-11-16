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

        internal void Start()
        {
            var gameBoard = new Board();
            var gameResults = new GameResults();

            var playerNodes = gameBoard.NodeGenerator();

            var counter = new Counter { Threshold = 9 };
            var counterWin = new Counter { Threshold = 1 };

            string input = "";

            counterWin.ThresholdReached += (sender, e) =>
            {
                char player = 'X';

                if (Player == 'X')
                    player = 'O';

                else
                    player = 'X';

                Console.WriteLine("Congratulations {0}! You won.", player);
                gameResults.PlayAgainQuestion(
                    counter, 
                    playerNodes, 
                    gameBoard, 
                    counterWin);
            };

            counter.ThresholdReached += (sender, e) =>
            {
                counterWin.Total = 1;
                Console.WriteLine("Draw!");
                gameResults.PlayAgainQuestion(
                    counter, 
                    playerNodes, 
                    gameBoard, 
                    counterWin);
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

                    input = Console.ReadLine();

                    
                    if (input != "1" 
                        && input != "2" 
                        && input != "3" 
                        && input != "4" 
                        && input != "5" 
                        && input != "6" 
                        && input != "7" 
                        && input != "8" 
                        && input != "9")
                    {
                        Console.WriteLine("Wrong input, press <ENTER> to try again.");
                        Console.ReadLine();
                    }
                    else
                    {
                        gameErrorController = false;
                    }
                }

                char output = input[0];

                gameResults.CheckInput(
                    playerNodes, 
                    gameBoard, 
                    output, 
                    this, 
                    counter);
                gameResults.CheckWin(
                    this, 
                    playerNodes, 
                    counterWin);

                if (counterWin.Total == 1)
                {
                    counterWin.OnThresholdReached(
                        this, 
                        EventArgs.Empty);
                }

                else if (counter.Total == 9)
                {
                    counter.OnThresholdReached(
                        this, 
                        EventArgs.Empty);
                }
            }
        }
    }
}
