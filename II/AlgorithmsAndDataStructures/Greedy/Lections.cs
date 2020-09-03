using System;
using System.Collections.Generic;
using System.Linq;

namespace Lections
{
    class Lections
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Activity> activities = new List<Activity>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToArray();
                activities.Add(new Activity { Name = input[0], Start = int.Parse(input[1]), End = int.Parse(input[2]) });
            }
            activities = activities.OrderBy(a => a.End).ToList();

            Activity currentActivity = activities.First();
            Console.WriteLine(currentActivity);

            for (int i = 1; i < n; i++)
            {
                if (activities[i].Start >= currentActivity.End)
                {
                    currentActivity = activities[i];
                    Console.WriteLine(currentActivity);
                }
            }
        }
    }

        class Activity
        {
            public string Name { get; set; }
            public int Start { get; set; }
            public int End { get; set; }

            public override string ToString()
            {
                return Name + " " + Start + " " + End;
            }
        }
    }
/*
8
a1 1 3
a2 0 4
a3 1 2
a4 4 6
a5 2 9
a6 5 8
a7 3 5
a8 4 5
*/