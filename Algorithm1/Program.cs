using System;
using System.Diagnostics;

namespace Algorithm1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value of n: ");
            long n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            // Timer starts
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Console.WriteLine("The Fibonacci series is:");

            Program p = new Program();

            Console.WriteLine("1. 0");
            Console.WriteLine("2. 1");
            for (long i = 2; i < n; i++)
            {
                long result = p.Fibo(i);
                Console.WriteLine((i+1) +". " + result);

                // The loop will stop when time reaches 60 seconds. 
                if (stopwatch.ElapsedMilliseconds / 1000 == 60)
                {
                    Console.WriteLine("Execution time has reached 60 seconds. " + i + " numbers were printed.");
                    break;
                }
            }
            stopwatch.Stop();
            Console.WriteLine("Execution time (in seconds) = " + stopwatch.ElapsedMilliseconds/1000);
        }

        long Fibo(long n)
        {
            if (n <= 0)
                return 0;
            if (n == 1)
                return 1;
            return Fibo(n - 1) + Fibo(n - 2);
        }
    }
}
