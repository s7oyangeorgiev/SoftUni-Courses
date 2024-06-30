int number = int.Parse(Console.ReadLine());

string numString = number.ToString();

string[] digitNames = {
            "zero", "one", "two", "three", "four",
            "five", "six", "seven", "eight", "nine"
        };

for (int i = numString.Length - 1; i >= 0; i--)
{
    int digit = int.Parse(numString[i].ToString());
    Console.WriteLine(digitNames[digit]);
}