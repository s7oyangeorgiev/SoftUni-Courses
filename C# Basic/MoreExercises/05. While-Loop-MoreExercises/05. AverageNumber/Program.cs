﻿
int num = int.Parse(Console.ReadLine());

int sum = 0;

for (int i = 0; i < num; i++)
{
    int currentNum = int.Parse(Console.ReadLine());
    sum += currentNum;
}
double avarageNum = (double)sum / num;

Console.WriteLine($"{avarageNum:f2}");