using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplePrograms
{       /*  Flip coin and print Percentage of Heads and Tails
            a. I/P: - The number of times to flip coin. Ensure it is positive integer.
            b. Logic: - Use Random function to get value between 0 and 1. if<0.5 then tails or heads
            c. O/P: - Percentage of Heads vs tails
        */
    class FlipCoin
    {
        public void ReadInput()
        {
            //Reading input from user 
            Console.Write("Enter the number of times the coin should be flipped :- ");
            string input = Console.ReadLine();
            //convert from string into int 
            int numbOfTimes = Convert.ToInt32(input);
            //calling Flip method 
            Flip(numbOfTimes);
        }

        private static void Flip(int numbOfTimes)    // Flip Methood
        {
           
            int Tail = 0; int Head = 0;   // initilize Veriables

            Random random = new Random();  //instance of the class Randomt

            for (int i = 1; i <= numbOfTimes; i++)
            {

                if (random.NextDouble() < 0.5) //using random function called NextDouble() to get random value range between 0 to 1
                {

                    Tail++;  //increment Tail count by 1
                    Console.WriteLine("Tail"); // Show number of time Tail
                }
                else 
                { 
                    Head++;  //incrementing Hail count by 1
                    Console.WriteLine("Head"); // Show number of time head
                }

                    
            }

            double TailPercentage = (double)Tail / numbOfTimes * 100; //Calculate  Tail Percentage
            double HeadPercentage = (double)Head / numbOfTimes * 100; // Calculate  Head Percentage

            Console.WriteLine($"Tail Came {Tail} Times and Percentage is %{TailPercentage}");  //Display  Tail Percentage
            Console.WriteLine($"Head Came {Head} Times and Percentage is %{HeadPercentage}"); // Display  Head Percentage
        }
    }
}