    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

namespace MethodOverloading
{
    public class Wine
    {
        //Variable declarations
        public int year;
        public string name;
        public double price;

        //Overloading methods
        //This wine takes one parameter
        public Wine(string wine_name)
        {
            name = wine_name;
        }
        //This wine takes two parameters
        public Wine(int wine_year, string wine_name)
        {
            year = wine_year;
            name = wine_name;
        }
        //This wine takes 3 parameters
        public Wine(int wine_year, string wine_name, double wine_price)
        {
            year = wine_year;
            name = wine_name;
            price = wine_price;
        }
        class program
        {

            static void Main(string[] args)
            {
                Wine wine_1 = new Wine("Pinot noir");
                Wine wine_2 = new Wine(2004, "Sauvignon blanc");
                Wine wine_3 = new Wine(1994, "Cabernet sauvignon", 250.00);

                Console.WriteLine("Your wine is {0}", wine_1.name);
                Console.WriteLine("The wine made in the year {0} is from the French and is known as {1}", wine_2.year, wine_2.name);
                Console.WriteLine("In the year {0}, a wine by the name {1} costed {2:C}", wine_3.year, wine_3.name, wine_3.price);

                Console.ReadLine();
            }
        }

    }
}
