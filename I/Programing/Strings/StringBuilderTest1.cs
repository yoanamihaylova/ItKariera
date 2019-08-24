using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderTest1
{
    class StringBuilderTest1
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                sb.Append(i);
            }
          //  Console.WriteLine(sb);

            var builder = new StringBuilder();
            builder.Append("Hello Maria, how are you?");
            Console.WriteLine(builder);
            builder[6] = 'D';
            Console.WriteLine(builder);
            builder.Remove(5, 6);
            Console.WriteLine(builder);
            builder.Insert(5, " Peter");
            Console.WriteLine(builder);
            builder.Replace("Peter", "George");
            Console.WriteLine(builder);
        }
    }
}
