
using System.Transactions;

int firstNumHight = int.Parse(Console.ReadLine());
int secondNumHight = int.Parse(Console.ReadLine());
int thirdNumHight = int.Parse(Console.ReadLine());



for (int firstNum = 1; firstNum <= firstNumHight; firstNum++)
{
    for (int secondNum = 1; secondNum <= secondNumHight; secondNum++)
    {
        bool isValid = false; 
        if (secondNum == 2 || secondNum == 3 || secondNum == 5 || secondNum == 7)
        {
            isValid = true;
        }
        for (int thirdNum = 1; thirdNum <= thirdNumHight; thirdNum++)
        {
            if (firstNum % 2 == 0 && thirdNum % 2 == 0 && isValid)
            {
                Console.WriteLine($"{firstNum} {secondNum} {thirdNum}");
            }
        }

    }
}

