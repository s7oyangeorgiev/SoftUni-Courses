int num = int.Parse(Console.ReadLine());

for  (int d1 = 1; d1 <= num; d1++)
{
    for (int d2 = 0; d2 <= num; d2++)
    {
        for (int d3 = 0; d3 <= num; d3++)
        {
            for ( int  d4 = 0; d4 <= num; d4++)
            {
                if (d1 + d2 == num && d3 + d4 == num && d1 + d2 == d3 + d4)
                {
                    Console.Write($"{d1}{d2}{d3}{d4} ");
                }
            }
        }
    }
}
Console.WriteLine();