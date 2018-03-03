using System;

namespace ConstantArray
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ArrayLength = 5;
            int[] array = new int[ArrayLength];



            //Output for each aaray ane emlements value
            for (int counter = 0; counter < array.Length; ++counter)
            {
                array[counter] = 2 + 2 * counter;
            }

                Console.WriteLine($"{"Index"}{"Value",8}"); //Headings
                for (int counter = 0; counter < array.Length; ++counter)
                {
                    Console.WriteLine($"{counter,5} {array[counter],8}");
                }              

                Console.ReadLine();
            }
        }
    }

