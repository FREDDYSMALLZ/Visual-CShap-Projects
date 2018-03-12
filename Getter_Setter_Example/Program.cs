using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getter_Setter_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeEx employee = new EmployeeEx();
            employee.ID = 4567;
            employee.Name = "Fredrick Ondieki";
            employee.SSN = "023456789";
            employee.HoursWorked = 2.5;

            Console.WriteLine($"The Employee name is {employee.Name} with the folowing details:");
            Console.WriteLine($"    Social number: {employee.SSN}:");
            Console.WriteLine($"    Employee Id {employee.ID} and worked {employee.HoursWorked} hours");
        

            Console.WriteLine("Press Enter to Exit.");

            Console.ReadLine();
        }
    }
}
