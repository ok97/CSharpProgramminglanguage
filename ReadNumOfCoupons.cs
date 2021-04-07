using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplePrograms
{      /* Coupon Numbers
            a. Desc: - Given N Distinct Coupon Numbers, how many random numbers do you need to 
               generate distinct coupon number? This program simulates this random process.
            b. I/P: - N Distinct Coupon Number
            c. Logic: - Repeatedly choose a random number and check whether it’s a new one
            d. O/P: - total random number needed to have all distinct numbers.
            e. Function: - Write class static function to generate random number and to process distinct coupons.
        */

    class ReadNumOfCoupons
    {
        public void ReadInput()
        {
            Console.WriteLine("Enter a number for Distinct Coupons"); // get user input
            int couponNo = Convert.ToInt32(Console.ReadLine()); // convrt int value
            FindOutRandomCount(couponNo); // calling method
        }
        private static void FindOutRandomCount(int couponNo)
        {
            int distinct = 0, count = 0;        //Declare Variables 
            bool[] isCollected = new bool[couponNo];    // isCollected[i] = true if card type i already collected
            while (distinct < couponNo)    
            {
                Random random = new Random();           // instance of the class Random
                int newRandom = Convert.ToInt32(random.Next(0, couponNo));      //Convert int and store NewRandom
                count++;                        //one more card
                if (!isCollected[newRandom]) //new card type
                {
                    distinct++;             
                    isCollected[newRandom] = true;
                }
            }
            Console.WriteLine("Total random number needed to have all distinct coupons:" + count); //Print  count
        }
    }
}

