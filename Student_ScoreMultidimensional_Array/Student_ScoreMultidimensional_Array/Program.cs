using System;

namespace Student_ScoreMultidimensional_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] student = { { 52, 76, 65 }, { 98, 87, 93 }, { 43, 77, 62 }, { 72, 73, 74 } };
            double sum; // sum of the scores for each student

            for (int i = 0; i < student.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < student.GetLength(1); j++)

                    sum += student[i, j];
                Console.Write("The average score for student {0} is ", i);

                Console.WriteLine((sum / student.GetLength(1)).ToString("F1"));

                Console.ReadLine();

            }
        }
    }
}

    