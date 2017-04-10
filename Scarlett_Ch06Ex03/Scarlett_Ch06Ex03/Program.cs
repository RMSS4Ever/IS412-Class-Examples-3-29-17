/*
 * TRY IT OUT Assignment for IS412 Week 2
 * - Exchanging Data with a Function (Part 2): CH06Ex03/Program.cs
 * 
 * Brian Scarlett * 
 */

using System;

namespace Scarlett_Ch06Ex03
{
    class Program
    {
        // Function SumVals
        static int SumVals(params int[] vals)
        {
            int sum = 0;

            foreach (int val in vals)
            {
                sum += val;
            }

            return sum;

        }

        static void Main(string[] args)
        {
            int sum = SumVals(1, 5, 2, 9, 8);

            Console.WriteLine($"Summed Values = {sum}");

            Console.ReadKey();

        }
    }
}
