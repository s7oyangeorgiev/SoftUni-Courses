﻿
int startNumber = int.Parse(Console.ReadLine());
int endNumber = int.Parse(Console.ReadLine());

for (int i = startNumber; i <= endNumber; i++)
{
    string currentNum = i.ToString();

    int oddSum = 0;
    int evenSum = 0;

    for (int j = 0; j < currentNum.Length; j++)
    {
        int currentDigit = int.Parse(currentNum[j].ToString());

        if (j % 2 == 0)
        {
            evenSum += currentDigit;
        }
        else
        {
            oddSum += currentDigit;
        }
    }

    if (oddSum == evenSum)
    {
        Console.Write(i + " ");
    }
}