using System;

namespace numbersequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            int numberMax = int.MinValue;
            int numberMin = int.MaxValue;
            for (int i = 0; i < numberCount; i++)
            {
                int currNumber = int.Parse(Console.ReadLine());
                if (currNumber > numberMax)
                {
                    numberMax = currNumber;
                }
                if (currNumber < numberMin)
                {
                    numberMin = currNumber;
                }
            }
            Console.WriteLine($"Max number: {numberMax}");
            Console.WriteLine($"Min number: {numberMin}");
        }
    }
}
