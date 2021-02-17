using System;

namespace dartsTourney
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingPoints = int.Parse(Console.ReadLine());
            bool isWon = false;
            bool bullseye = false;
            int moves = 0;
            while (!isWon)
            {
                string sector = Console.ReadLine();
                moves++;
                if (sector == "bullseye")
                {
                    bullseye = true;
                    break;
                }
                int points = int.Parse(Console.ReadLine());
                    switch (sector)
                {
                    case "number section":
                        startingPoints -= points;
                        break;
                    case "double ring":
                        startingPoints -= points * 2;
                        break;
                    case "triple ring":
                        startingPoints -= points * 3;
                        break;
                }
                if (startingPoints < 0)
                {
                    break;
                }
                if (startingPoints == 0)
                {
                    isWon = true;
                    break;
                }
            }
            if (isWon)
            {
                Console.WriteLine($"Congratulations! You won the game in {moves} moves!");
            }
            if (bullseye)
            {
                Console.WriteLine($"Congratulations! You won the game with a bullseye in {moves} moves!");
            }
            if (startingPoints < 0)
            {
                Console.WriteLine($"Sorry, you lost. Score difference: {Math.Abs(startingPoints)}.");
            }
        }
    }
}
