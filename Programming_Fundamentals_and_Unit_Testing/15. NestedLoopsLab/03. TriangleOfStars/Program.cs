int size = int.Parse(Console.ReadLine());

for (int rows = 1; rows <= size; rows++)
{
    for (int stars = 1; stars <= rows; stars++)
    {
        string star = "*";
        Console.Write(star);
    }
    Console.WriteLine();
}