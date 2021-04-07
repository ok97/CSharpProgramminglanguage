using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplePrograms
{       /* 2D Array
           a. Desc: - A library for reading in 2D arrays of Integers, double, or Booleans from standard
              input and Printing them out to standard output.
           b. I/P: - M rows, N cols, and M*N inputs for 2D Array. Use Java Scanner class
           c. Logic: - create 2-dimensional array in memory to read in M rows and N cols
           d. O/P: - Print function to print 2Dimenstional Array. 
        */
    class MultiDimentional
    {
        public void ReadMultiArray()
        {
            
            object[][] array = new object[4][];     //Declare array
            array[0] = new object[2]; //integer
            array[1] = new object[2]; //boolean
            array[2] = new object[2]; // string
            array[3] = new object[2]; // double

            Console.WriteLine("Enter a Integer array of 2 elements");   //Take input user
            for (int i = 0; i < 2; i++)     //Read one by one integer elements and store array
            {
                array[0][i] = Convert.ToInt32(Console.ReadLine()); // store array elements
            }

            Console.WriteLine("Enter Boolean(True or False) Array of 2 Elements");   //Take input user
            for (int i = 0; i < 2; i++)     //Read one by one Boolean elements and store array
            {
                array[1][i] = Convert.ToBoolean(Console.ReadLine());  // store array elements
            }

            Console.WriteLine("Enter String array of 2 elements");     //Take input user
            for (int i = 0; i < 2; i++)             //Read one by one String elements and store array
            {
                array[2][i] = Console.ReadLine(); //store array elements
            }

            Console.WriteLine("Enter Double array of 2 elements");     //Take input user
            for (int i = 0; i < 2; i++)           //Read one by one Double elements and store array
            {
                array[3][i] = Convert.ToDouble(Console.ReadLine());      //store array elements
            }

            
            for (int i = 0; i < 4; i++)   // Iterating over the Object array
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    
                    Console.WriteLine(array[i][j] + "\n");  //Print i and J array
                }
                Console.WriteLine();
            }

        }
    }
}