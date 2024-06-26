int points = int.Parse(Console.ReadLine());

int totalPoints = points;

if ( points >= 0 && points <= 3)
{
    totalPoints += 5;
}
else if ( points >= 4 && points <= 6)
{
    totalPoints += 15;
}
else if (points >= 7 && points <= 9)
{
    totalPoints += 20;
}

Console.WriteLine($"{totalPoints}");