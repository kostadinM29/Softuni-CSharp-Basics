using System;

namespace fishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());
            double rent = 0;

            switch (season)
            {
                case "Spring":
                    rent = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    rent = 4200;
                    break;
                case "Winter":
                    rent = 2600;
                    break;
            }
            if (people <= 6)
            {
                rent *= 0.90;
            }
            else if (people >= 7 && people <= 11)
            {
                rent *= 0.85;
            }
            else if (people >= 12)
            {
                rent *= 0.75;
            }
            if (people % 2 == 0)
            {
                if (season == "Winter" || season == "Summer" || season == "Spring")
                {
                    rent *= 0.95;
                }
            }
            if (budget < rent)
            {
                Console.WriteLine($"Not enough money! You need {rent - budget:F2} leva.");
            }
            else
            {
                Console.WriteLine($"Yes! You have {budget - rent:F2} leva left.");
            }
        }
    }
}
