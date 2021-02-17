using System;

namespace deviderWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double r1 = 0;
            double r2 = 0;
            double r3 = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    r1 += 1;
                }
                if (num % 3 == 0)
                {
                    r2 += 1;
                }
                if (num % 4 == 0)
                {
                    r3 += 1;
                }
            }
            double p1 = (r1 / n) * 100;
            double p2 = (r2 / n) * 100;
            double p3 = (r3 / n) * 100;
            Console.WriteLine($"{p1:F2}%");
            Console.WriteLine($"{p2:F2}%");
            Console.WriteLine($"{p3:F2}%");
        }
    }
}
