
int n = int.Parse(Console.ReadLine());

//for (int i = 0; i < n; i++)
//{
    for (int firstNum = 1; firstNum <= 9; firstNum++)
    {
        for (int secondNum = 1; secondNum <= 9; secondNum++)
        {
            for (int thirdNum = 1; thirdNum <= 9; thirdNum++)
            {
                for (int fourNum = 1; fourNum <= 9; fourNum++)
                {
                    if (firstNum + secondNum == thirdNum + fourNum && n % (firstNum + secondNum) == 0)
                    {
                        Console.Write($"{firstNum}{secondNum}{thirdNum}{fourNum} ");
                    }
                }
            }
        }
    }
//}