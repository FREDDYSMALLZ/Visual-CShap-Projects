using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getter_Setter_Example
{
    class EmployeeEx
    {
        public EmployeeEx()
        {

        }

        public EmployeeEx(int employeeID, string employeeName, string socialSecurity, double hoursWorked)
        {

        }



        private int employeeID;

        public int ID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        private string empoyeeName;

        public string Name
        {
            get { return empoyeeName; }
            set {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new InvalidProgramException("The Employee must have a name");
                    }
                    empoyeeName = value;
            }
        }

        private string socialSecurity;

        public string SSN
        {
            get { return socialSecurity; }
            set {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new InvalidProgramException("The Social Security is required");
                }
                if (value.Length!=9)
                {
                    throw new InvalidProgramException("The Social Security must be 9 characters long");
                }
                socialSecurity = value;
            }
        }

        private double hoursWorked;

        public double HoursWorked
        {
            get { return hoursWorked; }
            set {
                if (value <= 0)
                {
                    throw new InvalidProgramException("The hours worked must be greater than 0");
                }
                hoursWorked = value;
            }
        }


    }
}
