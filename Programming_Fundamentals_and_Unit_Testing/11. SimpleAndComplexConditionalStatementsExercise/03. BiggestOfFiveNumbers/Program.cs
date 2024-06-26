int numOne = int.Parse(Console.ReadLine());
int numTwo = int.Parse(Console.ReadLine());
int numTree =  int.Parse(Console.ReadLine());
int numFour =  int.Parse(Console.ReadLine());
int numFive =  int.Parse(Console.ReadLine());

if ( numOne > numTwo && numOne > numTree && numOne > numFour && numOne > numFive)
{
    Console.WriteLine(numOne);
}
else if ( numTwo > numOne && numTwo > numTree && numTwo > numFour && numTwo > numFive)
{
    Console.WriteLine(numTwo);
}
else if ( numTree > numOne && numTree > numTwo && numTree > numFour && numTree > numFive)
{
    Console.WriteLine(numTree);
}
else if ( numFour > numOne && numFour > numTwo && numFour > numTree && numFour > numFive)
{
    Console.WriteLine(numFour);
}
else if ( numFive > numOne && numFive > numTree && numFive > numTwo && numFive > numFour)
{
    Console.WriteLine(numFive);
}