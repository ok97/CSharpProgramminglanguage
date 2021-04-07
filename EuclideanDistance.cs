using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplePrograms
{       /* Write a program Distance that take two integer command-line arguments x, y and print the 
           Euclidean from the point (x, y) to the origin (0,0).
           The formulae to calculate distance=sqrt(x*x+y*y). Use math. Power function.
        */
    class EuclideanDistance
    {
        public void ReadInput()
        {
            Console.Write("Enter x Value :- "); //Get user input x
            string input1 = Console.ReadLine(); //store input value in string input1
            int x = Convert.ToInt32(input1);     //convert from string into int x
            
            Console.Write("Enter y Value :- "); //Get user input x
            string input2 = Console.ReadLine();   //store input value in string input2
            int y = Convert.ToInt32(input2);    //convert from string into int y
            Distance(x, y); //calling  method

        }
        private void Distance(int x, int y)
        {
            double distance = Math.Sqrt(x * x + y * y);  // Calculate distance using Math.Sqrt Method
            Console.WriteLine(distance);    //Print distance
        }
    }
}
