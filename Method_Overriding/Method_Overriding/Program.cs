using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overriding
{
    class vehicle
    {
        public void run()
        {
            Console.WriteLine("The Vehicle is running smoothly.");
        }
    }
    class motorbike : vehicle
    {
        public void run()
        {
            Console.WriteLine("The Motorbike is broken!!!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            motorbike myBike = new motorbike();
            myBike.run();



            Console.ReadLine();
        }
    }
}
