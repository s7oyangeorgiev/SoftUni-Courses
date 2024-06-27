
string symbol = Console.ReadLine();

int secretCharCounterC = 0;
int secretCharCounterO = 0;
int secretCharCounterN = 0;
string word = "";
string allOutput = "";


while (symbol != "End")
{
    char currentSymbol = char.Parse(symbol);
    

    if ((currentSymbol >= 'a' && currentSymbol <= 'z') || (currentSymbol >= 'A' && currentSymbol <= 'Z'))
    {
        if (currentSymbol == 'c')
        {
            secretCharCounterC++;

            if (secretCharCounterC > 1)
            {
                secretCharCounterC -= 1;
                word += currentSymbol;
            }
        }
        else if (currentSymbol == 'o')
        {
            secretCharCounterO++;

            if (secretCharCounterO > 1)
            {
                secretCharCounterO -= 1;
                word += currentSymbol;
            }
        }
        else if (currentSymbol == 'n')
        {
            secretCharCounterN++;

            if (secretCharCounterN > 1)
            {
                secretCharCounterN -= 1;
                word += currentSymbol;
            }
        }
        else
        {
            word += currentSymbol;
        }

        if ((secretCharCounterC + secretCharCounterO + secretCharCounterN) == 3)
        {
            secretCharCounterC = 0;
            secretCharCounterO = 0;
            secretCharCounterN = 0;
            word += " ";
            allOutput = word;
        }
    }

    symbol = Console.ReadLine();
}
Console.WriteLine(allOutput);
