using System;

namespace ProjectCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameArch = Console.ReadLine();
            int projectCount = int.Parse(Console.ReadLine());


            int requiredHours = projectCount * 3;

            Console.WriteLine($"The architect {nameArch} will need {requiredHours} hours to complete {projectCount} project/s.");

        }
    }
}
