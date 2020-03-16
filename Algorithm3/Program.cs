using System;
using System.Diagnostics;

namespace Algorithm3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 10,000 as the value of 'n' for this algorithm since we are calculating time for 10,000 numbers.");
            Console.WriteLine("Enter value of n: ");
            var n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            // Timer starts
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Console.WriteLine("The Fibonacci series is:");
            var f0 = 0;
            Console.WriteLine("1. " + f0);
            var f1 = 1;
            Console.WriteLine("2. " + f1);

            // Iteration
            for(var i=2; i<n; i++)
            {
                var sum = f0 + f1;
                Console.WriteLine((i+1) + ". " + sum);
                f0 = f1;
                f1 = sum;
            }

            stopwatch.Stop();
            Console.WriteLine("Execution time for 10,000 counts (in milliseconds) = " + stopwatch.ElapsedMilliseconds);
        }
    }
}
