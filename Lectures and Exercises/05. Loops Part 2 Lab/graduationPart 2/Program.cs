using System;

namespace graduationPart_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double gradeSum = 0;
            int expellTracker = 0;
            for (int i = 0; i < 12; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade < 4)
                {
                    //i -= 1;
                    expellTracker += 1;
                    if (expellTracker >= 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {i} grade");
                        break;
                    }
                }
                else
                {
                    gradeSum += grade;
                }
            }
            if (expellTracker != 2)
            {
                Console.WriteLine($"{name} graduated. Average grade: {gradeSum / 12:F2}");
            }
        }
    }
}
