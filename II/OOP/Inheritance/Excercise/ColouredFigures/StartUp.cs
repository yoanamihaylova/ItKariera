using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColouredFigures
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ').ToArray();
                if (line[0] == "Circle")
                {
                    Circle circle = new Circle(line[1], double.Parse(line[2]));
                    Console.WriteLine(circle.GetName());
                    circle.Show();
                    Console.WriteLine($"Area: {circle.GetArea():f2}");
                }
                if (line[0] == "Square")
                {
                     Square square = new Square(line[1], double.Parse(line[2]));
                    Console.WriteLine(square.GetName());
                    square.Show();
                    Console.WriteLine($"Area: {square.GetArea():f2}");
                }
                if (line[0] == "Triangle")
                {
                    Triangle triangle = new Triangle(line[1], double.Parse(line[2]));
                    Console.WriteLine(triangle.GetName());
                    triangle.Show();
                    Console.WriteLine($"Area: {triangle.GetArea():f2}");
                }
            }
        }
    }
}
