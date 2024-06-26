double stopNum = int.Parse(Console.ReadLine());

double priviousNum = 0;

while (true)
{
    int num = int.Parse(Console.ReadLine());

    if (num == stopNum)
    {
        break;
    }

    priviousNum = num * 1.20;
}

Console.WriteLine(priviousNum);