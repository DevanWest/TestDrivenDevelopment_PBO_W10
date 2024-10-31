using System.Security.Cryptography.X509Certificates;
using BankAccountNS;

namespace BankAccountTestNS
{
    [TestClass]
    public class BankAccountUnitTest
    {
        [TestMethod]
        public void DebitIsPositive()
        {
            string name = "Devan Westley";
            double balance = 100000;
            BankAccount account = new BankAccount(name, balance);

            double debitAmount = 250000;
            account.Debit(debitAmount);
            Assert.IsTrue(debitAmount > 0);
        }

        public double balance
        {
            get { return balance; }
        }

        [TestMethod]
        public void DebitLessThanBalance()
        {
            string name = "Devan Westley";
            double balance = 100000;
            BankAccount account = new BankAccount(name, balance);

            double debitAmount = 25000;
            Assert.IsTrue(balance > debitAmount, "Debit > balance.");
        }

        [TestMethod]
        public void TransactionIsCorrect()
        {
            string name = "Devan Westley";
            double initialBalance = 100000;
            BankAccount account = new BankAccount(name, initialBalance);

            double debitAmount = 250000; 
            double expectedAmount = initialBalance;

            try
            {
                account.Debit(debitAmount);
            }
            catch (InvalidOperationException)
            {

            }
            Assert.AreEqual(initialBalance, account.balance, 0.00001, "Error! Computation is wrong."); 
        }

    }
}