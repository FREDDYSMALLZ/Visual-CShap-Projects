using System;

namespace BarChart_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 4, 5, 7, 6, 3, 1, 2, 4, 8, 9 };//Data distribution
            Console.WriteLine("This is the grade distribution:");

            //For each element of the array, output a bar of the chart
            for (var counter = 0; counter < array.Length; ++counter)
            {
                /*Outputs the bar labels that is 00-09,..., 90-99, 100:*/
                if (counter == 10)
                {
                    Console.Write("  100: ");
                }
                else
                {
                    Console.Write($"{counter * 10:D2} - {counter * 10 + 9:D2}: ");
                }
                //To display a bar of astericks
                for (var stars = 0; stars < array[counter]; ++stars)
                {
                    Console.Write(" * ");

                }
                //Starts a new line of input for the bar chart values
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
