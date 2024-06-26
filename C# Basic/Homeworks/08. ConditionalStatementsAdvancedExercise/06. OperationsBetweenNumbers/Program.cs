int numOne = int.Parse(Console.ReadLine());
int numTwo = int.Parse(Console.ReadLine());
string operation = Console.ReadLine();

double result = 0;

if (operation == "+")
{
    result = numOne + numTwo;
    if (result % 2 == 0)
    {
        Console.WriteLine($"{numOne} {operation} {numTwo} = {result} - even");
    }
    else
    {
        Console.WriteLine($"{numOne} + {numTwo} = {result} - odd");
    }
}
else if (operation == "-")
{
    result = numOne - numTwo;
    if (result % 2 == 0)
    {
        Console.WriteLine($"{numOne} - {numTwo} = {result} - even");
    }
    else
    {
        Console.WriteLine($"{numOne} - {numTwo} = {result} - odd");
    }
}
else if ( operation == "*")
{
    result = numOne * numTwo;
    if (result % 2 == 0)
    {
        Console.WriteLine($"{numOne} * {numTwo} = {result} - even");
    }
    else
    {
        Console.WriteLine($"{numOne} * {numTwo} = {result} - odd");
    }
}
else if ( operation == "/")
{
    if (numTwo == 0)
    {
        Console.WriteLine($"Cannot divide {numOne} by zero");
    }
    else
    {
        result = (double)numOne / numTwo;
        Console.WriteLine($"{numOne} / {numTwo} = {result:f2}");
    }
}
else if( operation == "%")
{
    if (numTwo == 0)
    {
        Console.WriteLine($"Cannot divide {numOne} by zero");
    }
    else
    {
        result = (double)numOne % numTwo;
        Console.WriteLine($"{numOne} % {numTwo} = {result}");
    }
}
