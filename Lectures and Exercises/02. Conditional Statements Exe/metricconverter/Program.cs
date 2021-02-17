using System;

namespace metricconverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            string inputtext = Console.ReadLine();
            string outputtext = Console.ReadLine();
            double result = 0.0;


            if (inputtext == "m")
            {
                if (outputtext == "cm")
                {
                    result = input / 0.010;
                    Console.WriteLine($"{result:f3}");
                }
                else
                {
                    result = input / 0.001;
                    Console.WriteLine($"{result:f3}");
                }
            }
            else if (inputtext == "cm")
            {
                if (outputtext == "m")
                {
                    result = input / 100;
                    Console.WriteLine($"{result:f3}");
                }
                else
                {
                    result = input / 0.1;
                    Console.WriteLine($"{result:f3}");
                }
            }
            else
            {
                if (outputtext == "m")
                {
                    result = input / 1000 ;
                    Console.WriteLine($"{result:f3}");
                }
                else
                {
                    result = input / 10;
                    Console.WriteLine($"{result:f3}");
                }
            }
        }
    }
}
