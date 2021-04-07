using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplePrograms
{   /*
     Write a program WindChill.java that takes two double command-line arguments t and v and prints the wind chill. 
     Use Math. Pow (a, b) to compute ab. Given the temperature t (in Fahrenheit) and 
     the wind speed v (in miles per hour), the National Weather Service defines the 
     effective temperature (the wind chill) to be:w = 35.74 + 0.6215 * t + (0.4275 * t − 35.75) * v^0.16
     Note: the formula is not valid if t is larger than 50 in absolute 
     value or if v is larger than 120 or less than 3 (you may assume that the values you get are in that range).
  */


    class WindChill
    {
        public void ReadInput()
        {
            Console.Write("Enter t in Fahrenheit  Value :- "); //get inpur user t value
            string input1 = Console.ReadLine();
            double t = Convert.ToInt32(input1);  //convert from string into double 
            
            Console.Write("Enter v in miles per hour Value :- "); // get user input v value
            string input2 = Console.ReadLine();
            double v = Convert.ToInt32(input2); //convert from string into double 
            windchillM(t, v);  //calling  method 

        }
        private void windchillM(double t, double v)
        {
            if (t < 50) // Cheack t less than 50
            {
                if (v < 120) // Cheack v less than 120
                {
                    if(v > 3) // Cheack v grater than 3
                    {
                        double windChill = 35.74 + 0.6215 * t + (0.4275 * t - 35.75) * Math.Pow(v, 0.16);
                        Console.WriteLine(windChill); // display windchill value
                    }
                    else
                    {
                        Console.WriteLine("v Velocity less than 3"); 
                    }
                }
                else
                {
                    Console.WriteLine(" v Velocity is larger than 120  "); 
                }
            }
            else
            {
                Console.WriteLine("t (in Fahrenheit) larger then 50"); 
            }
            
        }
    }
}
