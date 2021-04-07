using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplePrograms
{   /*  Gambler
        a. Desc: - Simulates a gambler who start with $stake and place fair $1 bets untill he/she goes 
           broke (i.e., has no money) or reach $goal. Keeps track of the number of times he/she wins and the number
           of bets he/she makes. Run the experiment N times average the result and print of times out.
        b. I/P: - $Stake, $Goal and number of times.
        c. Logic: - Play till the gambler is broke or has won
        d. O/P: - Print number of wins and Percentage of win and Loss
    */
    class Gambler
    {
        public void ReadInput()
        {
            int win=0;      //total number of games won
            int loose=0;    //total number of games loose
            Console.Write("Enter Stake Amount :-");
            int Amount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Goal Amount :- ");
            int Goal = Convert.ToInt32(Console.ReadLine());
            WinLoose(Amount, Goal,win,loose);        
        }
        private void WinLoose(int Amount, int Goal,int win, int loose)
        {
            Random random = new Random();       //instance of the class Random
            if (Amount > 0) // Cheack Player ammount greter than 0
            {
                for (int i = 1; i > 0; i++)
                {
                    int randomvalue = random.Next(0, 2); //random function

                    if (randomvalue == 1) // Random generate 1
                    {
                        Amount = Amount + 1;
                        win++;

                        if (Amount == Goal)  // amount equal to goal gambler go achieve desired goal
                        {
                            Console.WriteLine($"Number of bets Player played in the Game {i}");
                            Console.WriteLine($"Player Wins {win} Times" );
                            Console.WriteLine($"Player Loose {loose} Times");
                            break;
                        }
                    }
                    else
                    {
                        if (Amount > 0)
                        {
                            Amount = Amount - 1;
                            loose++;
                        }
                    }
                }
                Console.WriteLine($"The final amount reaches the Player Goal Game {Amount}");
            }
            else
            {
                Console.WriteLine("Player Insufficient Amount Player Can't Play Game");

            }

        }
    }
}
