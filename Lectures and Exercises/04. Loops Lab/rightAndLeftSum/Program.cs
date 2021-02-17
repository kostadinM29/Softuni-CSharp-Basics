using System;

namespace rightAndLeftSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int leftsum = 0;
            int rightsum = 0;

            for (int i = 0; i < n; i++)
            {
                int left = int.Parse(Console.ReadLine());
                leftsum += left;
            }
            for (int i = 0; i < n; i++)
            {
                int right = int.Parse(Console.ReadLine());
                rightsum += right;
            }
            if (rightsum == leftsum)
            {
                Console.WriteLine($"Yes, sum = {leftsum}");
            }
            else
            {
                int diff = 0;
                if (rightsum < leftsum)
                {
                    diff = leftsum - rightsum;
                }
                else
                {
                    diff = rightsum -leftsum;
                }
                Console.WriteLine($"No, diff = {diff}");
            }
        }
    }
}
