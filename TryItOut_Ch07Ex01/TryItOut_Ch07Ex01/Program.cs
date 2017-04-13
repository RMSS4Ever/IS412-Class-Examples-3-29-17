using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using static System.Console;
namespace Ch07Ex01;

namespace TryItOut_Ch07Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = { 4, 7, 4, 2, 7, 3, 7, 8, 3, 9, 1, 9 };
            int[] maxValIndices;
            int maxVal = Maxima(testArray, out maxValIndices);

            WriteLine($"Maximum value {maxVal} found at element indices: ");
            foreach (int index in maxValIndices)
            {
                WriteLine(index);
            }

            ReadKey();

        }

        static int Maxima(int[] integers, out int[] indices)
        {
            Debug.WriteLine("Maximum value search started.");
            indices = new int[1];
            int maxVal = integers[0];
            indices[0] = 0;
            int count = 1;
            Debug.WriteLine(string.Format($"Maximum value initialized to {maxVal}, at element index 0."));

        }
    }
}
