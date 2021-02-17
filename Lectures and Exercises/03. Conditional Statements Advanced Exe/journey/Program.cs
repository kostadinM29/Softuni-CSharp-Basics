using System;

namespace journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double budgetSpent = 0;
            string where = "";
            string restsite = "";

            if (budget <= 100)
            {
                where = "Bulgaria";
                if (season == "summer")
                {
                    budgetSpent = 0.30;
                    restsite = "Camp";
                }
                else if (season == "winter")
                {
                    budgetSpent = 0.70;
                    restsite = "Hotel";
                }
            }
            else if (budget <= 1000)
            {
                where = "Balkans";
                if (season == "summer")
                {
                    budgetSpent = 0.40;
                    restsite = "Camp";
                }
                else if (season == "winter")
                {
                    budgetSpent = 0.80;
                    restsite = "Hotel";
                }
            }
            else if (budget > 1000)
            {
                where = "Europe";
                if (season == "summer")
                {
                    budgetSpent = 0.90;
                    restsite = "Hotel";
                }
                else if (season == "winter")
                {
                    budgetSpent = 0.90;
                    restsite = "Hotel";
                }
            }
            Console.WriteLine($"Somewhere in {where}");
            Console.WriteLine($"{restsite} - {budget * budgetSpent:F2}");
        }
    }
}
