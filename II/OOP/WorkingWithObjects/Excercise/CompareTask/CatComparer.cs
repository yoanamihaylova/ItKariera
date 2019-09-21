using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsCompare
{
    class CatComparer : IComparer<Cat>
    {
        public int Compare(Cat x, Cat y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
