﻿using System;

namespace invalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            if (number >= 100 && number <= 200)
            {

            }
            else if (number == 0)
            {

            }
            else
            {
                Console.WriteLine("invalid");
            }
            
        }
    }
}
