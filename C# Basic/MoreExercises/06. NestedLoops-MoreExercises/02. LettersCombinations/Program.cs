
var lowerCaseForStart = Console.ReadLine();
var lowerCaseForEns = Console.ReadLine();
var skipLowerCase = Console.ReadLine();

int start = lowerCaseForStart[0];
int end = lowerCaseForEns[0];
int skip = skipLowerCase[0];

string combination = "";
int combinationCount = 0;

for (var firstLetter = start; firstLetter <= end; firstLetter++)
{
    for (var secondLetter = start; secondLetter <= end; secondLetter++)
    {
        for (var thirdLetter = start; thirdLetter <= end; thirdLetter++)
        {
            if (firstLetter == skip || secondLetter == skip || thirdLetter == skip)
            {
                continue;
            }
            else
            {
                combination += $"{(char)firstLetter}{(char)secondLetter}{(char)thirdLetter} ";
                combinationCount++;
            }
        }
    }
}
Console.Write($"{combination}{combinationCount}");
