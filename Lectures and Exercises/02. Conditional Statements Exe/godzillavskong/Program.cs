using System;

namespace godzillavskong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double statists = double.Parse(Console.ReadLine());
            double pricePerStatist = double.Parse(Console.ReadLine());

            double decorTotal = budget * 0.10;
            double statistTotal = statists * pricePerStatist;
            if (statists >= 150)
            {
                double statistPriceReduction = statistTotal * 0.10;
                double statistTotalDiscounted = statistTotal - statistPriceReduction;
                double filmTotal = decorTotal + statistTotalDiscounted;
                double finalResult = filmTotal - budget;
                if (filmTotal <= budget)
                {
                    Console.WriteLine("Action!");
                    Console.WriteLine($"Wingard starts filming with {budget - filmTotal:F2} leva left.");
                }
                else
                {
                    Console.WriteLine("Not enough money!");
                    Console.WriteLine($"Wingard needs {filmTotal - budget:F2} leva more.");
                }

            }
            else
            {
                double filmTotal = statistTotal + decorTotal;
                double finalResult = filmTotal - budget;
                if (filmTotal <= budget)
                {
                    Console.WriteLine("Action!");
                    Console.WriteLine($"Wingard starts filming with {budget - filmTotal:F2} leva left.");
                }
                else
                {
                    Console.WriteLine("Not enough money!");
                    Console.WriteLine($"Wingard needs {filmTotal - budget:F2} leva more.");
                }
            }
        }
    }
}