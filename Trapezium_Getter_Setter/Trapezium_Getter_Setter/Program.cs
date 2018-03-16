using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezium_Getter_Setter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the longest length (a) of the Trapezium: ");
            var length_a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter the short length (b) of the Trapezium: ");
            var length_b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter the height (h) of the Trapezium: ");
            var height = Convert.ToDouble(Console.ReadLine());

            var myTrapezium = new Trapezium(length_a, length_b, height);
            Display_Trapezium_Area(myTrapezium);//Mthod to get the area of the Trapezium
             
            Console.WriteLine("Press Enter to Exit");

            Console.ReadLine();
        }
        private static void Display_Trapezium_Area(Trapezium myTrapezium)
        {
            Console.WriteLine($"The Long length of the trapezium is   : { myTrapezium.Length_a} meters.   ");
            Console.WriteLine($"The Short length of the trapezium is   : { myTrapezium.Length_b} meters.   ");
            Console.WriteLine($"The Height of the trapezium is   : { myTrapezium.Height} meters.   ");

            Console.WriteLine($"Therefore, the Area of the trapezium is   : {myTrapezium.Area_trapezium() } square meters.");
        }
    }
}
