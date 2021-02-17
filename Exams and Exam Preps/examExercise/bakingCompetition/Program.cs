using System;
using System.Dynamic;

namespace bakingCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int contestants = int.Parse(Console.ReadLine());
            int totalBakery = 0;
            int totalcookies = 0;
            int totalcakes = 0;
            int totalwaffles = 0;
            int bakingCounter = 0;
            for (int i = 1; i <= contestants; i++)
            {
                while (!(bakingCounter == contestants))
                {
                    string name = Console.ReadLine();
                    int cookiecount = 0;
                    int cakecount = 0;
                    int wafflecount = 0;
                    while (true)
                    {
                        string desert = Console.ReadLine();
                        if (desert == "Stop baking!")
                        {
                            bakingCounter++;
                            break;
                        }
                        int count = int.Parse(Console.ReadLine());
                        totalBakery += count;
                        //int cookiecount = 0;
                        //int cakecount = 0;
                        //int wafflecount = 0;
                        switch (desert)
                        {
                            case "cookies":
                                cookiecount += count;
                                totalcookies += count;
                                break;
                            case "cakes":
                                cakecount += count;
                                totalcakes += count;
                                break;
                            case "waffles":
                                wafflecount += count;
                                totalwaffles += count;
                                break;
                        }
                        //Console.WriteLine($"{name} baked {cookiecount} cookies, {cakecount} cakes and {wafflecount} waffles.");
                    }
                    Console.WriteLine($"{name} baked {cookiecount} cookies, {cakecount} cakes and {wafflecount} waffles.");
                }
            }
            Console.WriteLine($"All bakery sold: {totalBakery}");
            Console.WriteLine($"Total sum for charity: {totalcookies * 1.50 + totalcakes * 7.80 + totalwaffles * 2.30:F2} lv.");
        }
    }
}