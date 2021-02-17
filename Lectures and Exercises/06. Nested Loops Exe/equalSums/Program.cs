using System;

namespace equalSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            for (int i = num1; i <= num2; i++)
            {
                string currNum = i.ToString();
                int oddSum = 0;
                int evenSum = 0;
                for (int n = 0; n < currNum.Length; n++)
                {
                    int currDigit = int.Parse(currNum[n].ToString());
                    if (n % 2 == 0)
                    {
                        evenSum += currDigit;
                    }
                    else
                    {
                        oddSum += currDigit;
                    }
                }
                if(oddSum == evenSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
