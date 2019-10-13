using System;

namespace Demo2
{
    class DelegatesDemo
    {
        public delegate int myDelegate();
        public delegate void myDelegates();
        
        static void Main(string[] args)
        {
            /* myDelegate myDeleg = RandomNumber;
             Console.WriteLine(myDeleg());*/
            myDelegates d = f1;
            d += f2;
            d += f3;
            d();

            d -= f2;
            d();


        }
        public static int RandomNumber()
        {
            Random rnd = new Random();
            return rnd.Next(100);
        }
        public static void f1()
        { Console.WriteLine("Execute first method!"); }
        public static void f2()
        { Console.WriteLine("Execute second method"); }
        public static void f3()
        { Console.WriteLine("Execute third method"); }
    }
}
