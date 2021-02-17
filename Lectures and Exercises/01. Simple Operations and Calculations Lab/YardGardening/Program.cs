using System;

namespace YardGardening
{
    class Program
    {
        static void Main(string[] args)
        {
            double yardSpace = double.Parse(Console.ReadLine());
            double price = yardSpace * 7.61;
           
            double discount = 0.18 * price;



            Console.WriteLine($"The final price is: {price - discount:f2} lv.");
            Console.WriteLine($"The discount is: {discount:f2} lv.");
        }
    }
}
