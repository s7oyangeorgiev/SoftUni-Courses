while (true)
{
    string stringSeries = Console.ReadLine();

    if (stringSeries == "end")
    {
        break;
    }

    string reversedText = ReverseString(stringSeries);

    Console.WriteLine($"{stringSeries} = {reversedText}");
}

static string ReverseString(string str)
{
    char[] charArray = str.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}