using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericArray
{
    class Scale<T> where T : IComparable<T> //Сравнявам двете полета на везната. 
                                            //Ако го напиша : Icomparable е все едно свравнявам две везни.
    {
        private T left;

        public T Left
        {
            get { return left; }
            set { left = value; }
        }

        private T right;

        public T Right
        {
            get { return right; }
            set { right = value; }
        }


        public Scale(T left, T right)
        {
            this.Left = left;
            this.Right = right;
        }

        public T GetHeavier() 
        {
            if (left.CompareTo(right) < 0) return right;
            else if (left.CompareTo(right) > 0) return left;
            else return default(T);
        }

    }
}
