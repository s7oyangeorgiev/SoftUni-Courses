int N = int.Parse(Console.ReadLine());

int[] array1 = new int[N];
int[] array2 = new int[N];

for (int i = 0; i < N; i++)
{
    string[] input = Console.ReadLine().Split(" ");
    int num1 = int.Parse(input[0]);
    int num2 = int.Parse(input[1]);

    if (i % 2 == 0)
    {
        array1[i] = num1;
        array2[i] = num2;
    }
    else
    {
        array1[i] = num2;
        array2[i] = num1;
    }
}
Console.WriteLine(string.Join(" ", array1));
Console.WriteLine(string.Join(" ", array2));