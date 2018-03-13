using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezium_Getter_Setter
{
    class Trapezium
    {
            private double length_a;
            private double length_b;
            private double height;

            public Trapezium(double length_a, double length_b, double height)
            {
                this.length_a = length_a;
                this.length_b = length_b;
                this.height = height;
            }
            public double Length_a
            {
                get { return length_a; }
            }
            public double Length_b
            {
                get { return length_b; }
            }
            public double Height
            {
                get { return height; }
            }

            public double Area_trapezium()
            {
                return 0.5 * (length_a + length_b) * height;
            }
        
    }
}
