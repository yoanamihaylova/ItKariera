using System;
using System.Linq;

namespace UpperCaseWords
{
    class UpperCaseWords
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(new string[] { " " },StringSplitOptions.RemoveEmptyEntries);

            Func<string, bool> checker = n => n[0] == n.ToUpper()[0];

            words.Where(checker).ToList().ForEach(n => Console.WriteLine(n));

        }
    }
}
