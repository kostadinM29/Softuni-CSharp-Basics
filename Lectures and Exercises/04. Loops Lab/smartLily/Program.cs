using System;

namespace smartLily
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            double washPrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());
            double rwrwrwrwrw = 0;
            double toycount = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    rwrwrwrwrw += i * 5 - 1;
                }
                else
                {
                    toycount += toyPrice;
                }
            }
            double savings = rwrwrwrwrw + toycount;
            if (savings >= washPrice)
            {
                Console.WriteLine($"Yes! {savings - washPrice:F2}");
            }
            else
            {
                Console.WriteLine($"No! {washPrice - savings:F2}");
            }
        }
    }
}
