using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            int volume = lenght * width * height;
            double totalLitres = volume * 0.001;
            double percent2 = percent * 0.01;
            double neededLitres = totalLitres * (1 - percent2);





            Console.WriteLine("{0:F3}", neededLitres);


        }
    }
}
