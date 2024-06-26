

for (int i = 0;; i++)
{
    double numbers = double.Parse(Console.ReadLine());
    
    if (numbers >= 0)
    {
        
        Console.WriteLine($"Result: {numbers * 2:f2}");
    }
    else
    {
        Console.WriteLine("Negative number!");
        break;
    }
}
