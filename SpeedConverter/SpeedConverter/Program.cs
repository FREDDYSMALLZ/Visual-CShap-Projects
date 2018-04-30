using System;
using static System.Console;

namespace SpeedConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter the Speed in Miles per hour: ");
            var speed = Convert.ToDouble(ReadLine());

            string value = $"Enter the distance traveled in miles: ";
            WriteLine(value);
            var distance = Convert.ToDouble(ReadLine());

            var time = distance / speed;


            WriteLine("It takes {0} time to travel {1} " +
                              "miles at the speed of {2} " +
                              "miles per hour",time,distance,speed);

        }
    }
}
