char startLetterS = char.Parse(Console.ReadLine());
char endLetterE = char.Parse(Console.ReadLine());
char excludedLetterX =  char.Parse(Console.ReadLine());

int combinationCount = 0;

for (char i = startLetterS; i <= endLetterE; i++)
{
	for (char j = startLetterS; j <= endLetterE; j++)
	{
		for (char k = startLetterS; k <= endLetterE; k++)
		{
			if ( i == excludedLetterX || j == excludedLetterX || k == excludedLetterX )
			{
				continue;
			}
			else
			{
                Console.Write($"{i}{j}{k} ");
				combinationCount++;
            }
		}
	}
}
Console.WriteLine();
Console.WriteLine(combinationCount);