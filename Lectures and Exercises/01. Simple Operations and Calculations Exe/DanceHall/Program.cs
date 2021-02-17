using System;

namespace DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double L = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());

            double hallcm3 = (L * 100) * (W * 100);
            double wardrobe = (A * 100) * (A * 100);
            double bench = hallcm3 / 10;
            double freespace = hallcm3 - wardrobe - bench;
            double dancers = freespace / (40 + 7000);

            Console.WriteLine(Math.Floor(dancers));
        }
    }
}
