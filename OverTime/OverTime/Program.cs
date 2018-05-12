using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OverTime
{
    class Program
    {
        private const double BaseHours = 40.0;
        private const double OvertimeRate = 1.5;

        static void Main(string[] args)
        {
            Console.Write("Please Enter the Number of Hours worked:..");
            var hoursWorked = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please Enter your hourly pay rate:..");
            var hourlyPayRate = Convert.ToDouble(Console.ReadLine());

            if (hoursWorked > BaseHours)
            {
                var basePay = hourlyPayRate * BaseHours;

                var overtimeHours = hoursWorked - BaseHours;

                var overtimePay = overtimeHours * OvertimeRate * hourlyPayRate;
                //Calculate the Gross Pay
                var grossPay = basePay + overtimePay;

            }
            else
            {
                var grossPay = hourlyPayRate * hoursWorked;
            }

            Console.WriteLine("Press Enter to exit the program.");

            Console.ReadLine();
        }
        
    }
}
