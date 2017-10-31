using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCost
{
    public class Rental
    {
       

        public static void Main(string[] args)
        {
            double cost;
            float Pay_perDay = 30;
            float Pay_Per_AdditionalDay = 20;

            //Prompt the user to enter the number of days for renting the car
            Console.Write("Please Enter the number of days for the Car Rental:");
            int numberOfDays = int.Parse(Console.ReadLine());

            if (numberOfDays <=3)
            {
                cost = numberOfDays * Pay_perDay;

            }
            else
            {
                //cost = (numberOfDays * Pay_perDay) + Pay_Per_AdditionalDay * (numberOfDays -3);
                cost = 90 + Pay_Per_AdditionalDay * (numberOfDays - 3);  
            }

            Console.WriteLine("The Car rental cost is {0:C} since the vehicle was rented for {1} day(s).",cost, numberOfDays);


            Console.ReadLine();
        }
    }
}
 