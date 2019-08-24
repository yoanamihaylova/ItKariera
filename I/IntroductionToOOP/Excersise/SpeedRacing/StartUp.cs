using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
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
                Car car = new Car(input[0], int.Parse(input[1]), double.Parse(input[2]));
                cars.Add(car);
            }
            string line = Console.ReadLine();
            while(line!="End")
            {
                var input = line.Split(' ').ToArray();
                foreach (var item in cars)
                { 
                    if (input[1] == item.Model) item.Calculate(int.Parse(input[2]));  
                }
                line = Console.ReadLine();
            }
            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount:f2} {item.TraveledDistance}");
            }
        }
    }
}