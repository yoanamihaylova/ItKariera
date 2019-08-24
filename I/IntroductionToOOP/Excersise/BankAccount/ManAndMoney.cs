using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class ManAndMoney
    {
        static void Main(string[] args)
        {
            /* BankAccount acc1 = new BankAccount();
             acc1.Id = 1;
             acc1.Balance = 1000;            
             Console.WriteLine(acc1);

             /*
             BankAccount acc2 = new BankAccount();
             acc2.Id = 2;
             acc2.Balance = 500;

             BankAccount acc3 = new BankAccount();
             acc3.Id = 3;
             acc3.Balance = 10000;

             Person p1 = new Person();
             p1.Name = "Ivo";
             p1.Age = 21;

             Person p2 = new Person();
             p2.Name = "Gosho";
             p2.Age = 35;

             p1.Accounts.Add(acc1);
             p2.Accounts.Add(acc2);
             p2.Accounts.Add(acc3);

             Console.WriteLine(p1.Name + " - "  + p1.GetBalance());
             Console.WriteLine(p2.Name + " - "  + p2.GetBalance());
             */

            // acc1.Deposite(15);
            //acc1.Withdraw(5);
            //Console.WriteLine(acc1.ToString());


            var accounts = new Dictionary<int, BankAccount>();
            string[] input = Console.ReadLine().Split(' ').ToArray();
            while (input[0]!="End")
            {
                if (input[0] == "Create")
                {
                    Create(input, accounts);
                  //  break;
                }
                else if (input[0] == "Deposit")
                {
                    Deposit(input, accounts);
                   // break;
                }
                else if (input[0] == "Withdraw")
                {
                    Withdraw(input, accounts);
                    //break;
                }
                else if (input[0] == "Print")
                {
                    Print(input, accounts);
                   // break;
                }
                input = Console.ReadLine().Split(' ').ToArray();
            }
        }

        private static void Create(string[] input, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(input[1]);
            if (accounts.ContainsKey(id))
            {
                Console.WriteLine("Account already exists");
            }
            else
            {
                var acc = new BankAccount();
                acc.Id = id;
                accounts.Add(id, acc);
            }
        }

        private static void Deposit(string[] input, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(input[1]);
            var amount = double.Parse(input[2]);
            if (accounts.ContainsKey(id))
            {
                accounts[id].Deposite(amount);
            }
            else
            {
                Console.WriteLine("Account already exists");
            }

        }

        private static void Withdraw(string[] input, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(input[1]);
            var amount = double.Parse(input[2]);
            if (accounts.ContainsKey(id))
            {
                accounts[id].Withdraw(amount);
            }
            else
            {
                Console.WriteLine("Account already exists");
            }
        }

        private static void Print(string[] input, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(input[1]);
            if(accounts.ContainsKey(id))
            {
                Console.WriteLine(accounts[id].ToString());
            }
            else Console.WriteLine("Account already exists");

        }
    }
}
