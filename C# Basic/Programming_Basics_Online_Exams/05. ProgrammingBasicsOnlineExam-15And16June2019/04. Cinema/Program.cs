
int seats = int.Parse(Console.ReadLine());
string command = Console.ReadLine();

double tottalPriceForAllPeople = 0;
int tottalPeopleComeIn = 0;

while (command != "Movie time!")
{
    int peopleComeIn = int.Parse(command);
    tottalPeopleComeIn += peopleComeIn;

    if (tottalPeopleComeIn > seats)
    {
        break;
    }

    if (peopleComeIn % 3 == 0)
    {
        tottalPriceForAllPeople += (peopleComeIn * 5) - 5;
    }
    else
    {
        tottalPriceForAllPeople += peopleComeIn * 5;
    }

    command = Console.ReadLine();

}
if (tottalPeopleComeIn > seats)
{
    Console.WriteLine("The cinema is full.");
    Console.WriteLine($"Cinema income - {tottalPriceForAllPeople} lv.");

}
else
{
    Console.WriteLine($"There are {seats - tottalPeopleComeIn} seats left in the cinema.");
    Console.WriteLine($"Cinema income - {tottalPriceForAllPeople} lv.");
}




