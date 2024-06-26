string text = Console.ReadLine();
int repeatCount = int.Parse(Console.ReadLine());
string result = RepeatText(text, repeatCount);
Console.WriteLine(result);

static string RepeatText(string text, int count)
{
    string result = "";
    for (int i = 1; i <= count; i++)
    {
        result += text;
    }
    return result;
}