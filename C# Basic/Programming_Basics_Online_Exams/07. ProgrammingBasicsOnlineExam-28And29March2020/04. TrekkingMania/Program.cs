
using System.Transactions;

int groupsCount = int.Parse(Console.ReadLine());

double tottalPeople = 0;
double musala = 0;
double monblan = 0;
double kili = 0;
double k2 = 0;
double everest = 0;

for (int i = 0; i < groupsCount; i++)
{
    int peopleCountInTheGroup = int.Parse(Console.ReadLine());

    if (peopleCountInTheGroup <= 5)
    {
        musala += peopleCountInTheGroup;
        tottalPeople += peopleCountInTheGroup;
    }
    else if (peopleCountInTheGroup >= 6 && peopleCountInTheGroup <= 12)
    {
        monblan += peopleCountInTheGroup;
        tottalPeople += peopleCountInTheGroup;
    }
    else if (peopleCountInTheGroup >= 13 && peopleCountInTheGroup <= 25)
    {
        kili += peopleCountInTheGroup;
        tottalPeople += peopleCountInTheGroup;
    }
    else if (peopleCountInTheGroup >= 26 && peopleCountInTheGroup <= 40)
    {
        k2 += peopleCountInTheGroup;
        tottalPeople += peopleCountInTheGroup;
    }
    else
    {
        everest += peopleCountInTheGroup;
        tottalPeople += peopleCountInTheGroup;
    }

}
double percentMusala = (musala / tottalPeople) * 100;
double percentMonblan = (monblan / tottalPeople) * 100;
double percentKili = (kili / tottalPeople) * 100;
double percentK2 = (k2 / tottalPeople) * 100;
double percentEverest = (everest / tottalPeople) * 100;

Console.WriteLine($"{percentMusala:f2}%");
Console.WriteLine($"{percentMonblan:f2}%");
Console.WriteLine($"{percentKili:f2}%");
Console.WriteLine($"{percentK2:f2}%");
Console.WriteLine($"{percentEverest:f2}%");