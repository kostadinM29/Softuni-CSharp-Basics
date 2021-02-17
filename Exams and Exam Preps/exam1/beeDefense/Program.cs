using System;

namespace beeDefense
{
    class Program
    {
        static void Main(string[] args)
        {
            int bees = int.Parse(Console.ReadLine());
            int health = int.Parse(Console.ReadLine());
            int attack = int.Parse(Console.ReadLine());
            while (true)
            {
                bees -= attack;
                health -= (bees * 5);
                if (bees < 0)
                {
                    bees = 0;
                }
                if (health <= 0)
                {
                    Console.WriteLine($"Beehive won! Bees left {bees}.");
                    break;
                }
                if (bees < 100)
                {
                    Console.WriteLine($"The bear stole the honey! Bees left {bees}.");
                    break;
                }
            }
        }
    }
}
