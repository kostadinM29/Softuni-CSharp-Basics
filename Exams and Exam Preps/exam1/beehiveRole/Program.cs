using System;
using System.Reflection.Metadata.Ecma335;

namespace beehiveRole
{
    class Program
    {
        static void Main(string[] args)
        {
            int intel = int.Parse(Console.ReadLine());
            int stren = int.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            if (intel >= 80 && stren >=80 & gender == "female")
            {
                Console.WriteLine("Queen Bee");
            }
            else if (intel >= 80)
            {
                Console.WriteLine("Repairing Bee");
            }
            else if (intel >= 60)
            {
                Console.WriteLine("Cleaning Bee");
            }
            else if (stren >=80 &&gender == "male")
            {
                Console.WriteLine("Drone Bee");
            }
            else if (stren >= 60)
            {
                Console.WriteLine("Guard Bee");
            }
            else
            {
                Console.WriteLine("Worker Bee");
            }
        }
    }
}
