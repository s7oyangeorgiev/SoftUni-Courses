int num = int.Parse(Console.ReadLine());

int currentNum = 1;

for (int rows = 1; currentNum <= num; rows++)
{
    for (int cols = 1; cols <= rows && currentNum <= num; cols++)
    {
        Console.Write($"{currentNum} ");
        currentNum++;
    }
    Console.WriteLine();
}
