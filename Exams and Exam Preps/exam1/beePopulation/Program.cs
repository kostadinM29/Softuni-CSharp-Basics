using System;

namespace beePopulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingPop = int.Parse(Console.ReadLine());
            int years = int.Parse(Console.ReadLine());
            for (int i = 1; i <= years; i++)
            {
               
                    startingPop += startingPop /10 * 2;
                    if (i % 5 == 0)
                    {
                        startingPop -= startingPop / 50 * 5;
                    }
                    startingPop -= startingPop / 20 * 2;
                    if (i == years)
                    {
                        
                        break;
                    }
              
            }
            Console.WriteLine($"Beehive population: {startingPop}");



        }
    }
}
