using System;

namespace newHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowerCount = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double price = 0;
            switch (flowerType)
            {
                case "Roses":
                    price = 5;
                    if (flowerCount > 80)
                    {
                        price *= 0.90;
                    }
                    break;

                case "Dahlias":
                    price = 3.80;
                    if (flowerCount > 90)
                    {
                        price *= 0.85;
                    }
                    break;

                case "Tulips":
                    price = 2.80;
                    if (flowerCount > 80)
                    {
                        price *= 0.85;
                    }
                    break;

                case "Narcissus":
                    price = 3.00;
                    if (flowerCount < 120)
                    {
                        price *= 1.15;
                    }
                    break;

                case "Gladiolus":
                    price = 2.50;
                    if (flowerCount < 80)
                    {
                        price *= 1.20;
                    }
                    break;
            }
            double totalPrice = price * flowerCount;
            if (budget >= totalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flowerType} and {budget - totalPrice:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {totalPrice - budget:F2} leva more.");
            }




        }
    }
}