using System;

namespace trainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            double trainers = double.Parse(Console.ReadLine());
            string presentation = Console.ReadLine();
            int presentCount = 0;
            double totalScore = 0;
            while (presentation != "Finish")
            {
                double presentScore = 0;
                for (int i = 0; i < trainers; i++)
                {
                    double score = double.Parse(Console.ReadLine());
                    presentScore += score;
                }
                totalScore += presentScore;
                presentCount++;
                Console.WriteLine($"{presentation} - {presentScore / trainers:F2}.");
                presentation = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {(totalScore / trainers) / presentCount:F2}.");
        }
    }
}
