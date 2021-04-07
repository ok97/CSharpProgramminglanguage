using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplePrograms
{       /*  Factors
            a. Desc: - Compute the prime factorization of N using brute force.
            b. I/P: - Number to find the prime factors
            c. Logic: - Traverse till i*i<=N instead of i<=N for efficiency
            d. O/P: - Print the prime factor of number N.
        */
    class PrimeFactorization
    {
        public void ReadInput()
        {
            Console.Write("Enter a Number :- "); //Take input from User
            string input = Console.ReadLine();
            int num1 = Convert.ToInt32(input); //convert from string into int 
            Prime(num1);   //calling Prime method 

        }
        private void Prime(int num1 )
        {
            int i;
            
            for (i = 2; num1 > 1; i++)
            if (num1 % i == 0)  //  number of 2s that divide n 
                {
                
                while (num1 % i == 0) // While i divides n, print i and divide n
                {
                    num1 /= i;
                }
                Console.WriteLine($"{i} is a prime Factor");        //Display Prime Factors
            }
        }
    }
}
