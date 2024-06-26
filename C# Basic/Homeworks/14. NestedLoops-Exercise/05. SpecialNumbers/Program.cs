
int num = int.Parse(Console.ReadLine());



for (int i = 1111; i <= 9999; i++)
{
    string divisor = i.ToString();

    bool isSpecial = true;

    for (int j = 0; j < divisor.Length; j++)
    {
        int currentDivisor = int.Parse(divisor[j].ToString());

        if (currentDivisor == 0)
        {
            isSpecial = false;
            break;
        }

        if (num % currentDivisor == 0)
        {
            continue;
        }
        else
        {
            isSpecial = false;
            break;
        }


    }
    if (isSpecial)
    {
        Console.Write(i + " ");
    }
}
