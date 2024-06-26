
int num = int.Parse(Console.ReadLine());
int startingFrom = 1;
bool isBigger = false;

for (int rows = 1; rows <= num; rows++)
{
    for (int cols = 1; cols <= rows; cols++)
    {
        if (startingFrom > num)
        {
            isBigger = true;
            break;
        }
        Console.Write(startingFrom + " ");
        startingFrom++;
    }
    if (isBigger)
    {
        break;
    }
    Console.WriteLine();
}