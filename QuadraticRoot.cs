using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MultiplePrograms
{       /* Write a program Quadratic to find the roots of the equation a*x*x + b*x + c. 
           Since the equation is x*x, hence there are 2 roots. The 2 roots of the equation can be 
           found using a formula (Note: Take a, b and c as input values)
           delta = b*b - 4*a*c
           Root 1 of x = (-b + sqrt(delta))/(2*a)
           Root 2 of x = (-b - sqrt(delta))/(2*a)

         */
    class QuadraticRoot
    {
        public void ReadInput()
        {
            Console.Write("Enter a Value :- "); // Get User a input
            string input1 = Console.ReadLine();
            int a = Convert.ToInt32(input1);    //convert from string into int a
            Console.Write("Enter b Value :- ");  // Get User b input
            string input2 = Console.ReadLine();
            int b = Convert.ToInt32(input2);  //convert from string into int b
            Console.Write("Enter c Value :- "); // Get User c input
            string input3 = Console.ReadLine();
            int c = Convert.ToInt32(input2);     //convert from string into int c
            Quadratic(a, b, c);
            //calling  method 
        }
        private void Quadratic(int a, int b, int c)
        {
            double Root1, Root2;
            double delta = (b * b) - (4 * a * c); // calculate the delta (b2 - 4ac)
            double sqrt = Math.Sqrt(delta);
            if (delta > 0)  // check if delta is greater than 0
            {
                Root1 = (-b + sqrt) / (2 * a); //distinct Roots1
                Root2 = (-b - sqrt) / (2 * a); //distinct Roots2
                Console.Write("Roots are : " + Root1 + " and " + Root2); //Display Root Value
            }
            else if (delta == 0)  // check if delta == 0
            {
                Console.Write("Root is: " + (-b + sqrt) / (2 * a)); // Display Root combination value
            }
        }
    }
}
