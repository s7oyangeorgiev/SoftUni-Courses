int numN = int.Parse(Console.ReadLine());

int multiplication = 1;
int result = numN * multiplication;

while (multiplication <= 10)
{
    Console.WriteLine($"{numN} x {multiplication} = {result}");
    multiplication++;
    result = numN * multiplication;
}