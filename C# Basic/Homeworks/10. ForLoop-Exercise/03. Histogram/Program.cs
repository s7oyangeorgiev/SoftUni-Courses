
int num = int.Parse(Console.ReadLine());

double p1 = 0; double p2 = 0; double p3 = 0; double p4 = 0; double p5 = 0;

for (int i = 1; i <= num; i++)
{
    int numbers = int.Parse(Console.ReadLine());

    if (numbers < 200)
    {
        p1++;
    }
    else if (numbers < 400)
    {
        p2++;
    }
    else if (numbers < 600)
    {
        p3++;
    }
    else if (numbers < 800)
    {
        p4++;
    }
    else if (numbers >= 800)
    {
        p5++;
    }
    
}
Console.WriteLine($"{(p1 / num) * 100.0:f2}%");
Console.WriteLine($"{(p2 / num) * 100.0:f2}%"); 
Console.WriteLine($"{(p3 / num) * 100.0:f2}%");
Console.WriteLine($"{(p4 / num) * 100.0:f2}%");
Console.WriteLine($"{(p5 / num) * 100.0:f2}%");