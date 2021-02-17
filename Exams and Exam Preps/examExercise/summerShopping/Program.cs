using System;

namespace summerShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double towelPrice = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());


            double umbrellaPrice = towelPrice * 2 / 3;
            double flipflopsPrice = umbrellaPrice * 0.75;
            double handbagPrice = (towelPrice + flipflopsPrice) * 1 / 3;
            double totalSum = towelPrice + umbrellaPrice + flipflopsPrice + handbagPrice;
            double discountedSum = totalSum - (totalSum * (discount / 100));
            if (budget >= discountedSum)
            {
                Console.WriteLine($"Annie's sum is {discountedSum:F2} lv. She has {budget - discountedSum:F2} lv. left.");
            }
            else
            {
                Console.WriteLine($"Annie's sum is {discountedSum:F2} lv. She needs {Math.Abs(budget - discountedSum):F2} lv. more."
);
            }
        }
    }
}
