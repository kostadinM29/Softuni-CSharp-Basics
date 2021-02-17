using System;

namespace moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int total = 0;
            int roomsize = width * length * height;
           
            while (true)
            {
                string input = Console.ReadLine();
                if (roomsize < total)
                {
                    Console.WriteLine($"No more free space! You need {total - roomsize} Cubic meters more.");
                    break;
                }
                else if ( input == "Done")
                {
                    Console.WriteLine($"{roomsize - total} Cubic meters left.");
                    break;
                }
                total += int.Parse(input);
            }
        }
    }
}
