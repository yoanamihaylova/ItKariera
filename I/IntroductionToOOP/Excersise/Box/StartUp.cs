using System;

namespace Box
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            try
            {
                Box box = new Box(lenght, width, height);
                Console.WriteLine("Surface Area - {0:f2}",box.SurfaceArea());
                Console.WriteLine("Lateral Surface Area - {0:f2}",box.LateralSurfaceArea());
                Console.WriteLine("Volume - {0:f2}",box.Volume());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
