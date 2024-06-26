
int groupCaount = int.Parse(Console.ReadLine());

int groupMus = 0;
int groupMon = 0;
int groupKili = 0;
int groupK2 = 0;
int groupEve = 0;
double sum = 0;

for (int i = 0; i < groupCaount; i++)
{
    int peopleInTheGroup = int.Parse(Console.ReadLine());

    switch (peopleInTheGroup)
    {
        case <= 5: groupMus += peopleInTheGroup; break;
        case <= 12: groupMon += peopleInTheGroup; break;
        case <= 25: groupKili += peopleInTheGroup; break;
        case <= 40: groupK2 += peopleInTheGroup; break;
        case >= 41: groupEve += peopleInTheGroup; break;
    }
    sum = groupMus + groupMon + groupKili + groupK2 + groupEve;
}
Console.WriteLine($"{groupMus / sum * 100:f2}%");
Console.WriteLine($"{groupMon / sum * 100:f2}%");
Console.WriteLine($"{groupKili / sum * 100:f2}%");
Console.WriteLine($"{groupK2 / sum * 100:f2}%");
Console.WriteLine($"{groupEve / sum * 100:f2}%");

