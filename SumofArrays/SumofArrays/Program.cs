using System;

namespace SumofArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 87, 68, 94, 100, 83, 78, 81, 95, 76, 87 };
            int total = 0;
            //add each elements's value to the total
            /* for (int counter = 0; counter < array.Length; ++counter)           
             {
                 total += array[counter]; //ad element value to the total

             }
             */
            foreach (int number in array)
            {
                total += number;
            }

            Console.WriteLine($"Total of Array elements: {total}");
            Console.WriteLine("The totals for the arrays elemts is {0} ", total);

            Console.ReadLine();
        }
    }
}
