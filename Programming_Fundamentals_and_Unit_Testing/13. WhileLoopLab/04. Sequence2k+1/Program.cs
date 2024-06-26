using System.Xml;

int maxNum = int.Parse(Console.ReadLine());

for (int i = 1; i <= maxNum; i++)
{
    while (i <= maxNum)
    {
        Console.WriteLine(i);
        i = i + i + 1;
    }
}