using System;

namespace Emperial_BMI_Calculator
{
   public class BMICalculator
    {
        static void Main(string[] args)
        {
            double weight_in_pounds;
            double height_in_inches;

            Console.Write("Please Enter the weight in pounds:  ");
            String Input = Console.ReadLine();
            weight_in_pounds = double.Parse(Input);


            Console.Write("Please enter the height in inches:  ");
            String Input2 = Console.ReadLine();
            height_in_inches = double.Parse(Input2);

            double TOTAL_INCHES = height_in_inches * 12;

            double BODY_MASS_INDEX = (weight_in_pounds / (Math.Pow(TOTAL_INCHES, 2.0)) * 703);

            Console.WriteLine("The Body Mass Index is {0}", BODY_MASS_INDEX);

            if (BODY_MASS_INDEX < 18.5)
            {
                Console.WriteLine("The Person is Underweight");
            }
            else if (BODY_MASS_INDEX < 25.0)
            {
                Console.WriteLine("The Person Has Normal Weight");
            }
            else if (BODY_MASS_INDEX < 30.0)
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
