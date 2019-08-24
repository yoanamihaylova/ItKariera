using System;

namespace RectangularParallelepiped
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Box object1 = new Box(length, width, height);
            Console.WriteLine($"Surface Area - {object1.SurfaceArea(object1.Lenght,object1.Width,object1.Height):f2}");
            Console.WriteLine($"Lateral Surface Area - {object1.LateralSurfaceArea(object1.Lenght, object1.Width, object1.Height):f2}");
            Console.WriteLine($"Volume - {object1.Volume(object1.Lenght, object1.Width, object1.Height):f2}");
        }
    }
}
