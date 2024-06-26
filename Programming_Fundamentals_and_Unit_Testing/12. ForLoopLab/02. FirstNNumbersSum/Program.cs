int n = int.Parse(Console.ReadLine());

string result = "";
int totalResult = 0;
for  (int i = 1; i <= n; i++)
{
    result += i;
    totalResult += i;
     
    if (i < n)
    {
        result += "+";
    }
}
Console.WriteLine($"{result}={totalResult}");