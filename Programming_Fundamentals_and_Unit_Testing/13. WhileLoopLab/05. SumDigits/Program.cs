//int num = int.Parse(Console.ReadLine());

//int sum = num.ToString().Select(digit => int.Parse(digit.ToString())).ToArray().Sum();

//Console.WriteLine(sum);

int num = int.Parse(Console.ReadLine());

int sum = 0;

while (num > 0)
{
    int lastDigit = num % 10;
    sum += lastDigit;
    num /= 10;
}

Console.WriteLine(sum);