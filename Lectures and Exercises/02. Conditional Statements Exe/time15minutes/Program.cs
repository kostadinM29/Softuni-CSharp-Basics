    using System;

    namespace time15minutes
    {
        class Program
        {
            static void Main(string[] args)
            {
                int inputhour = int.Parse(Console.ReadLine());
                int inputminute = int.Parse(Console.ReadLine());
                int addedminute = inputminute + 15;
            

                if (inputminute >= 45)
                {

                    int outputminute = addedminute % 60;
                    int addedhour = inputhour + 1;
                    int outputhour = addedhour % 24;
                    Console.WriteLine($"{outputhour}:{outputminute:D2}");
                }
                if (inputminute <=44 )
                {
                    Console.WriteLine($"{inputhour}:{addedminute:D2}");
                }
            }
        }
    }
