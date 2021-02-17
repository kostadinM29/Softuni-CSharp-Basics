using System;

namespace beeHarvest
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int flowers = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int yield = 0;
            double bonus = 0;
            switch (flower)
            {
                case "Sunflower":
                    if (season == "Spring")
                    {
                        yield = 10;
                    }
                    else if (season == "Summer")
                    {
                        yield = 8;
                    }
                    else if (season == "Autumn")
                    {
                        yield = 12;
                    }
                    break;
                case "Daisy":
                    if (season == "Spring")
                    {
                        yield = 12;
                    }
                    else if (season == "Summer")
                    {
                        yield = 8;
                    }
                    else if (season == "Autumn")
                    {
                        yield = 6;
                    }
                    break;
                case "Lavender":
                    if (season == "Spring")
                    {
                        yield = 12;
                    }
                    else if (season == "Summer")
                    {
                        yield = 8;
                    }
                    else if (season == "Autumn")
                    {
                        yield = 6;
                    }
                    break;
                case "Mint":
                    if (season == "Spring")
                    {
                        yield = 10;
                    }
                    else if (season == "Summer")
                    {
                        yield = 12;
                    }
                    else if (season == "Autumn")
                    {
                        yield = 6;
                    }
                    break;
            }
            if (season == "Summer")
            {
                bonus = 1.10;
            }
            if (season == "Autumn")
            {
                bonus = 0.95;
            }
            if (season == "Spring")
            {
                if (flower == "Daisy" || flower == "Mint")
                {
                    bonus = 1.10;
                }
                else
                {
                    bonus = 1;
                }
            }
            Console.WriteLine($"Total honey harvested: {flowers * yield * bonus:F2}");
        }
    }
}
