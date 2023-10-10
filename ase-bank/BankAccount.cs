using System;

namespace ase_bank
{
    public class BankAccount
    {
        private string m_customerName;

        private double m_balance;

        private bool m_frozen = false;

        private BankAccount()
        {
        }

        public BankAccount(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }

        public string CustomerName
        {
            get { return m_customerName; }
        }

        public double Balance
        {
            get { return m_balance; }
        }

        /**
        * This method subtracts the amount passed in from the account balance
        * */
        public void Debit(double amount)
        {
            m_balance -= amount;
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            // throw new NotImplementedException();
        }

        /**
         * This method adds the amount passed in to the account balance
         * */
        public void Credit(double amount)
        {
            m_balance += amount;
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
               // throw new NotImplementedException();
        }

        public void FreezeAccount()
        {
            if (m_frozen = true)
            {
                throw new InvalidOperationException();
            }
            // m_frozen = true;
        }

        public void UnfreezeAccount()
        {
            m_frozen = false;
        }

        public static void Main()
        {
            BankAccount ba = new BankAccount("Mr. Bryan Walton", 11.99);
            ba.Credit(5.77);
            ba.Debit(11.22);
            Console.WriteLine("Current balance is ${0}", ba.Balance);
        }

    }
}
