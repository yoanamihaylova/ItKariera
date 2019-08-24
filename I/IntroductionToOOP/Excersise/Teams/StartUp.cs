using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            var person = new List<Person>();
            var team = new Team ("myTeam");
            for (int i = 0; i < N; i++)
            {
                var input = Console.ReadLine().Split(' ').ToArray();
                var p = new Person(input[0], input[1], int.Parse(input[2]), decimal.Parse(input[3]));
                person.Add(p);
                
            }
            for (int i = 0; i < N; i++)
            {
                team.AddPlayer(person[i]);
            }
            //Console.WriteLine(team.FirstTeam);
            //Console.WriteLine(team.ReserveTeam);

        }
    }
}
