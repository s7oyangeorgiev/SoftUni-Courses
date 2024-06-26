int numCount = int.Parse(Console.ReadLine());

int biggestNum = int.MinValue;

for (int i = 1; i <= numCount; i++)
{
    int num = int.Parse(Console.ReadLine());

    if (num > biggestNum)
    {
        biggestNum = num;
    }

}

Console.WriteLine(biggestNum);