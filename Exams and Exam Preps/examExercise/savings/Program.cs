using System;

namespace savings
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double month = double.Parse(Console.ReadLine());
            double neededMoney = double.Parse(Console.ReadLine());

            double personalMoney = income * 0.30;
            double savedMoney = income - (neededMoney + personalMoney);

            Console.WriteLine($"She can save {100 * (savedMoney / income):F2}%");
            Console.WriteLine($"{savedMoney * month:F2}");


        }
    }
}
