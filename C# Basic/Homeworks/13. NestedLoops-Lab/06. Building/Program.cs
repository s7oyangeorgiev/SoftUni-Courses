
int countOfFloors = int.Parse(Console.ReadLine());
int countOfRooms = int.Parse(Console.ReadLine());

for (int floors = countOfFloors; floors >= 1; floors--)
{
    for (int room = 0; room < countOfRooms; room++)
    {
        if (floors == countOfFloors)
        {
            Console.Write($"L{floors}{room} ");
        }
        else if (floors % 2 == 0) 
        {
            Console.Write($"O{floors}{room} ");
        }
        else if (floors % 2 == 1)
        {
            Console.Write($"A{floors}{room} ");
        }
    }

    Console.WriteLine();

}