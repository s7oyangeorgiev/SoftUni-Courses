int num = int.Parse(Console.ReadLine());

int numCheck = num;
bool isSpecial = false;

while (numCheck > 0)
{
    int lastDigit = numCheck % 10;

    if (num % lastDigit == 0)
    {
        isSpecial = true;
    }
    else
    {
        isSpecial = false;
        break;
    }

    numCheck /= 10;
}

if (isSpecial)
{
    Console.WriteLine($"{num} is special");
}
else
{
    Console.WriteLine($"{num} is not special");
}