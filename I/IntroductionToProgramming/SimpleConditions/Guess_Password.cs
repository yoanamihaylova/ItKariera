using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string password;
            password = Console.ReadLine();
            if (password == "s3cr3t!P@ssw0rd") Console.WriteLine("Welcome");
            else Console.WriteLine("Wrong password!");

        }
    }
}
