using System;

namespace sumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int comb = int.Parse(Console.ReadLine());
            int counter = 0;
            bool found = false;
            int x = 0;
            int y = 0;
            for (int i = num1; i <= num2; i++)
            {
                for (int i2 = num1; i2 <= num2; i2++)
                {
                    counter++;
                    if (i + i2 == comb)
                    {
                        x = i;
                        y = i2;
                        found = true;
                        break;
                    }
                }
                if (found)
                {
                    break;
                }
            }
            if (found)
            {
                Console.WriteLine($"Combination N:{counter} ({x} + {y} = {comb})");
            }
            else
            {
                    Console.WriteLine($"{counter} combinations - neither equals {comb}");
            }

        }
    }
}
