using System;
using System.Diagnostics;

namespace Algorithm2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Taking default number of 49 as the value of n for overflow...");
            Console.WriteLine("Enter value of n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            try
            { 
                // Timer starts
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                Console.WriteLine("The Fibonacci series is:");
                int[] F = new int[n];

                F[0] = 0;
                F[1] = 1;
                for (int i = 2; i < n; i++)
                {
                    F[i] = F[i - 1] + F[i - 2];
                }
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine((i+1) + ". " + F[i]);
                }
                stopwatch.Stop();
                Console.WriteLine("Execution time (in seconds) = " + stopwatch.ElapsedMilliseconds / 1000);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message.ToString() + " detected for n = " + n + "!");
            }
        }
    }
}

