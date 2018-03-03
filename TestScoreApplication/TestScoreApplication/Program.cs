using System;

namespace TestScoreApplication
{
   public  class Score
    {
        public static void Main(string[] args)
        {
            Console.Write("Please Enter the test Score for Grading Purpose:");
            double score = double.Parse(Console.ReadLine());

            while (score < 0)
            {
                if (score < 50.0)
                {
                    Console.WriteLine("The Score {0:F1} receives grade F:",score);
                }
                else if (score <60)
                {
                    Console.WriteLine("The Score {0:F1} receives grade D:", score);
                }
                else if (score < 80)
                {
                    Console.WriteLine("The Score {0:F1} receives grade C:", score);
                }
                else if (score < 90)
                {
                    Console.WriteLine("The Score {0:F1} receives grade B:", score);
                }
                else if (score <= 100)
                {
                    Console.WriteLine("The Score {0:F1} receives grade A:", score);
                }
                else
                {
                    Console.WriteLine("The Score cannot be greater than 100...!!Please enter a valid test score.");
                }
            }
            Console.ReadLine(); 
        }
    }
}
