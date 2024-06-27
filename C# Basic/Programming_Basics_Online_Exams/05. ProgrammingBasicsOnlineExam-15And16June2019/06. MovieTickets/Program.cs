
int a1 = int.Parse(Console.ReadLine());
int a2 = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

string symbol1 = "";
int symbol2 = 0;
int symbol3 = 0;
int symbol4 = 0;


for (int i = a1; i < a2; i++)
{
    int code = i;
    char character = (char)code;

    if (character >= 'A' && character <= 'Z')
    {
        symbol1 = character.ToString();
    }
    else
    {
        continue;
    }
 
    int symbil1Value = (int)Convert.ToChar(symbol1);

    for (int j = 1; j < n; j++)
    {
        symbol2 = j;

        for (int k = 1; k <= (n / 2 - 1); k++)
        {
            symbol3 = k;

            symbol4 = (int)Convert.ToChar(symbol1);

            if (symbil1Value % 2 == 1 && (symbol2 + symbol3 + symbol4) % 2 == 1)
            {
                Console.WriteLine($"{symbol1}-{symbol2}{symbol3}{symbol4}");
            }
        }
    }
}
