int numCount = int.Parse(Console.ReadLine());

int sum = 0;

for (int i = 1; i <= numCount; i++)
{
    char n = char.Parse(Console.ReadLine());

    switch (n)
    {
        case 'a': sum += 1; break;
        case 'e': sum += 2; break;
        case 'i': sum += 3; break;
        case 'o': sum += 4; break;
        case 'u': sum += 5; break;
        default: sum += 0; break;
    }
}

Console.WriteLine(sum);