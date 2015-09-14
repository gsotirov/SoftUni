using System;

namespace Problem_2__Print_Company_Information
{
	class PrintCompanyInformation
	{
		public static void Main ()
		{
			// Company Input
			Console.WriteLine ("Please enter company name: ");
			string companyName = Console.ReadLine ();
			Console.WriteLine ("Please enter company address: ");
			string companyAddress = Console.ReadLine ();
			Console.WriteLine ("Please enter company phone number: ");
			string companyPhoneNumber = Console.ReadLine ();
			Console.WriteLine ("Please enter company fax number: ");
			string companyFaxNumber = Console.ReadLine ();
			Console.WriteLine ("Please enter company web site: ");
			string companyWebSite = Console.ReadLine ();

			// Manager input
			Console.WriteLine ("Please enter manager first name: ");
			string managerFirstName = Console.ReadLine ();
			Console.WriteLine ("Please enter manager last name: ");
			string managerLastName = Console.ReadLine ();
			Console.WriteLine ("Please enter manager age: ");
			int managerAge = int.Parse(Console.ReadLine ());
			Console.WriteLine ("Please enter manager phone number: ");
			string managerPhoneNumber = Console.ReadLine ();

			Company company = new Company (
				companyName,
				companyAddress,
				companyPhoneNumber,
				companyFaxNumber,
				companyWebSite,
				new Manager(
					managerFirstName,
					managerLastName,
					managerAge,
					managerPhoneNumber
				)
			);

			Console.WriteLine (company.Introduce());
		}
	}
	public class Company
	{
		// Fields.
		private string name;
		private string address;
		private string phoneNumber;
		private string faxNumber;
		private string website;
		private Manager manager;

		// Constructor.
		public Company(string name, string address, string phoneNumber, string faxNumber, string website, Manager manager)
		{
			this.name = name;
			this.address = address;
			this.phoneNumber = phoneNumber;
			this.faxNumber = faxNumber;
			this.website = website;
			this.manager = manager;
		}

		// Methods.
		public string Introduce()
		{
			string output = "";
			string fax = (!String.IsNullOrEmpty(faxNumber)) ? this.faxNumber : "(no fax)";

			output += "\n======= Company Info =======\n";
			output += this.name + "\n";
			output += "Address: " + this.address + "\n";
			output += "Tel. " + this.phoneNumber + "\n";
			output += "Fax: " + fax + "\n";
			output += "Web site: " + this.website + "\n";
			output += "Manager: " + this.manager.Introduce ();

			return output;
		}
	}

	public class Manager
	{
		// Fields.
		private string firstName;
		private string lastName;
		private int age;
		private string phoneNumber;

		// Constructor.
		public Manager(string firstName, string lastName, int age, string phoneNumber)
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.age = age;
			this.phoneNumber = phoneNumber;
		}

		// Methods.
		public string Introduce() 
		{
			 return this.firstName + " " + this.lastName + " (age: " + this.age + ", tel. " + this.phoneNumber + ")\n";
		}
	}
}
