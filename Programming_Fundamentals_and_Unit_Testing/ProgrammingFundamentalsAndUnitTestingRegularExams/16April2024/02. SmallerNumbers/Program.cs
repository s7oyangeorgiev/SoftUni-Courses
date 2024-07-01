int[] numArray = Console.ReadLine()
    .Split(' ')
    .Select(int.Parse)
    .ToArray();

int currentNum = int.Parse(Console.ReadLine());

int[] smallerNumbers = numArray.Where(num => num < currentNum).ToArray();

Console.WriteLine(string.Join(" ", smallerNumbers));