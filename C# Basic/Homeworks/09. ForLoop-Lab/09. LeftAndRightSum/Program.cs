int number = int.Parse(Console.ReadLine());

int sumUp = 0;
int sumDown = 0;

for (int i = 0; i < number; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());
    sumUp += currentNumber;
}

for (int i = 0; i < number; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());
    sumDown += currentNumber;
}

if (sumUp == sumDown)
{
    Console.WriteLine($"Yes, sum = {sumDown}");
}
else
{
    Console.WriteLine($"No, diff = {Math.Abs(sumUp - sumDown)}");
}



