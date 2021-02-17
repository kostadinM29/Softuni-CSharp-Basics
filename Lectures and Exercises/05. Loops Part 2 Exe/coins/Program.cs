using System;

namespace coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());
            int coinsCounter = 0;
            bool changeNotGiven = true;
            
            while (changeNotGiven)
            {
                if (Math.Round(change, 2) >= 2.00)
                {
                    change -= 2.00;
                    coinsCounter++;
                    continue;
                }
                else if (Math.Round(change, 2) >= 1.00)
                {
                    change -= 1.00;
                    coinsCounter++;
                    continue;
                }
                else if (Math.Round(change, 2) >= 0.50)
                {
                    change -= 0.50;
                    coinsCounter++;
                    continue;
                }
                else if (Math.Round(change, 2) >= 0.20)
                {
                    change -= 0.20;
                    coinsCounter++;
                    continue;
                }
                else if (Math.Round(change, 2) >= 0.10)
                {
                    change -= 0.10;
                    coinsCounter++;
                    continue;
                }
                else if (Math.Round(change, 2) >= 0.05)
                {
                    change -= 0.05;
                    coinsCounter++;
                    continue;
                }
                else if (Math.Round(change, 2) >= 0.02)
                {
                    change -= 0.02;
                    coinsCounter++;
                    continue;
                }
                else if (Math.Round(change,2) >= 0.01)
                {
                    change -= 0.01;
                    coinsCounter++;
                    continue;
                }
                if (Math.Round(change, 2) <= 0.00)
                {
                    changeNotGiven = false;
                    break;
                }
            }
            
            Console.WriteLine(coinsCounter);
        }
    }
}
