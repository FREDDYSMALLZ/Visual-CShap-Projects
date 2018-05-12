using System;

namespace OverTime
{
	class Program
	{
		static void Main(string[] args)
		{
			const double federalTax = 0.28;
			const double socialsecurityTax = 0.0765;

			Console.WriteLine("       WEEKLY PAYROLL INFORMATION: CARDONE INDUSTRIES");
			Console.WriteLine("       ---------------------------------------------");

			Console.Write("Please Enter your Full Name: ");
			var employeeName = Console.ReadLine();

			Console.Write("Please enter the number of hours worked this week: ");
			var userInput = Console.ReadLine();
			var hoursWorked = Convert.ToDouble(userInput);

			Console.Write("Please enter the number of " + "Overtime hours worked this week: ");
			userInput = Console.ReadLine();
			var overtimeWorked = Convert.ToDouble(userInput);

			Console.Write("Please enter  your hourly pay rate: ");
			userInput = Console.ReadLine();
			var payRate = Convert.ToDouble(userInput);

			var grossPay = (hoursWorked * payRate + overtimeWorked * 1.5 * payRate);
			var fedWithholding = federalTax * grossPay;
			var socialSecWthholding = socialsecurityTax * grossPay;
			var netPay = fedWithholding + socialSecWthholding - grossPay;
			Console.WriteLine("The weekly payroll " +
							  "information summary for: " + employeeName);
			Console.WriteLine("-----------------------------------------------------");

			Console.WriteLine("Gross pay:  {0:C2}    ", grossPay);
			Console.WriteLine("       Federal income taxes witheld:{0:C2}", fedWithholding);
			Console.WriteLine("       Social Security taxes witheld:{0:C2}", socialSecWthholding);
			Console.WriteLine("       Net Pay: {0:C2}", netPay);

			Console.WriteLine("Press Enter to Exit the Application.");
			Console.ReadLine();
		}

	}
}
