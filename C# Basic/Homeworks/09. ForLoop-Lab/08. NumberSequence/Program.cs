﻿
int numQuantity = int.Parse(Console.ReadLine());

int max = int.MinValue;
int min = int.MaxValue;

for (int i = 0; i < numQuantity; i++)
{
    int num = int.Parse(Console.ReadLine());

    if (num < min)
    {
        min = num;
    }
    if (num > max)
    {
        max = num;
    }
}

Console.WriteLine($"Max number: {max}");
Console.WriteLine($"Min number: {min}");