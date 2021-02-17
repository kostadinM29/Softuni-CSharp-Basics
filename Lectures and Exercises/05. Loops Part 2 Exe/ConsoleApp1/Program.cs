using System;

namespace cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakesizeOne = int.Parse(Console.ReadLine());
            int cakesizeTwo = int.Parse(Console.ReadLine());
            int cakeSize = cakesizeOne * cakesizeTwo;
            bool cakeNotEaten = true;
            int totalSlices = 0;

            while (cakeNotEaten)
            {
                string input = Console.ReadLine();
                if (input == "STOP")
                {
                    cakeNotEaten = false;
                    break;
                }
                int slices = int.Parse(input);
                totalSlices += slices;
                if (totalSlices > cakeSize)
                {
                    break;
                }
            }
            if (!cakeNotEaten)
            {
                Console.WriteLine($"{cakeSize - totalSlices} pieces are left.");
            }
            if (totalSlices > cakeSize)
            {
                Console.WriteLine($"No more cake left! You need {totalSlices - cakeSize} pieces more.");
            }
        }
    }
}
