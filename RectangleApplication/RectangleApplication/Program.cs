using RectangleApplication;
using System;

namespace RectangleApplication
{
    class Rectangle
    {
        //Rectangle  variables
        private double length;
        private double width;

        public void UserEntries()
        {
            Console.WriteLine("Please Enter the  Length of the Rectangle: ");//User enters the lenghth of the rectangle
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter the Width of the Rectangle : ");//User enters the width of the rectangle
            width = Convert.ToDouble(Console.ReadLine());
        }
        public double getArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("The Length of the Rectangle is {0:F1} meters.    " , length);
            Console.WriteLine("The Width of the rectangle is {0:F1} meters.", width);
            Console.WriteLine("Therefore, the Area of the rectangle is {0:F1} square meters.", getArea());
        }
    }

    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle myRectangle = new Rectangle();
            myRectangle.UserEntries();
            myRectangle.Display();


            Console.ReadLine();
        }
    }
}





