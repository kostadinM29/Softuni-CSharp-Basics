using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogCount = int.Parse(Console.ReadLine());
            int othersCount = int.Parse(Console.ReadLine());

            double dogExpenses = dogCount * 2.50;
            double othersExpenses = othersCount * 4.0;

            double totalSum = dogExpenses + othersExpenses;
            Console.WriteLine($"{totalSum:f2} lv.");


        }
    }
}
