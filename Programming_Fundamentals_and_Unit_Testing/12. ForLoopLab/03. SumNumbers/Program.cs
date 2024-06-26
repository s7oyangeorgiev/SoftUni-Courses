using System.Runtime.CompilerServices;

int countOfNumbers = int.Parse(Console.ReadLine());

double result = 0;

for (int i = 0; i < countOfNumbers; i++)
{
    double num = double.Parse(Console.ReadLine());
    result += num;
}

Console.WriteLine(result);