
while (true)
{
    int num = int.Parse(Console.ReadLine());

    if (num % 2 == 0)
    {
        continue;
    }
    else
    {
        Console.WriteLine(num);
        break;
    }
}
