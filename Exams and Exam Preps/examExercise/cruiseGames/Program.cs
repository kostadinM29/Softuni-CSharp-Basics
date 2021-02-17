using System;

namespace cruiseGames
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double games = double.Parse(Console.ReadLine());

            double totalpoints = 0;
            double volpoints = 0;
            double badpoints = 0;
            double tenpoints = 0;
            double volcount = 0;
            double badcount = 0;
            double tencount = 0;

            for (int i = 1; i <= games; i++)
            {
                string gameName = Console.ReadLine();
                double points = double.Parse(Console.ReadLine());

                switch (gameName)
                {
                    case "volleyball":
                        totalpoints += points + (points * 0.07);
                        volpoints += points + (points * 0.07);
                        volcount++;
                        break;
                    case "badminton":
                        totalpoints += points + (points * 0.02);
                        badpoints += points + (points * 0.02);
                        badcount++;
                        break;
                    case "tennis":
                        totalpoints += points + (points * 0.05);
                        tenpoints += points + (points * 0.05);
                        tencount++;
                        break;
                }
            }
            double score = Math.Floor(totalpoints / games);

            if ((tenpoints / tencount) > 75 && (badpoints / badcount) > 75 && (volpoints / volcount) > 75)
            {
                Console.WriteLine($"Congratulations, {name}! You won the cruise games with {Math.Floor(totalpoints)} points.");
            }
            else
            {
                Console.WriteLine($"Sorry, {name}, you lost. Your points are only {Math.Floor(totalpoints)}.");
            }



        }
    }
}
