using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace MultiplePrograms
{       /*  Simulate Stopwatch Program 
            a. Desc: - Write a Stopwatch Program for measuring the time that elapses between the start and end clicks 
            b. I/P: - Start the Stopwatch and End the Stopwatch 
            c. Logic: - Measure the elapsed time between start and end 
            d. O/P: - Print the elapsed time. 
        */
    class StopWatch
    {                
        public static void Stpwatchout()
        {
            var watch = Stopwatch.StartNew(); //stopwatch method startnew

            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + "\n"); // Count 10 times and display
            }

            watch.Stop(); //watch stop method

            Console.WriteLine($"Execution time :{ watch.ElapsedMilliseconds}ms"); // property of ElapsedMillisecond
        }
    }
}
