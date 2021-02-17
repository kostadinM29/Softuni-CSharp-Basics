using System;

namespace TextileWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int tables = int.Parse(Console.ReadLine());
            double lengthTable = double.Parse(Console.ReadLine());
            double widthTable = double.Parse(Console.ReadLine());

            double tableclotharea = tables * (lengthTable + 2 * 0.30) * (widthTable + 2 * 0.30);
            double checkarea = tables * (lengthTable / 2) * (lengthTable / 2);

            double priceinusd = (tableclotharea * 7) + (checkarea * 9);
            double priceinbgn = priceinusd * 1.85;

            Console.WriteLine($"{priceinusd:f2} USD");
            Console.WriteLine($"{priceinbgn:f2} BGN");
        }
    }
}
