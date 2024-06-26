int num = int.Parse(Console.ReadLine());

for  (int i = 1; i <= num; i++)
{
    for (int j = 1; j <= num; j++)
    {
        for (int k = 1; k <= num; k++)
        {
            if ( i >= 10 || j >= 10 || k >= 10)
            {
                continue;
            }
            if (i * j * k == num)
            {
                Console.Write($"{i}{j}{k} ");
            }
        }
    }
}
Console.WriteLine();