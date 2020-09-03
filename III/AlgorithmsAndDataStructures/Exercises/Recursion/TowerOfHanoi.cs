using System;

namespace TowerOfHanoi
{
    class TowerOfHanoi
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Hanoi(n, 1, 2, 3);
        }

        private static void Hanoi(int n, int source, int help, int target)
        {
            if (n == 0) return;
            Hanoi(n - 1, source, target, help);
            Console.WriteLine(source + " --> " + target);
            Hanoi(n - 1, help, source, target);
        }
    }
}
