using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getter_Setter_Example
{

	class Employee
	{
		private int emp_Id;
		private string emp_Name;
		private int ssn;
		private double hours_worked = 40.0;

		public void SetEmp_Id(int Id)
		{
			if (Id < 0)
			{
				throw new Exception("The Employee Id is not valid!");

			}
			this.emp_Id = Id;
		}

		public int getEmp_Id()
		{
			return this.emp_Id;
		}
		public void SetEmp_name(string name)
		{
			if (string.IsNullOrEmpty(emp_Name))
			{
				throw new Exception("The Employee name cannot be empty!");

			}
			this.emp_Name = name;
		}

		public string getEmp_name()
		{
			return this.emp_Name;
		}
		public void SetSsn(int social_sec)
		{
			if (social_sec < 0)
			{
				throw new Exception("The  Employee SSN entered is invalid. Please enter only numerical values!");

			}
			this.ssn = social_sec;
		}

		public int getSsn()
		{
			return this.ssn;
		}

		public double getHours_Worked()
		{
			return this.hours_worked;
		}

	}

	class Program
	{
		static void Main(string[] args)
		{
			Employee employee = new Employee();
			employee.SetEmp_Id(28568);
			employee.SetEmp_name("Fredrick Ondieki");
			employee.SetSsn(123456789);

			Console.WriteLine("The Employee name is {0} with the folowing details:" +
				" Social number {1}, employee Id {2} and worked {3:F} hours "
				, employee.getEmp_name(), employee.getSsn(), employee.getEmp_Id(), employee.getHours_Worked());


			Console.WriteLine("Press Enter to Exit.");

			Console.ReadLine();
		}
	}
}
