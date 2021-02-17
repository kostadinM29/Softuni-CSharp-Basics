using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int bakers = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double cakesSold = cakes * 45;
            double wafflesSold = waffles * 5.80;
            double pancakesSold = pancakes * 3.20;
            double onedayproduce = (cakesSold + wafflesSold + pancakesSold) * bakers;
            double totalproduce = onedayproduce * days;
            double totalproduceminusexpenses = totalproduce - (totalproduce / 8);

            Console.WriteLine($"{totalproduceminusexpenses:f2}");

        }
    }
}
