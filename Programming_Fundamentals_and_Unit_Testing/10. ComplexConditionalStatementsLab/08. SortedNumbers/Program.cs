int numOne = int.Parse(Console.ReadLine());
int numTwo = int.Parse(Console.ReadLine());
int numTree = int.Parse(Console.ReadLine());

if (numOne < numTwo && numTwo < numTree)
{
    Console.WriteLine("Ascending");
}
else if ( numOne > numTwo && numTwo > numTree)
{
    Console.WriteLine("Descending");
}
else
{
    Console.WriteLine("Not sorted");
}