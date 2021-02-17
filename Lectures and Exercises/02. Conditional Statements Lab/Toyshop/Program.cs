using System;

namespace Toyshop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripprice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double sum = (puzzles * 2.60) + (dolls * 3) + (bears * 4.10) + (minions * 8.20) + (trucks * 2);
            double toystotal = puzzles + dolls + bears + minions + trucks;
            
            if (toystotal >= 50)
            {
                double discount = sum * 0.25;
                double reducedsum = sum - discount;
                double rent = reducedsum * 0.10;
                double profit = reducedsum - rent;
                if (profit >= tripprice)
                { 
                double leftovers = profit - tripprice;
                    Console.WriteLine($"Yes! {leftovers:f2} lv left.");
                }
                else
                {
                    double leftovers = tripprice - profit;
                    Console.WriteLine($"Not enough money! {leftovers:f2} lv needed.");
                }
            }
            else
            {
                double rent = sum * 0.10;
                double profit = sum - rent;
                if (profit >= tripprice)
                { 
                double leftovers = profit - tripprice;
                    Console.WriteLine($"Yes! {leftovers:f2} lv left.");
                }
                else
                {
                    double leftovers = tripprice - profit;
                    Console.WriteLine($"Not enough money! {leftovers:f2} lv needed.");
                }
            }

        }
    }
}
