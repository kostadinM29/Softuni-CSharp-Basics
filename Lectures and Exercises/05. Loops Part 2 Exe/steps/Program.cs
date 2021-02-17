using System;

namespace steps
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalSteps = 0;
            bool goalNotReached = true;
            while (goalNotReached)
            {
                string input = Console.ReadLine();
                if (input == "Going home")
                {
                    int inputHome = int.Parse(Console.ReadLine());
                    totalSteps += inputHome;
                    if (totalSteps >= 10000)
                    {
                        goalNotReached = false;
                        break;
                    }
                    break;
                }
                totalSteps += int.Parse(input);
                if (totalSteps >= 10000)
                {
                    goalNotReached = false;
                    break;
                }

            }
            if (!goalNotReached)
            {
                Console.WriteLine("Goal reached! Good job!");
            }
            if (goalNotReached)
            {
                Console.WriteLine($"{10000 - totalSteps} more steps to reach goal.");
            }
        }
    }
}
