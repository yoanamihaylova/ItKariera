using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public class BankAccount
    {
        private decimal amount;

        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public BankAccount(decimal sum = 0)
        {
            Amount = sum;
        }
        public void Deposit (decimal sum)
        {
            Amount += sum;
        }
        public void Withdraw (decimal sum)
        {
            if (sum > Amount) throw new InvalidOperationException("Insufficient availability!");
            Amount -= sum;
        }

    }
}
