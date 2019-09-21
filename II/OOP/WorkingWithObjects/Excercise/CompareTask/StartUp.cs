using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsCompare
{
    class StartUp
    {
        static void Main(string[] args)
        {
            /* Point A = new Point(2, 3);
             Point B = new Point(4, 3);
             Point C = new Point(2, 3);
             Console.WriteLine(A.CompareTo(B));
             Console.WriteLine(A.CompareTo(C));*/

             Cat cat1 = new Cat("Kote");
             Cat cat2 = new Cat("Pise");
             //Console.WriteLine(cat1.CompareTo(cat2));

            IComparer<Cat> comparer = new CatComparer();
            Console.WriteLine( comparer.Compare(cat1, cat2) ); 
            SortedSet<Cat> catsByName = new SortedSet<Cat>(comparer);
            catsByName.Add(new Cat("Kote"));
            catsByName.Add(new Cat("Pise"));
            Console.WriteLine( string.Join(" ",catsByName.Select(x => x.Name))); 

        }
    }
}
