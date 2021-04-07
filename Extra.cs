using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplePrograms
{
    class Extra
    {
        public void ReadInput()
        {
            Console.Write("Enter a Array Size :- "); // Get user input Array Size
            String arsize = Console.ReadLine();
            int num = Convert.ToInt32(arsize);    //convert from string into int n

            int[] array = new int[num];
            Console.Write($"Enter {num} Array Elements :- "); // Get input user array elements
            for (int i = 0; i < num; i++)     // cheack a array size get put user input
            {
                array[i] = Convert.ToInt32(Console.ReadLine());     //array convert int
            }
            findTriplets(array);    // calling method

        }
        public static void findTriplets(int[] array)
        {
           // int[] a = { 0 - 1, 2, -3, 1, 1, -2, 1, 0, 5 };
            int al = array.Length;
            int sum = 0;
            Array.Sort(array);  // Sort the input array            
            bool found = false;
            for (int i = 0; i < al - 2; i++)        // Iterate over the array from start to n-2
            {
                if (i == 0 || array[i] > array[i - 1])
                {
                    int start = i + 1;
                    int end = al - 1;
                    int target = sum - array[i];
                    while (start < end)
                    {
                        
                        if (start > i + 1 && array[start] == array[start - 1])
                        {
                            start++;
                            continue;
                        }
                        if (end < al - 1 && array[end] == array[end + 1])
                        {
                            end--;
                            continue;
                        }
                        if (target == array[start] + array[end])
                        {
                            Console.Write("[" + array[i] + "," + array[start] + "," + array[end] + "] ");
                            found = true;
                            start++;
                            end--;
                        }
                        else if (target > (array[start] + array[end]))
                        {
                            start++;
                        }
                        else
                        {
                            end--;
                        }
                    }
                }
            }
            if (found == false)
            {
                Console.WriteLine("No Such Triplets Exits");  // no such triplets found
            }
        }


}   }
