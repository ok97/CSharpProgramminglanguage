using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplePrograms
{   /*  Sum of three integer adds to ZERO
        a. Desc: - A program with cubic running time. Read in N integer and counts the
           number of triples that sum to exactly 0.
        b. I/P: - N Number of integers, and N integer input array
        c. Logic: - Find distinct triples (i, j, k) such that a[i], a[j], a[k]=0
        d. O/P: - One output is number of distinct triplets as well as the second output is to print the distinct triplets.
    */

    class SumOFTripletValueZero
    {
        public void ReadInput()
        {
            Console.Write("Enter a Array Size :- "); // Get user input Array Size
            String arsize = Console.ReadLine();
            int n = Convert.ToInt32(arsize);    //convert from string into int n

            int[] array = new int[n];
            Console.Write($"Enter {n} Array Elements :- "); // Get input user array elements
            for (int i = 0; i < n; i++)     // cheack a array size get put user input
            {
                array[i] = Convert.ToInt32(Console.ReadLine());     //array convert int
            }
            Triplets(array);    // calling method
        }
       
        public void Triplets(int[] array)
        { 
           
            bool found = false;
            for (int i = 0; i < array.Length; i++) // i=0
            {

                for (int j = i + 1; j < array.Length; j++) //j=1
                {

                    for (int k = j + 1; k < array.Length; k++) // k=2
                    {
                        if (array[i] + array[j] + array[k] == 0)    // Add arrayi,j,k and sum=0
                        {
                            found = true;
                            
                           Console.WriteLine("[" + array[i] + "," + array[j] + "," + array[k] + "]"); //Print triplets
                        }

                    }

                }
            }
            if (found == false) 
                Console.WriteLine("Triplets doesn't exist in user input Array"); 
        }
    }
}
