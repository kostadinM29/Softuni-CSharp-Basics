using System;

namespace summerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            string clothes = "";
            string shoes = "";

            if (temp >= 10 && temp <= 18)
            {
                if (time == "Morning")
                {
                    clothes = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (time == "Afternoon" || time == "Evening")
                {
                    clothes = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (temp > 18 && temp <= 24)
            {
                if (time == "Morning" || time == "Evening")
                {
                    clothes = "Shirt";
                    shoes = "Moccasins";
                }
                else if (time == "Afternoon")
                {
                    clothes = "T-Shirt";
                    shoes = "Sandals";
                }
            }
            else if (temp >= 25)
            {
                if (time == "Morning")
                {
                    clothes = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (time == "Afternoon")
                {
                    clothes = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (time == "Evening")
                {
                    clothes = "Shirt";
                    shoes = "Moccasins";
                }
            }
            Console.WriteLine($"It's {temp} degrees, get your {clothes} and {shoes}.");

        }
    }
}
