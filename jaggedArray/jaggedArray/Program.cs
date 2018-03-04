using System;

namespace jaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int [][] jaggedArray = new int[5][];//Declare the array


            /*Initialize the Array*/
            jaggedArray[0] = new int[2] {1,2};
            jaggedArray[1] = new int[1] {3};
            jaggedArray[2] = new int[3] {4,5,6};
            jaggedArray[3] = new int[4] {1,2  ,8,9};
            jaggedArray[4] = new int[3] {6,3,5};

            //Traversing through the array
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write("Element({0}): ", i + 1);

                for (int j = 0; j < jaggedArray[i].Length; j++) 
                {
                    Console.Write(jaggedArray[i][j] + "\t");

                }
                Console.WriteLine();//Moves to the new line

            }
            Console.ReadLine();



        }
    }
}
