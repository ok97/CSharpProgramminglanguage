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
    class poweroftwofunction
    {
        static public void PowerFunction()
        {
            Console.Write("Enter as 2^Power:- "); // Take input user
            string number = Console.ReadLine();     //store input
            int power = Convert.ToInt32(number);        //Convert string into int
            int LimitPowerTwo = 31;             
           if (power > LimitPowerTwo)               //set limit
            {
                Console.WriteLine($"You Enter {power}  of 2^ exceeds the value limit 31  ");// condition not equal to show message
            }
            else {          
                  
                  for (int i = 1; i <= power; i++)
                  {
                    Console.WriteLine($"{2}^{i} = {(long)Math.Pow(2, i)}"); //2 is base value Find power using Math.Pow
                                                                            // display power value
                }

                //double pow = Math.Pow(2, power); // 2 is base value Find power using Math.Pow
                // Console.WriteLine(pow);     

            }
        }
    }
}

