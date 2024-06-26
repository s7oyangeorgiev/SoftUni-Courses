double numOne = double.Parse(Console.ReadLine());
double numTwo = double.Parse(Console.ReadLine());
string operation =  Console.ReadLine();

double result = 0;
switch (operation)
{
    case "+": result += numOne + numTwo; break;
    case "-": result += numOne - numTwo; break;
    case "*": result += numOne * numTwo; break;
    case "/": result += numOne / numTwo; break;
}

Console.WriteLine($"{numOne} {operation} {numTwo} = {result:f2}");