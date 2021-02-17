using System;

namespace accountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            int payments = int.Parse(Console.ReadLine());
            double total = 0;
            for (int i = 1; i <=payments; i++)
            {
                double input = double.Parse(Console.ReadLine());
                if (input < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else
                {
                    total += input;
                    Console.WriteLine($"Increase: {input:F2}");
                }
            }
            Console.WriteLine($"Total: {total:F2}");
        }
    }
}
