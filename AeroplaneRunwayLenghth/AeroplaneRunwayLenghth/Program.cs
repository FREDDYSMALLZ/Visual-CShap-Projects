using System;

namespace AeroplaneRunwayLenghth
{
   public  class AeroPlane
    {
       public  static void Main(string[] args)
        {
            Console.Write("Please Enter the plane speed in meters/second:");
            double speed = double.Parse(Console.ReadLine());

            Console.Write("Please Enter the plane velocity in meters per second");
            double velocity = double.Parse(Console.ReadLine());

            double length = Math.Pow(velocity, 2.0) / (2 * speed);

            Console.WriteLine("The Minimum runway lenth for this plane is {0:F1}" +
                " having the speed of {1:F1} meters/second and the velocity of {2:F} meters per second.", length,speed,velocity);


            Console.ReadLine();
        }    
    }
}
