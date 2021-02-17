using System;

namespace beeReserves
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededHoney = double.Parse(Console.ReadLine());
            double yield = 0;
            while (true)
            {
                string name = Console.ReadLine();
                if (name == "Winter has come")
                {
                    break;
                }
                for (int i = 1; i <= 6; i++)
                {
                    double input = double.Parse(Console.ReadLine());
                    yield += input;
                }
                if (yield < 0)
                {
                    Console.WriteLine($"{name} was banished for gluttony");
                }
                if (yield >= neededHoney)
                {
                    Console.WriteLine($"Well done! Honey surplus {yield - neededHoney:f2}.");
                    break;
                }
            }
            if (yield < neededHoney)
            {
                    Console.WriteLine($"Hard Winter! Honey needed {neededHoney - yield:f2}.");
            }
           
        }
    }
}
