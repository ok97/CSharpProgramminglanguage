using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplePrograms
{   /*  Harmonic Number
        a. Desc: - Print the Nth Harmonic number:1/1+1/2+.......1/N
        b. I/P: - The Harmonic Value N. Ensure N! =0
        c. Logic: - compute 1/1+1/2+1/3+....1/N
        d. O/P: - Print the Nth Harmonic Value.
    */
    class Harmonic
    {
        public void ReadInput()
        {
            Console.Write("Enter a Number:- ");  // Take Input User
            string NNumber = Console.ReadLine();
            int number = Convert.ToInt32(NNumber);  //Convert input to integer
            Hnumber(number); // calling method
        }
        private static void Hnumber(int number)     //Method
        {
            
            double harmonic = 1; //identity value for
            for (int i = 2; i <= number; i++)
            {
             
               harmonic += (double)1 / i; //int int => harmonic +=1/i

            }
            
            Console.Write($"Harmonic value of {number} is {harmonic}"); //Display Value
        }
    }
}
