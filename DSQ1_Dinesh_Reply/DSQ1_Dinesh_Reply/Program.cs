using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSQ1_Dinesh_Reply
{
    class Triangle
    {
        //Variables declared
        private double breadth;
        private double height;

        public Triangle(double breadth, double height)
        {
            this.breadth = breadth;
            this.height = height;

        }
        // Getter method
        public double Breadth
        {
            get { return breadth; }
        }
        public double Height
        {
            get { return height; }
        }

        //Calculating the area of the Triangle
        public double Area_Of_Triangle()
        {
            return 0.5 * (breadth * height);
        }
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the breadth of the Triangle: ");
            var breadth = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the height of the Triangle: ");
            var height = Convert.ToDouble(Console.ReadLine());

            var triangle = new Triangle(breadth, height);

            Show_the_Area(triangle);//Method to display the area of the triangle

            Console.WriteLine("Press Enter to exit");

            Console.ReadLine();
        }

        private static void Show_the_Area(Triangle triangle)
        {
            Console.WriteLine($"The Breadth of the triange is : {triangle.Breadth} meters.  ");
            Console.WriteLine($"The Height of the triange is  : {triangle.Height} meters.  ");
            Console.WriteLine($"Therefore, the Area of the  triange is  : {triangle.Area_Of_Triangle()} square meters.  ");
        }
    }
}
