using System;

namespace beehive
{
    class Program
    {
        static void Main(string[] args)
        {
            int bees = int.Parse(Console.ReadLine());
            int flowers = int.Parse(Console.ReadLine());

            double honey = bees * flowers * 0.21;
            double honeyCombs = Math.Floor(honey / 100);
            double leftover = honey % 100;
            Console.WriteLine($"{honeyCombs} honeycombs filled.");
            Console.WriteLine($"{leftover:f2} grams of honey left.");
        }
    }
}
