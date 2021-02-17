using System;

namespace fruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;
            

            if (day == "Saturday" || day == "Sunday")
            {
                if (product == "banana")
                {
                    price = 2.70;
                    Console.WriteLine($"{price * quantity:F2}");
                }
                else if (product == "apple")
                {
                    price = 1.25;
                    Console.WriteLine($"{price * quantity:F2}");
                }
                else if (product == "orange")
                {
                    price = 0.90;
                    Console.WriteLine($"{price * quantity:F2}");
                }
                else if (product == "grapefruit")
                {
                    price = 1.60;
                    Console.WriteLine($"{price * quantity:F2}");
                }
                else if (product == "kiwi")
                {
                    price = 3.00;
                    Console.WriteLine($"{price * quantity:F2}");
                }
                else if (product == "pineapple")
                {
                    price = 5.60;
                    Console.WriteLine($"{price * quantity:F2}");
                }
                else if (product == "grapes")
                {
                    price = 4.20;
                    Console.WriteLine($"{price * quantity:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                if (product == "banana")
                {
                    price = 2.50;
                    Console.WriteLine($"{price * quantity:F2}");
                }
                else if (product == "apple")
                {
                    price = 1.20;
                    Console.WriteLine($"{price * quantity:F2}");
                }
                else if (product == "orange")
                {
                    price = 0.85;
                    Console.WriteLine($"{price * quantity:F2}");
                }
                else if (product == "grapefruit")
                {
                    price = 1.45;
                    Console.WriteLine($"{price * quantity:F2}");
                }
                else if (product == "kiwi")
                {
                    price = 2.70;
                    Console.WriteLine($"{price * quantity:F2}");
                }
                else if (product == "pineapple")
                {
                    price = 5.50;
                    Console.WriteLine($"{price * quantity:F2}");
                }
                else if (product == "grapes")
                {
                    price = 3.85;
                    Console.WriteLine($"{price * quantity:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
            
        }
    }
}
