using System;

namespace Creating_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {32,27,64,18,95}; //An array which contains five elements

            Console.WriteLine($"{"Index"}{"Value",8}");

            //Output for each aaray ane emlements value
            for (int counter = 0; counter < array.Length; ++counter)
            {
                Console.WriteLine($"{counter,5} {array[counter],8}");


                Console.ReadLine();
            }
        }
    }
}
