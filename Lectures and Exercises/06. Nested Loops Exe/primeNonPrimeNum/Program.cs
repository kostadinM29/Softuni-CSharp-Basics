using System;

namespace primeNonPrimeNum
{
    class Program
    {
        static void Main(string[] args)
        {
            bool CalcIsPrime(int number)
            {

                if (number == 1) return false;
                if (number == 2) return true;

                if (number % 2 == 0) return false; // Even number     

                for (int i = 2; i < number; i++)
                { // Advance from two to include correct calculation for '4'
                    if (number % i == 0) return false;
                }

                return true;

            }





            int primeCount = 0;
            int notPrimeCount = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }
                else
                {
                    int num = int.Parse(input);
                    if (num < 0)
                    {
                        Console.WriteLine("Number is negative.");
                    }
                    if (CalcIsPrime(num) && num > 0)
                    {
                        primeCount += num;
                    }
                    else if (num > 0)
                    {
                        notPrimeCount += num;
                    }

                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeCount}");
            Console.WriteLine($"Sum of all non prime numbers is: {notPrimeCount}");
        }
    }
}
