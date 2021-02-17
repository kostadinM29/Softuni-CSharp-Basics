using System;

namespace AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyprice = double.Parse(Console.ReadLine());
            double beer = double.Parse(Console.ReadLine());
            double wine = double.Parse(Console.ReadLine());
            double rakia = double.Parse(Console.ReadLine());
            double whiskey = double.Parse(Console.ReadLine());

            double rakiaprice = whiskeyprice / 2;
            double wineprice = rakiaprice - (0.4 * rakiaprice);
            double beerprice = rakiaprice - (0.8 * rakiaprice);
            double rakiasum = rakia * rakiaprice;
            double winesum = wine * wineprice;
            double beersum = beer * beerprice;
            double whiskeysum = whiskey * whiskeyprice;
            double totalsum = rakiasum + winesum + beersum + whiskeysum;

            Console.WriteLine($"{totalsum:f2}");

        }
    }
}
