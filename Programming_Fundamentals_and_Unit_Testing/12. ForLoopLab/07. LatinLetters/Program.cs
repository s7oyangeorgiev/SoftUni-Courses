char firstLetter = char.Parse(Console.ReadLine());
char secondLetter = char.Parse(Console.ReadLine());

string result = "";

for (char i = firstLetter; i <= secondLetter; i++)
{
    result += i;
    result += " ";
}

Console.WriteLine(result);