using System;

namespace Delegates
{
    class StartUp
    {
        public delegate void WorkPerformedHandler(int hours, WorkType workType);
        static void Main(string[] args)
        {
            WorkPerformedHandler w = ManagerWorkPerformed;
            w(2, WorkType.Admin);

            WorkPerformedHandler w1 = ManagerWorkPerformed;
            w += w1;
            w(5, WorkType.User);
        }
        public static void ManagerWorkPerformed(int workHours, WorkType wType)
        {
            Console.WriteLine($"{wType} worked {workHours} hours.");
        }
    }
}
