int numOne = int.Parse(Console.ReadLine());
int numTwo = int.Parse(Console.ReadLine());
int numThree = int.Parse(Console.ReadLine());

if (numOne > numTwo && numOne > numThree)
{
    Console.WriteLine($"{numOne}");
}
else if (numTwo > numOne && numTwo > numThree)
{
    Console.WriteLine($"{numTwo}");
}
else if (numThree > numOne && numThree > numTwo)
{
    Console.WriteLine($"{numThree}");
}