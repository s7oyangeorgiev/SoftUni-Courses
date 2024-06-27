
int tottalTickets = 0;
int ticketCounter = 0;
int studentTickets = 0;
int standartTicket = 0;
int kidTicket = 0;

while (true)
{
    string nameOfMovie = Console.ReadLine();
    ticketCounter = 0;

    if (nameOfMovie == "Finish")
    {
        Console.WriteLine($"Total tickets: {tottalTickets}");
        Console.WriteLine($"{((double)studentTickets / tottalTickets) * 100:f2}% student tickets.");
        Console.WriteLine($"{((double)standartTicket / tottalTickets) * 100:f2}% standard tickets.");
        Console.WriteLine($"{((double)kidTicket / tottalTickets) * 100:f2}% kids tickets.");
        break;
    }
    int freeSeets = int.Parse(Console.ReadLine());



    while (freeSeets > 0)
    {
        string ticketTipe = Console.ReadLine();

        if (ticketTipe == "student")
        {
            studentTickets++;
        }
        else if (ticketTipe == "standard")
        {
            standartTicket++;
        }
        else if (ticketTipe == "kid")
        {
            kidTicket++;
        }
        
        if (ticketTipe == "End")
        {
            double percentFullnessOfTheHall = ((double)ticketCounter / freeSeets) * 100;
            Console.WriteLine($"{nameOfMovie} - {percentFullnessOfTheHall:f2}% full.");
            break;
        }
        ticketCounter++;
        tottalTickets++;

        if (freeSeets == ticketCounter)
        {
            double percentFullnessOfTheHall = ((double)ticketCounter / freeSeets) * 100;
            Console.WriteLine($"{nameOfMovie} - {percentFullnessOfTheHall:f2}% full.");
            break;
        }
    }
}