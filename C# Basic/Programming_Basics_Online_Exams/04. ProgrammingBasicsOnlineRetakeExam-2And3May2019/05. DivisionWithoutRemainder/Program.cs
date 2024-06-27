
int num = int.Parse(Console.ReadLine());

int p1 = 0, p2 = 0, p3 = 0;

//double p1Percent = ((double)p1 / num) * 100;
//double p2Percent = ((double)p2 / num) * 100;
//double p3Percent = ((double)p3 / num) * 100;

for (int i = 0; i < num; i++)
{
    int currentNum = int.Parse(Console.ReadLine());

    if (currentNum % 2 == 0)
    {
        p1 += 1;
    }
    if (currentNum % 3 == 0) 
    { 
        p2 += 1;
    }
    if (currentNum % 4 == 0)
    {
        p3 += 1;
    }

}
Console.WriteLine($"{((double)p1 / num) * 100:f2}%");
Console.WriteLine($"{((double)p2 / num) * 100:f2}%");
Console.WriteLine($"{((double)p3 / num) * 100:f2}%");
