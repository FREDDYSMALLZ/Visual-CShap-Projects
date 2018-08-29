using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseAccess
{
	class Program
	{
		static OleDbConnection connection;
		static OleDbCommand command;
		static OleDbDataReader reader;

		public static void GetStudent()
		{
			int counter = 0;
			connection = new OleDbConnection();
			connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
			                              "C:\\Users\\HomeUser\\Documents\\dbSchool.accdb";
			command = new OleDbCommand();
			command.Connection = connection;
			command.CommandText = "SELECT * FROM Student";
			connection.Open();
			reader = command.ExecuteReader();
			while (reader != null && reader.Read())
			{

				counter++;
				Console.WriteLine(reader[0] + "-" + reader[1] + " " + reader[2]);
			}

			connection.Close();
			Console.WriteLine("====================================");
			Console.WriteLine("Number of Students :" + counter);
			Console.WriteLine("====================================");
		}

		public static void InsertStudent()
		{
			Console.Write("First Name : ");
			string fname = Console.ReadLine();
			Console.Write("Last Name : ");
			string lname = Console.ReadLine();
			connection = new OleDbConnection();
			connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;
                       Data Source=C:\Users\HomeUser\Documents\dbSchool.accdb";
			command = new OleDbCommand();
			command.Connection = connection;
			command.CommandText = "INSERT INTO Student (FirstName,LastName) " +
			                      "VALUES ('" + fname + "','" + lname + "')";
			connection.Open();
			int sonuc = command.ExecuteNonQuery();
			connection.Close();
			if (sonuc > 0)
			{
				Console.WriteLine("Inserted");
			}
			else
			{
				Console.WriteLine("Three are errors. The record was not inserted.");
			}
		}

		public static void UpdateStudent()
		{
			Console.Write("ID : ");
			int id = Convert.ToInt32(Console.ReadLine());
			Console.Write("First Name : ");
			string fname = Console.ReadLine();
			Console.Write("Last Name : ");
			string lname = Console.ReadLine();
			//www.csharp-console-example.com
			connection = new OleDbConnection();
			connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=
                                     C:\Users\HomeUser\Documents\dbSchool.accdb";
			command = new OleDbCommand();
			command.Connection = connection;
			command.CommandText = "UPDATE Student SET FirstName=" +
			                      "'" + fname + "',LastName='" + lname + "' WHERE Id=" + id;

			connection.Open();
			int sonuc = command.ExecuteNonQuery();
			connection.Close();
			if (sonuc > 0)
			{
				Console.WriteLine("Updated");
			}
			else
			{
				Console.WriteLine("There are errors. The record was not updated");
			}
		}

		public static void DeleteStudent()
		{
			Console.Write("Id : ");
			int id = Convert.ToInt32(Console.ReadLine());

			connection = new OleDbConnection();
			connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HomeUser\Documents\dbSchool.accdb";
			command = new OleDbCommand();
			command.Connection = connection;
			command.CommandText = "DELETE FROM Student WHERE Id=" + id + "";
			//www.csharp-console-example.com
			connection.Open();
			int sonuc = command.ExecuteNonQuery();
			connection.Close();
			if (sonuc > 0)
			{
				Console.WriteLine("Deleted.");
			}
			else
			{
				Console.WriteLine("Three are errors. The record was not deleted.");
			}
		}


		static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("1.List of Students");
				Console.WriteLine("2.Insert");
				Console.WriteLine("3.Update");
				Console.WriteLine("4.Delete");
				Console.WriteLine("====================================");
				Console.Write("Select : ");
				string sec = Console.ReadLine();
				Console.WriteLine("====================================");
				if (sec == "1")
				{
					//www.csharp-console-example.com
					GetStudent();
				}
				else if (sec == "2")
				{
					InsertStudent();
					Console.WriteLine("====================================");
					GetStudent();
				}
				else if (sec == "3")
				{
					UpdateStudent();
					Console.WriteLine("====================================");
					GetStudent();
				}
				else if (sec == "4")
				{
					DeleteStudent();
					Console.WriteLine("====================================");
					GetStudent();
				}

				Console.Write("Continue (e/h) : ");
				string onay = Console.ReadLine();
				if (onay != "e")
				{
					break;
				}
			}
		}
	}
}



