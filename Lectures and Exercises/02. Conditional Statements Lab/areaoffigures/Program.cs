using System;

namespace areaoffigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeobject = Console.ReadLine();
            if (typeobject == "square")
            {
                double num1 = double.Parse(Console.ReadLine());
                double size = num1 * num1;

                Console.WriteLine($"{size:f3}");

            }
            else if (typeobject == "rectangle")
            {
                double num1 = double.Parse(Console.ReadLine());
                double num2 = double.Parse(Console.ReadLine());
                double size = num1 * num2;

                Console.WriteLine($"{size:f3}");
            }
            else if (typeobject == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double area = Math.PI * (radius * radius);

                Console.WriteLine($"{area:f3}");

            }
            else 
            {
                double num1 = double.Parse(Console.ReadLine());
                double num2 = double.Parse(Console.ReadLine());
                double size = ( num1 * num2 ) / 2;

                Console.WriteLine($"{size:f3}");
            }
        }
    }
}
