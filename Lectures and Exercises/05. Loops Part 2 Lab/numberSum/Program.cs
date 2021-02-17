using System;

namespace numberSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sum = 0;
            
            while ( input != "Stop")
            {
                sum += Convert.ToInt32(input);
                input = Console.ReadLine();
            }
            Console.WriteLine(sum);

            
        }
    }
}
