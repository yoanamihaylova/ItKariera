using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class BankAccount
    {
        private int id;
        private double balance;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public void Deposite(double amount)
        {
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if(balance<amount)
            {
                Console.WriteLine("Insufficient balance");
            }
            else Balance -= amount;
        }
        public override string ToString()
        {
            return $"Account {Id}, balance {Balance}".ToString();
        }
    }
}
