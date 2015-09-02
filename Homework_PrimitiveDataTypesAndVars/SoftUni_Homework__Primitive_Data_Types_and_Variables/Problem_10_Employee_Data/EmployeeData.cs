using System;

namespace Problem_10_Employee_Data
{
	class EmployeeData
	{
		public static void Main ()
		{
			// Making the input dynamic. Just for the fun of it :)
			Console.WriteLine("Please enter your first name:");
			string firstName = Console.ReadLine();
			Console.WriteLine("Please enter your last name:");
			string lastName = Console.ReadLine();
			Console.WriteLine("Please enter your age:");
			sbyte age = sbyte.Parse(Console.ReadLine());
			Console.WriteLine("Please enter your gender:");
			char gender = Console.ReadLine()[0];
			Console.WriteLine("Please enter your personal ID:");
			ulong personalId = ulong.Parse(Console.ReadLine());
			Console.WriteLine("Please enter your unique employee number:");
			uint uniqueEmpNum = uint.Parse(Console.ReadLine());

			Employee employee = new Employee(firstName, lastName, age, gender, personalId, uniqueEmpNum);

			// Introduce the Employee to the public...
			employee.Introduce();
		}
	}

	// Made the task a bit more interesting :)
	// This is an Employee class that holds info about the employee and Introduces them when called Introduce();
	class Employee
	{
		// Fields.
		private string firstName;
		private string lastName;
		private sbyte age;
		private char gender;
		private ulong personalId;
		private uint uniqueEmpNum;

		// Constructor.
		public Employee (string firstName, string lastName, sbyte age, char gender, ulong personalId, uint uniqueEmpNum)
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.age = age;
			this.gender = gender;
			this.personalId = personalId;
			this.uniqueEmpNum = uniqueEmpNum;
		}

		// Methods.
		public void Introduce ()
		{
			string output = "";

			output += "\n========== Employee Information ==========\n";
			output += "First name: " + this.firstName + "\n";
			output += "Last name: " + this.lastName + "\n";
			output += "Age: " + this.age + "\n";
			output += "Gender: " + this.gender + "\n";
			output += "Personal ID: " + this.personalId + "\n";
			output += "Unique Employee Number: " + this.uniqueEmpNum;

			Console.WriteLine (output);
		}
	}
}
