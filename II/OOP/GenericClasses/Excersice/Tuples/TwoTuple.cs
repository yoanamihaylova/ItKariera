using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    public class TwoTuple<T,U>
    {
        private T object1;

        public T Object1
        {
            get { return object1; }
            set { object1 = value; }
        }
        private U object2;

        public U Object2
        {
            get { return object2; }
            set { object2 = value; }
        }

        public TwoTuple(T object1 = default(T),U object2 = default(U))
        {
            this.Object1 = object1;
            this.Object2 = object2;
        }
        public override string ToString()
        {
            return $"{this.Object1} -> {this.Object2}";
        }

    }
}
