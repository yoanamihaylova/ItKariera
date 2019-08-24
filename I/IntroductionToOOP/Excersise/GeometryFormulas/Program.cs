using System;

namespace GeometryFormulas
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "Rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine($"Rectangle area is: {Geometry.RectangleArea(a,b)}");
                Console.WriteLine($"Rectangle parameter is: {Geometry.RectanglePerimeter(a,b)}");
            }
            else if (type == "Square")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine($"Square area is: {Geometry.SquareArea(side)}");
                Console.WriteLine($"Square parameter is: {Geometry.SquarePerimeter(side)}");
            }
            else if (type == "Circle")
            {
                double r = double.Parse(Console.ReadLine());
                Console.WriteLine($"Circle area is: {Geometry.CircleArea(r)}");
            }
            else throw new ArgumentException("Invalid input type.");
        }
    }
}
