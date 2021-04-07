using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplePrograms
{       /*  Cross Game or Tic-Tac-Toe Game 
            a. Desc: - Write a Program to play a Cross Game or Tic-Tac-Toe Game. Player 1 is the 
               Computer and the Player 2 is the user. Player 1 take Random Cell that is the Column and Row.
            b. I/P: - Take User Input for the Cell i.e., Col and Row to Mark the ‘X’ 
            c. Logic: - The User or the Computer can only take the unoccupied cell. The Game is 
               played till either wins or till draw... 
            d. O/P: - Print the Col and the Cell after every step. 
            e. Hint: - The Hints is provided in the Logic. Use Fu

        */

    /*
     TC1 Draw board using loop
    TC 2 Get input user row and col*/
    class TicTacToe
    {
        public static void TicTacToeGame() // Draw board
        {
            
            char User = 'X';
            char[,] board = new char[3, 3];

            InitiliseBoard(board);     // calling InitiliseBoard method
            int MovesPlay = 0;

            while (true)   //Game Play until winner,lose,draw
            {

                Console.Clear(); // clear screen 

                Print(board);  // calling print method

                Console.Write("Please Enter Rows:- ");
                int row = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please Enter Column:- ");
                int col = Convert.ToInt32(Console.ReadLine());
                board[row, col] = User;

                if (User == board[0, 0] && User == board[0, 1] && User == board[0, 2])       //Cheack if we Won 
                {
                    Console.WriteLine("User Win Game");
                    break;
                    //GameEnd = true;
                    //Console.ReadKey();//pressed key is displayed in the console window
                }
                MovesPlay = MovesPlay + 1;

                if (MovesPlay == 9)       // no winner is show draw
                {
                    Console.WriteLine("Game Draw");
                    break;

                }

                User = ChangeTurns(User); // calling method

            }
        }
        static char ChangeTurns(char CurrentUser)  //ChangeTurns Method
        {
            if (CurrentUser == 'X')
            {
                return 'O';

            }
            else
            {
                return 'X';
            }
        }
        static void InitiliseBoard(char[,] board)
        {
            for (int row = 0; row < 3; row++)   // initialize row board
            {
                for (int col = 0; col < 3; col++)  //initialize col board
                {
                    board[row, col] = ' ';
                }

            }
        }
        static void Print(char[,] board)
        {
            Console.WriteLine("*** TicTacToe Game *** ");

            Console.WriteLine("  | 0  | 1  | 2  |");  // Position print 
            for (int row = 0; row < 3; row++)       //print board row 3 times
            {
                Console.Write(row + " | ");            //print space 
                for (int col = 0; col < 3; col++)           // print col 3 times
                {
                    Console.Write(board[row, col]);
                    Console.Write("  | ");
                }
                Console.WriteLine();
            }
        }
    }
}

