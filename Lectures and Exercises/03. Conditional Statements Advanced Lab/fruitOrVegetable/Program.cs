using System;

namespace fruitOrVegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "banana":
                case "kiwi":
                case "apple":
                case "cherry":
                case "lemon":
                case "grapes":
                    Console.WriteLine("fruit");
                    break;
                case "carrot":
                case "tomato":
                case "cucumber":
                case "pepper":
                    Console.WriteLine("vegetable");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
                
            }
        }
    }
}
