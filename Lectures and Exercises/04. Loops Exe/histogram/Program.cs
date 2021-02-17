using System;

namespace histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double r1 = 0;
            double r2 = 0;
            double r3 = 0;
            double r4 = 0;
            double r5 = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 200)
                {
                    r1 += 1;
                }
                else if (num >= 200 && num <= 399)
                {
                    r2 += 1;
                }
                else if (num >= 400 && num <= 599)
                {
                    r3 += 1;
                }
                else if (num >= 600 && num <= 799)
                {
                    r4 += 1;
                }
                else if (num >= 800)
                {
                    r5 += 1;
                }
            }
            double p1 = (r1 / n) * 100;
            double p2 = (r2 / n) * 100;
            double p3 = (r3 / n) * 100;
            double p4 = (r4 / n) * 100;
            double p5 = (r5 / n) * 100;
            Console.WriteLine($"{p1:F2}%");
            Console.WriteLine($"{p2:F2}%");
            Console.WriteLine($"{p3:F2}%");
            Console.WriteLine($"{p4:F2}%");
            Console.WriteLine($"{p5:F2}%");
        }
    }
}
