using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelMeans
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ').ToArray();
            Car car = new Car(double.Parse(line[1]),double.Parse(line[2]));
            line = Console.ReadLine().Split(' ').ToArray();
            Truck truck = new Truck(double.Parse(line[1]), double.Parse(line[2]));
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                line = Console.ReadLine().Split(' ').ToArray();
                if(line[1] == "Car")
                {
                    if(line[0] == "Drive")
                    {
                        car.Drive(double.Parse(line[2]));
                    }
                    else
                    {
                        car.Fueling(double.Parse(line[2]));
                    }
                }
                else
                {
                    if (line[0] == "Drive")
                    {
                        truck.Drive(double.Parse(line[2]));
                    }
                    else
                    {
                        truck.Fueling((double.Parse(line[2]))*0.95);
                    }
                }
                
            }
            Console.WriteLine(car.ToString());
            Console.WriteLine( truck.ToString());
            //(truck_fuel = 95% * fuel)
            
        }
    }
}


