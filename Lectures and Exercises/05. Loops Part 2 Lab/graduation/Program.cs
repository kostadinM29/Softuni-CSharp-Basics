using System;

namespace graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double gradeSum = 0;
            for (int i = 0; i < 12; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade < 4)
                {
                    i -= 1;
                }
                else
                {
                    gradeSum += grade;
                }
            }
            Console.WriteLine($"{name} graduated. Average grade: {gradeSum / 12:F2}");
        }
    }
}
