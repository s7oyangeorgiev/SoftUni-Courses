
int vaucherValue = int.Parse(Console.ReadLine());

int ticketCounter = 0;
int otherCounter = 0;

while (true)
{
    string purchase = Console.ReadLine();

    if (purchase == "End")
    {
        break;
    }
    if (vaucherValue <= 0)
    {
        break;
    }

    if (purchase.Length > 8)
    {
        char first = purchase[0];
        char second = purchase[1];
        int ticketPrice = (int)first + (int)second;

        if (ticketPrice > vaucherValue)
        {
            break;
        }
        else
        {
            vaucherValue -= ticketPrice;
            ticketCounter++;
        }
    }

    if (purchase.Length <= 8)
    {
        char first = purchase[0];
        int otherPrice = (int)first;
        
        if (otherPrice > vaucherValue)
        {
            break;
        }
        else
        {
            vaucherValue -= otherPrice;
            otherCounter++;
        }
    }
}
Console.WriteLine($"{ticketCounter}");
Console.WriteLine($"{otherCounter}");
