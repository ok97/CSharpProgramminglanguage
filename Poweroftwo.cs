using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplePrograms
{   /*  Power of 2
        a. Desc: - This Program takes a command-line argument N and prints a table of the
           power of 2 that are less than or equal to 2^N.
        b. I/P: - The power value N. Only works if 0<=N<31 since 2^31 overflow an int.
        c. Logic: - Repeat until equals N.
        d. O/P: - print table
    */
    class Poweroftwo
    {
        public void ReadInput() 
        {


            Console.WriteLine("Enter as 2^Number:- "); //Reading input from user
            string NNumber = Console.ReadLine();
            int number = Convert.ToInt32(NNumber);  //convert from string into integer value
            int num = 1;
            int i = 1;              
            int LimitPowerTwo = 31;
            
            if (number > LimitPowerTwo) // Cheack number is greater than Limit 31 yes to go inner if otherwise else run
            {
                Console.WriteLine($"You Enter {number}  of 2^ exceeds the value limit 31  ");// condition not equal to show message
            }
            else
            {
                
                for (i = 1; i <= number; i++) //to Check a number 
                { 
                    num = (num * 2); // multiply number by 2
                    Console.WriteLine(num); // Display Table values
                }
            }


        }
    }
}