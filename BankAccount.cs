namespace BankAccountNS
{
    public class BankAccount
    {
        public string name;
        public double balance;

        public BankAccount(string name, double initialBalance)
        {
            this.name = name;
            balance = initialBalance;
        }

        public string Debit(double amount)
        {
            if (amount < 0)
            {
                return "Error: Debit amount cannot be negative."; 
            }

            if (amount > balance)
            {
                return "Error: Insufficient funds for this transaction.";
            }

            balance -= amount;
            return "Transaction successful. Amount debited: " + amount;
        }
    }
}
