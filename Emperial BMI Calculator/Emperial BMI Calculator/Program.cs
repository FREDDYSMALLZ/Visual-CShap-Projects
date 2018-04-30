using System;

namespace Emperial_BMI_Calculator
{
   public class BmiCalculator
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter the weight in pounds:  ");
            String input = Console.ReadLine();
            var weightInPounds = double.Parse(input);


            Console.Write("Please enter the height in inches:  ");
            String input2 = Console.ReadLine();
            var heightInInches = double.Parse(input2);

            double totalInches = heightInInches * 12;

            double bodyMassIndex = (weightInPounds / (Math.Pow(totalInches, 2.0)) * 703);

            Console.WriteLine("The Body Mass Index is {0}", bodyMassIndex);

            if (bodyMassIndex < 18.5)
            {
                Console.WriteLine("The Person is Underweight");
            }
            else if (bodyMassIndex < 25.0)
            {
                Console.WriteLine("The Person Has Normal Weight");
            }
            else if (bodyMassIndex < 30.0)
            {
                Console.WriteLine("The Person is Overweight");
            }
            else
            {
                Console.WriteLine("The Person is Obese..!");
            }

            Console.ReadLine();

           
        }
    }
}
