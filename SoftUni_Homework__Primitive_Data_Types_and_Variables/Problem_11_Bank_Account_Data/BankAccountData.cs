using System;

namespace Problem_11_Bank_Account_Data
{
	class BankAccountData
	{
		public static void Main ()
		{
			BankAccount bankAccount = new BankAccount(
			    new AccountHolder("Amanda", "Mitchel", "Johnson"),
                23648.32,
                "UniCredit Bulbank",
                "BG37UNCR5000DG0893492",
                new string[] 
				{
					"1849 2412 9894 2154",
					"5738 4285 0024 2142",
					"3751 2452 8965 1523"
				}
			);

			// Get the account details...
			string accountDetails = bankAccount.GetAccountInfo();
			// Print details on the console...
			Console.WriteLine(accountDetails);
		}
	}

	class BankAccount
	{
		// Fields.
		private readonly AccountHolder accHolder;
		private double balance;
		private string bankName;
		private string IBAN;
		private readonly string[] ccNums;

		// Constructor.
		public BankAccount(AccountHolder holder, double balance, string bankName, string IBAN, string[] ccNums)
		{
			this.accHolder = holder;
			this.balance = balance;
			this.bankName = bankName;
			this.IBAN = IBAN;
			this.ccNums = ccNums;
		}

		// Methods.
		public string GetAccountInfo()
		{
			string output = "";

			output += "\n===== Bank Account Information ===\n";
			output += "Bank name: " + this.bankName + "\n";
			output += accHolder.Introduce();
			output += "Balance: " + this.balance + "\n";
			output += "IBAN: " + this.IBAN + "\n";
			output += "==== Credit Cards ====\n";

			foreach (string ccNum in ccNums) 
			{
				output += ccNum + "\n";
			}
			output += "======================================\n";

			return output;
		}
	}

	class AccountHolder
	{
		// Fields.
		private string firstName;
		private string middleName;
		private string lastName;

		// Constructor.
		public AccountHolder(string firstName, string middleName, string lastName)
		{
			this.firstName = firstName;
			this.middleName = middleName;
			this.lastName = lastName;
		}

		// Methods.
		public string Introduce()
		{
			string output = "";

			output += "=== Account Holder ===\n";
			output += "First name: " + this.firstName + "\n";
			output += "Middle name: " + this.middleName + "\n";
			output += "Last name: " + this.lastName + "\n";
			output += "=======================\n";

			return output;
		}
	}
}
