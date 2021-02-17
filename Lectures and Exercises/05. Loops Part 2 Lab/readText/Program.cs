using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readText
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Stop")
                {
                    break;
                }
                Console.WriteLine(input);
            }

        }
    }
}
