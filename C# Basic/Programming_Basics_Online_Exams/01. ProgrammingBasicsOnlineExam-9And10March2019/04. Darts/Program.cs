
string nameOfPlayer = Console.ReadLine();

int playerPoints = 301;
int unsuccessfulTry = 0;
int shots = 0;

while (true)
{
    string area = Console.ReadLine();
    if (area == "Retire")
    {
        Console.WriteLine($"{nameOfPlayer} retired after {unsuccessfulTry} unsuccessful shots."); break;
    }
    int currentPoints = int.Parse(Console.ReadLine());

    switch (area)
    {
        case "Single":  
            if (currentPoints > playerPoints)
            {
                unsuccessfulTry++;
                break;
            }
            playerPoints -= currentPoints;
            shots++; break;
        case "Double": currentPoints *= 2;
            if (currentPoints > playerPoints)
            {
                unsuccessfulTry++;
                break;
            }
            playerPoints -= currentPoints;
            shots++;  break;
        case "Triple": currentPoints *= 3;
            if (currentPoints > playerPoints)
            {
                unsuccessfulTry++;
                break;
            }
            playerPoints -= currentPoints;
            shots++;  break;
        case "Retire": Console.WriteLine($"{nameOfPlayer} retired after {unsuccessfulTry} unsuccessful shots."); break;
    }
    if (playerPoints == 0)
    {
        Console.WriteLine($"{nameOfPlayer} won the leg with {shots} shots.");
        break;
    }
   
}