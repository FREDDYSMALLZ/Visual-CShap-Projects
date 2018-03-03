using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentScoreMultiD
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] student = new int[3][];
            student[0] = new int[2] { 56, 76 };
            student[1] = new int[1] { 83};
            student[2] = new int[3] {34,78,67};

            double sum;
            for (int i = 0; i < student.Length; i++)
            {
                sum = 0;
                for (int j = 0; j < student[i].Length; j++)
                {
                    sum += student[i][j];


                    Console.Write("The Average score for student {0} is  ", i);

                    Console.WriteLine((sum/student[i].Length).ToString("F1"));

                    Console.ReadLine();

                }
            }

        }
    }
}
