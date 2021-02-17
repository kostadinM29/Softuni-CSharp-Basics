using System;

namespace cruiseShip
{
    class Program
    {
        static void Main(string[] args)
        {
            string cruiseType = Console.ReadLine();
            string roomType = Console.ReadLine();
            double rooms = double.Parse(Console.ReadLine());

            double price = 0;

            if (cruiseType == "Mediterranean")
            {
                switch (roomType)
                {
                    case "standard cabin":
                        price = 27.50;
                        break;
                    case "cabin with balcony":
                        price = 30.20;
                        break;
                    case "apartment":
                        price = 40.50;
                        break;
                }
            }
            if (cruiseType == "Adriatic")
            {
                switch (roomType)
                {
                    case "standard cabin":
                        price = 22.99;
                        break;
                    case "cabin with balcony":
                        price = 25.00;
                        break;
                    case "apartment":
                        price = 34.99;
                        break;
                }
            }
            if (cruiseType == "Aegean")
            {
                switch (roomType)
                {
                    case "standard cabin":
                        price = 23.00;
                        break;
                    case "cabin with balcony":
                        price = 26.60;
                        break;
                    case "apartment":
                        price = 39.80;
                        break;
                }
            }
            double total = (price * rooms)*4;
            if (rooms > 7)
            {
                Console.WriteLine($"Annie's holiday in the {cruiseType} sea costs {total -(total *0.25):F2} lv.");
            }
            else
            {
                Console.WriteLine($"Annie's holiday in the {cruiseType} sea costs {total:F2} lv.");
            }
        }
    }
}
