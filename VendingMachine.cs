using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplePrograms
{      /*   Find the Fewest Note to be returned for Vending Machine.
            a. Desc: - There is 1,2,5,500 and 1000 Rs Notes which can be returned by Vending Machine. Write program to calculate the minimum number of Notes as well as the Notes to be returned by the vending Machine as a Change.
            b. I/P: - Read the Changes in Rs to be returned by the Vending Machine.
            c. Logic: - Use Recursion and Check to largest value of the Note to return change to get to minimum number of Notes.
            d. O/P: - Two Outputs- one the number of minimum notes needed to give the change and second list of Rs notes that would given in the change.
      */
    class VendingMachine
    {
        public void ReadInput()
        {
            Console.WriteLine("Enter Amount to gives Change");
            string input = Console.ReadLine();
            int amount = Convert.ToInt32(input);
            FindMinNotes(amount);
        }

        private static void FindMinNotes(int amount)
        {
            int[] notes = { 1000, 50, 100, 50, 10, 5, 2, 1 };  // Array store notes
            int[] noteCounter = new int[notes.Length];          //count array Length

            for (int i = 0; i < notes.Length; i++)
            {
                if (amount >= notes[i])
                {
                    noteCounter[i] = amount / notes[i];
                    amount = amount - (noteCounter[i] * notes[i]);
                    if (amount <= 0)
                    {
                        break;
                    }
                }
            }
            Console.Write("Currency count:");  //Print  counts
            for (int i = 0; i < notes.Length; i++)
            {
                if (noteCounter[i] != 0)
                {
                    Console.WriteLine(notes[i] + " : " + noteCounter[i]);
                }
            }
        }
    }
}
