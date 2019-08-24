using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            phonebook["Ani"] = "0895647213";
            //Console.WriteLine(phonebook["Ani"]);
            phonebook.Add("Ivan","0874569872");
            foreach (var item in phonebook.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine( );
            foreach (var a in phonebook.Values)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();
            foreach (var item in phonebook)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            Console.WriteLine();
        }
    }
}
