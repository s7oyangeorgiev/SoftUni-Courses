
int numQuantity = int.Parse(Console.ReadLine());

int sum = 0;

for (int i = 0; i < numQuantity; i++)
{
    int num = int.Parse(Console.ReadLine());
    sum += num;
}
Console.WriteLine(sum);