
double num = double.Parse(Console.ReadLine());

double minEven = double.MaxValue;
double maxEven = double.MinValue;
double minOdd = double.MaxValue;
double maxOdd = double.MinValue;

double sumEven = 0;
double sumOdd = 0;

for (int i = 1; i <= num; i++)
{
    double currNum = double.Parse(Console.ReadLine());
    
    if (i % 2 == 0)
    {
        sumEven += currNum;

        if (minEven > currNum)
        {
            minEven = currNum;
        }
        if (maxEven < currNum) 
        {
            maxEven = currNum; 
        }
    }
    else
    {
        sumOdd += currNum;
        if (minOdd > currNum)
        {
            minOdd = currNum;
        }
        if (maxOdd < currNum)
        {
            maxOdd = currNum;
        }
    }
}
Console.WriteLine($"OddSum={sumOdd:f2},");
if (minOdd == double.MaxValue)
{
    Console.WriteLine($"OddMin=No,");
}
else
{
    Console.WriteLine($"OddMin={minOdd:f2},");
}
if (maxOdd == double.MinValue)
{
    Console.WriteLine($"OddMax=No,");
}
else
{
    Console.WriteLine($"OddMax={maxOdd:f2},");
}
Console.WriteLine($"EvenSum={sumEven:f2},");
if (minEven == double.MaxValue)
{
    Console.WriteLine($"EvenMin=No,");
}
else
{
    Console.WriteLine($"EvenMin={minEven:f2},");
}
if (maxEven == double.MinValue)
{
    Console.WriteLine($"EvenMax=No");
}
else
{
    Console.WriteLine($"EvenMax={maxEven:f2}");
}

