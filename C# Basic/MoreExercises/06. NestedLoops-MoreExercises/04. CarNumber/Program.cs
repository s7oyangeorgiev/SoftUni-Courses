
int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());

for (int firstNum = start; firstNum <= end; firstNum++)
{
    for (int secondNum = start; secondNum <= end; secondNum++)
    {
        for (int thirdNum = start; thirdNum <= end; thirdNum++)
        {
            for (int fourNum = start; fourNum <= end; fourNum++)
            {
                if (((firstNum % 2 == 0 && fourNum % 2 == 1) || ((firstNum % 2 == 1 && fourNum % 2 == 0))) && firstNum > fourNum 
                    && (secondNum + thirdNum) % 2 == 0)
                {
                    Console.Write($"{firstNum}{secondNum}{thirdNum}{fourNum} ");
                }
            }
        }
    }
}