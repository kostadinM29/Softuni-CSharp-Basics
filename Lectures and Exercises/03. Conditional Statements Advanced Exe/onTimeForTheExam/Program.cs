using System;

namespace onTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());

            examMinute += examHour * 60;
            arrivalMinute += arrivalHour * 60;


            if (arrivalMinute > examMinute)
            {
                Console.WriteLine("Late");
                int difference = arrivalMinute - examMinute;
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes after the start");
                }
                else
                {
                    int hour = difference / 60;
                    int minutes = difference % 60;
                    Console.WriteLine($"{hour}:{minutes:D2} hours after the start");
                }
            }
            else if (arrivalMinute < examMinute - 30)
            {
                Console.WriteLine("Early");
                int difference = examMinute - arrivalMinute;
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else
                {
                    int hour = difference / 60;
                    int minutes = difference % 60;
                    Console.WriteLine($"{hour}:{minutes:D2} hours before the start");
                }
            }
            else
            {
                Console.WriteLine("On time");
                int difference = examMinute - arrivalMinute;
                Console.WriteLine($"{difference} minutes before the start");
            }
        }
    }
}
