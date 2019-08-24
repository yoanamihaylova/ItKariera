using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            var cars = new List<Car>();
            for (int i = 0; i < N; i++)
            {
                var input = Console.ReadLine().Split(' ').ToArray();
                Car car = new Car(input[0], int.Parse(input[1]), int.Parse(input[2]), int.Parse(input[3]), input[4], double.Parse(input[5]), int.Parse(input[6]), double.Parse(input[7]), int.Parse(input[8]), double.Parse(input[9]), int.Parse(input[10]), double.Parse(input[11]), int.Parse(input[12]));
                cars.Add(car);
            }
            string type = Console.ReadLine();
            if(type == "fragile")
            {
                foreach (var item in cars)
                {
                    if (item.Cargo.Type == "fragile" && (item.Tire1.Pressure < 1 || item.Tire2.Pressure < 1 || item.Tire3.Pressure < 1 || item.Tire4.Pressure < 1)) Console.WriteLine(item.Model);
                }
            }
            else if(type == "flamable")
            {
                foreach (var item in cars)
                {
                    if (item.Engine.Power > 250) Console.WriteLine(item.Model);
                }
            }
        }
    }
}
