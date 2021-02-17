using System;

namespace vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double savedMoney = double.Parse(Console.ReadLine());
            int dayCounter = 0;
            int spendingCounter = 0;

            while (savedMoney < neededMoney && spendingCounter < 5)
            {
                string action = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                dayCounter++;
                if (action == "save")
                {
                    savedMoney += money;
                    spendingCounter = 0;
                }
                else if (action == "spend")
                {
                    savedMoney -= money;
                    spendingCounter += 1;
                    if (savedMoney < 0)
                    {
                        savedMoney = 0;
                    }
                }
            }
            if (spendingCounter == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(dayCounter);
            }
            if (savedMoney >= neededMoney)
            {
                Console.WriteLine($"You saved the money for {dayCounter} days.");
            }
        }
    }
}
