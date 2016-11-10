using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_9___TicTacToe
{
    class GameResults
    {
        public int Row { get; set; }
        public int Col { get; set; }

        internal void CheckInput(Node[,] playerNodes, Board gameBoard, char input, Runtime runtime, Counter counter)
        {
            ConvertInputToCoordinates(input);

            if (playerNodes[Row, Col].Player == input)
            {
                gameBoard.PlaceMarker(Row, Col, runtime.Player, playerNodes, runtime);
                counter.Add(1);
                if (runtime.Player == 'O')
                    runtime.Player = 'X';
                else
                    runtime.Player = 'O';
            }
            else
            {
                Console.WriteLine("Already taken by a player. Try again.");
                Console.ReadLine();
            }
        }

        private void ConvertInputToCoordinates(char input)
        {
            if (input == '1') { Row = 0; Col = 0; }
            else if (input == '2') { Row = 0; Col = 1; }
            else if (input == '3') { Row = 0; Col = 2; }
            else if (input == '4') { Row = 1; Col = 0; }
            else if (input == '5') { Row = 1; Col = 1; }
            else if (input == '6') { Row = 1; Col = 2; }
            else if (input == '7') { Row = 2; Col = 0; }
            else if (input == '8') { Row = 2; Col = 1; }
            else if (input == '9') { Row = 2; Col = 2; }
        }

        internal void CheckWin(Runtime runtime, Node[,] playerNodes, Counter counterWin)
        {
            char player = 'X';
            if (runtime.Player == 'O')
            {
                player = 'X';
            }
            else
            {
                player = 'O';
            }

            bool addToWin = false;

            for (int i = 0; i < 3; i++)
            {
                int col = 0;
                int row = 0;

                if (playerNodes[col, row].Player 
                    == playerNodes[col, row + 1].Player 
                    && playerNodes[col, row + 1].Player 
                    == playerNodes[col, row + 2].Player)
                {
                    addToWin = true;
                    break;
                }

                if (col == 2)
                {
                    col = 0;
                }
                col++;
            }
            for (int i = 0; i < 3; i++)
            {
                int col = 0;
                int row = 0;

                if (playerNodes[col, row].Player 
                    == playerNodes[col + 1, row].Player 
                    && playerNodes[col + 1, row].Player 
                    == playerNodes[col + 2, row].Player)
                {
                    addToWin = true;
                    break;
                }
   
                if (row == 2)
                {
                    row = 0;
                }
                row++;
            }

            if (playerNodes[0, 0].Player == playerNodes[1, 1].Player && playerNodes[1, 1].Player == playerNodes[2, 2].Player)
            {
                addToWin = true;
            }
            else if (playerNodes[2, 0].Player == playerNodes[1, 1].Player && playerNodes[1, 1].Player == playerNodes[0, 2].Player)
            {
                addToWin = true;
            }

            if (addToWin)
            {
                counterWin.Add(1);
            }
        }

        public void PlayAgainQuestion(Counter counter, Node[,] playerNodes, Board gameBoard, Counter counterWin)
        {
            while (counterWin.Total == 1)
            {
                Console.WriteLine("Do you want to play again (y/n)");
                string input = Console.ReadLine().ToLower();

                if (input == "y")
                {
                    counter.Total = 0;
                    counterWin.Total = 0;
                    Console.WriteLine("Reseting the playerfield.");
                    gameBoard.ResetPlayerNodes(playerNodes);


                }
                else if (input == "n")
                {

                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Not a valid input, try again.");
                }
            }
        }
    }
}
