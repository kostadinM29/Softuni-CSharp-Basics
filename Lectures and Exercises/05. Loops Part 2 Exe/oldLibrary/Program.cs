using System;

namespace oldLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            string target = Console.ReadLine();
            int bookNum = int.Parse(Console.ReadLine());
            for (int i = 1; i <= bookNum; i++)
            {
                string book = Console.ReadLine();
                if (book == target)
                {
                    Console.WriteLine($"You checked {i-1} books and found it.");
                    break;
                }
                else if (bookNum == i && target != book)
                {
                    Console.WriteLine($"The book you search is not here!");
                    Console.WriteLine($"You checked {i} books.");
                    break;
                }
            }
        }
    }
}
