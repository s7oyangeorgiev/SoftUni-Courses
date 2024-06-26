string type = Console.ReadLine();

if (type == "int")
{
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine(GetIntMax(a, b));

}
else if (type == "char")
{
    char a = char.Parse(Console.ReadLine());
    char b = char.Parse(Console.ReadLine());
    Console.WriteLine(GetCharMax(a, b));
}
else
{
    string a = Console.ReadLine();
    string b = Console.ReadLine();
    Console.WriteLine(GetStringMax(a, b));


}
static int GetIntMax(int a, int b)
{
    int result = 0;
    if (a > b)
    {
        result = a;
    }
    else
    {
        result = b;
    }

    return result;
}

static char GetCharMax(char a, char b)
{
    char result = ' ';
    if (a > b)
    {
        result = a;
    }
    else
    {
        result = b;
    }

    return result;
}

static string GetStringMax(string a, string b)
{
    int result = a.CompareTo(b);

    if (result > 0)
    {
        return a;
    }
    else
    {
        return b;
    }
   
}