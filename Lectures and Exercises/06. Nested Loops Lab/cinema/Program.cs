using System;

namespace cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalTickets = 0;
            int student = 0;
            int standart = 0;
            int kids = 0;

            while (true)
            {
                string movie = Console.ReadLine();
                if (movie == "Finish")
                {
                    break;

                }
                int capacity = int.Parse(Console.ReadLine());
                int movieTickets = 0;
                while (true)
                {
                    string ticketType = Console.ReadLine();
                    if (ticketType == "End")
                    {
                        break;
                    }
                    switch (ticketType)
                    {
                        case "student":
                            student++;
                            break;
                        case "standard":
                            standart++;
                            break;
                        case "kid":
                            kids++;
                            break;
                    }
                    movieTickets++;
                    if (movieTickets >= capacity)
                    {
                        break;
                    }
                }
                Console.WriteLine($"{movie} - {100.0 * movieTickets / capacity:f2}% full.");
                totalTickets += movieTickets;
            }
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{100.0 * student / totalTickets:f2}% student tickets.");
            Console.WriteLine($"{100.0 * standart / totalTickets:f2}% standard tickets.");
            Console.WriteLine($"{100.0 * kids / totalTickets:f2}% kids tickets.");
        }
    }
}
