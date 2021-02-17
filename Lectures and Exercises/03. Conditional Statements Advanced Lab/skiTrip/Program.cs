using System;

namespace skiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string grade = Console.ReadLine();
            int nights = days - 1;
            double discountedPrice = 0;
            double total = 0;
            double nightsPrice = 0;


            if (room == "apartment")
            {
                nightsPrice = nights * 25;
                if (nights < 10)
                {
                    discountedPrice = nightsPrice * 0.30;
                }
                if (nights >= 10 && nights <= 15)
                {
                    discountedPrice = nightsPrice * 0.35;
                }
                if (nights > 15)
                {
                    discountedPrice = nightsPrice * 0.50;
                }
            }
            else if (room == "president apartment")
            {
                nightsPrice = nights * 35;
                if (nights < 10)
                {
                    discountedPrice = nightsPrice * 0.10;
                }
                if (nights >= 10 && nights <= 15)
                {
                    discountedPrice = nightsPrice * 0.15;
                }
                if (nights > 15)
                {
                    discountedPrice = nightsPrice * 0.20;
                }
            }
            else if (room == "room for one person")
            {
                nightsPrice = nights * 18;
            }
            total = nightsPrice - discountedPrice;
            if (grade == "positive")
            {
                Console.WriteLine($"{total + (total * 0.25):F2}");
            }
            else if (grade == "negative")
            {
                Console.WriteLine($"{total - (total * 0.10):F2}");
            }
        }
    }
}
