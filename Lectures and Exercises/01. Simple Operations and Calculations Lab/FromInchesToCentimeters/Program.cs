using System;

namespace FromInchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double inches = double.Parse(Console.ReadLine());
            double centimeter = inches * 2.54;

            Console.WriteLine(centimeter);
        }
    }
}
