using System;

namespace operationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1 = double.Parse(Console.ReadLine());
            double N2 = double.Parse(Console.ReadLine());
            string operators = Console.ReadLine();
            double result = 0;


            if (operators == "+" || operators == "-" || operators == "*")
            {
                if (operators == "+")
                {
                    result = N1 + N2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{N1} + {N2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{N1} + {N2} = {result} - odd");
                    }
                }
                else if (operators == "-")
                {
                    result = N1 - N2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{N1} - {N2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{N1} - {N2} = {result} - odd");
                    }
                }
                else if (operators == "*")
                {
                    result = N1 * N2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{N1} * {N2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{N1} * {N2} = {result} - odd");
                    }
                }
            }
            else if (operators == "/")
            {
                if (N2 != 0)
                {
                    Console.WriteLine($"{N1} / {N2} = { N1 / N2:F2}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
            }
            else if (operators == "%")
            {
                if (N2 != 0)
                {
                    Console.WriteLine($"{N1} % {N2} = {N1 % N2}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
            }
        }
    }
}
