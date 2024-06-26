int num = int.Parse(Console.ReadLine());
PrintingTriangle(num);

static void PrintingTriangle(int num)
{
    for (int row = 1; row <= num; row++)
    {
        for (int col = 1; col <= row; col++)
        {
            Console.Write(col + " ");
        }
        Console.WriteLine();
    }

    for (int row = num - 1;row >= 1; row--)
    {
        for (int col = 1; col <= row; col++)
        {
            Console.Write(col + " ");
        }
        Console.WriteLine();
    }
}