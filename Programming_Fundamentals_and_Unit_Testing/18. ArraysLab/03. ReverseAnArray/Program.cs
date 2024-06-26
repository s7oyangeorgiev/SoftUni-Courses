int numQuantity = int.Parse(Console.ReadLine());
int[] numbers = new int[numQuantity];

for (int i = numbers.Length - 1; i >= 0; i--)
{
    numbers[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine(string.Join(" ", numbers));