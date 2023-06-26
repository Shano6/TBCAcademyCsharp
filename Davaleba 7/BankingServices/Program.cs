namespace BankingServices
{
    public struct Currency
    {
        public string Name { get; }
        public decimal Amount { get; }

        public Currency(string name, decimal amount)
        {
            Name = name;
            Amount = amount;
        }

        public override string ToString()
        {
            return $"{Amount} {Name}";
        }
    }

    public partial class BankAccount
    {
        public string AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public Currency Balance { get; set; }

        public BankAccount(string accountNumber, string accountHolderName, Currency balance)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            Balance = balance;
        }

        public void Deposit(Currency amount)
        {
            Balance = new Currency(Balance.Name, Balance.Amount + amount.Amount);
        }

        public void Withdraw(Currency amount)
        {
            if (Balance.Amount >= amount.Amount)
            {
                Balance = new Currency(Balance.Name, Balance.Amount - amount.Amount);
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }

        public Currency BalanceCheck()
        {
            return Balance;
        }
    }

    public partial class BankAccount
    {
        private readonly string bankName;

        public BankAccount(string accountNumber, string accountHolderName, Currency balance, string bankName)
            : this(accountNumber, accountHolderName, balance)
        {
            this.bankName = bankName;
        }

        public void TransferFunds(BankAccount target, Currency amount)
        {
            if (Balance.Amount >= amount.Amount)
            {
                Withdraw(amount);
                target.Deposit(amount);
                Console.WriteLine($"Transfer successful. Transferred {amount} to {target.AccountHolderName}.");
            }
            else
            {
                Console.WriteLine("Insufficient funds for transfer.");
            }
        }
    }
}
