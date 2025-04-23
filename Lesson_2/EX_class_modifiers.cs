class EX_class_modifiers
{
	public static void RunExample()
	{
		// Використання класу
		BankAccount account1 = new BankAccount("123456789", 1000);
		BankAccount account2 = new BankAccount("987654321", 500);

		account1.Deposit(250);
		account2.Withdraw(100);

		Console.WriteLine($"Рахунок {account1.AccountNumber}: {account1.Balance}");
		Console.WriteLine($"Рахунок {account2.AccountNumber}: {account2.Balance}");
	}

	public class BankAccount
	{
		private decimal _balance; // Приватне поле
		public readonly string AccountNumber; // Readonly поле

		public BankAccount(string accountNumber, decimal initialBalance)
		{
			AccountNumber = accountNumber; // Readonly можна встановити в конструкторі
			_balance = initialBalance;
		}

		public decimal Balance
		{
			get { return _balance; }
			private set { _balance = value; } // Приватний сетер
		}

		public void Deposit(decimal amount)
		{
			if (amount > 0)
				_balance += amount;
		}

		public bool Withdraw(decimal amount)
		{
			if (amount > 0 && _balance >= amount)
			{
				_balance -= amount;
				return true;
			}
			return false;
		}

	}
}

#region Result
// Результат:
// Рахунок 123456789: 1250
// Рахунок 987654321: 400
#endregion
