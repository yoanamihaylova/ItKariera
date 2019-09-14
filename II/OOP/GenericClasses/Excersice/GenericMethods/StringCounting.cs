using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethods
{
    public static class StringCounting
    {
        public static int CountBigger<T>(List<T> list, T compare) where T : IComparable <T>
        {
            int br = 0;
            foreach (var item in list)
            {
                if (item.CompareTo(compare) > 0) br++;

            }
            return br;
        }
    }
}
