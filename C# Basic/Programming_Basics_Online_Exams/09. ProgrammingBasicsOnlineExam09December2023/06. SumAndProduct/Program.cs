
double n = int.Parse(Console.ReadLine());

bool isFound = false;
string num = "";

for (int a = 1; a <= 9; a++)
{
    for (int b = 9; b >= a; b--)
    {
        for (int c = 0; c <= 9; c++)
        {
            for (int d = 9; d >= c; d--)
            {
                if ((a + b + c + d == a * b * c * d) && n % 10 == 5)
                {
                    num = $"{a}{b}{c}{d}";
                    isFound = true;
                    break;
                }
                else if (((a * b * c * d) / (a + b + c + d) == 3) && n % 3 == 0)
                {
                    num = $"{d}{c}{b}{a}";
                    isFound= true;
                    break;
                }
            }
            if (isFound)
            {
                break;
            }
        }
        if (isFound)
        {
            break;
        }
    }
    if (isFound)
    {
        break;
    }
}
if (isFound)
{
    Console.WriteLine(num);
}
else
{
    Console.WriteLine("Nothing found");
}