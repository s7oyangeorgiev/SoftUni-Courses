int racerOne = int.Parse(Console.ReadLine()); 
int racerTwo = int.Parse(Console.ReadLine());
int racerTree = int.Parse(Console.ReadLine());

int allTimeSum = racerOne + racerTwo + racerTree;
int minutes = allTimeSum / 60;
int seconds = allTimeSum % 60;

if (seconds < 10)
{
    Console.WriteLine($"{minutes}:0{seconds}");
}
else
{
    Console.WriteLine($"{minutes}:{seconds}");
}


