using System;

namespace volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            double holidays = double.Parse(Console.ReadLine());
            double weekendsVill = double.Parse(Console.ReadLine());

            double weekendsSof = (48 - weekendsVill) * 3 / 4;
            double holidayPlay = holidays * 2 / 3;

            double games = weekendsSof + weekendsVill + holidayPlay;
            if(year == "leap")
            {
                double bonusgames =games + (games * 0.15);
                Console.WriteLine($"{Math.Floor(bonusgames)}");
            }
            else
            {
                Console.WriteLine($"{Math.Floor(games)}");
            }
        }
    }
}
