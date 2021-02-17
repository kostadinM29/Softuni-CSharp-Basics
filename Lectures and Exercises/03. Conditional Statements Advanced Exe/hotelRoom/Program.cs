using System;

namespace hotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double nights = double.Parse(Console.ReadLine());
            double priceStudio = 0;
            double priceApartment = 0;

            if (month == "May" || month == "October")
            {
                if (nights <= 7)
                {
                    priceStudio = 50;
                    priceApartment = 65;
                }
                if (nights > 7)
                {
                    priceStudio = 50 * 0.95;
                    priceApartment = 65;
                }
                if (nights > 14)
                {
                    priceStudio = 50 * 0.70;
                    priceApartment = 65 * 0.90;
                }
            }
            if (month == "June" || month == "September")
            {
                if (nights > 14)
                {
                    priceStudio = 75.20 * 0.80;
                    priceApartment = 68.70 * 0.90;
                }
                else
                {
                    priceStudio = 75.20;
                    priceApartment = 68.70;
                }
            }
            if (month == "July" || month == "August")
            {
                if (nights > 14)
                {
                    priceStudio = 76;
                    priceApartment = 77 * 0.90;
                }
                else
                {
                    priceStudio = 76;
                    priceApartment = 77;
                }
            }
            Console.WriteLine($"Apartment: {nights * priceApartment:F2} lv.");
            Console.WriteLine($"Studio: {nights * priceStudio:F2} lv.");
        }
    }
}
