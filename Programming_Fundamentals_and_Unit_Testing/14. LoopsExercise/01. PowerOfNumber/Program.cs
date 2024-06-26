int numN = int.Parse(Console.ReadLine());
int powerNum = int.Parse(Console.ReadLine());

int sum = numN;

for (int i = 2; i <= powerNum; i++)
{
    sum = sum * numN;
}

Console.WriteLine(sum);
