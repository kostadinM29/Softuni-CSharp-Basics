using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            double minimumSalary = double.Parse(Console.ReadLine());


            double socialScholarship = 0;
            double excellentScholarship = 0;

            if (income < minimumSalary)
            {
                if (grade > 4.5)
                {
                   socialScholarship = minimumSalary * 0.35;
                }
            }
            if (grade >= 5.50)
            {
               excellentScholarship = grade * 25;
            }
            if (excellentScholarship  == 0)
            {
                if (socialScholarship == 0)
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
                else
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
                }
            }
            else if (socialScholarship == 0)
            {
                if (excellentScholarship == 0)
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
                else
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellentScholarship)} BGN");
                }
            }
            else
            {
                if (Math.Floor(socialScholarship) > Math.Floor(excellentScholarship))
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
                }
                else if (Math.Floor(socialScholarship) == Math.Floor(excellentScholarship))
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellentScholarship)} BGN");
                }
                else
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellentScholarship)} BGN");
                }
            }
        }
    }
}
