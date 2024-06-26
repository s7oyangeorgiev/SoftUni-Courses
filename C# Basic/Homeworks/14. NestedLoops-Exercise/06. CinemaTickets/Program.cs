
int tottalTickets = 0;
int studentTicketCounter = 0;
int standartTicketCounter = 0;
int kidTicketCounter = 0;

while (true)
{
    string nameOfMovie = Console.ReadLine();

    if (nameOfMovie == "Finish")
    {
        Console.WriteLine($"Total tickets: {tottalTickets}");
        Console.WriteLine($"{(double)studentTicketCounter / tottalTickets * 100:f2}% student tickets.");
        Console.WriteLine($"{(double)standartTicketCounter / tottalTickets * 100:f2}% standard tickets.");
        Console.WriteLine($"{(double)kidTicketCounter / tottalTickets * 100:f2}% kids tickets.");
        break;
    }

    int freeSeats = int.Parse(Console.ReadLine());
    int seatsFilled = 0;

    for (int i = 0; i < freeSeats; i++)
    {
        string tipeOfTicket = Console.ReadLine();

        if (tipeOfTicket == "End")
        {
            break;
        }
        else if (tipeOfTicket == "student")
        {
            studentTicketCounter++;
        }
        else if (tipeOfTicket == "standard")
        {
            standartTicketCounter++;
        }
        else if (tipeOfTicket == "kid")
        {
            kidTicketCounter++;
        }
        seatsFilled++;
        tottalTickets++;
    }

    double percentFilled = ((double)seatsFilled / freeSeats) * 100;
    Console.WriteLine($"{nameOfMovie} - {percentFilled:f2}% full.");

    
}

