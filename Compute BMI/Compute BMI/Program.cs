using System;

namespace Compute_BMI
{
    public class ComputeAndInterpretBMI
    { 
        static void Main(string[] args)
        {
            double weight_in_pounds;
            double height_in_inches;
            double BODY_MASS_INDEX;
            Console.Write("Please enter the weight in pounds:  ");
            String input = Console.ReadLine();
            weight_in_pounds = double.Parse(input);

            Console.Write("Please enter the height in inches:  ");
            String input2 = Console.ReadLine();
            height_in_inches = double.Parse(input2);

            double KILOGRAMS_PER_POUND = 0.45359237;//Constant
            double METERS_PER_INCH = 0.0254;//Constant

            double weight_in_kilograms = weight_in_pounds * KILOGRAMS_PER_POUND;
            double height_in_meters = height_in_inches * METERS_PER_INCH;

            BODY_MASS_INDEX = (weight_in_kilograms / (Math.Pow(height_in_meters, 2.0)));

            Console.WriteLine("The Body Mass Index is {0}", BODY_MASS_INDEX);

            if (BODY_MASS_INDEX <18.5)
            {
                Console.WriteLine("The Person is Underweight");
            }
            else if (BODY_MASS_INDEX <25.0)
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
