
double hightOfTheWall = double.Parse(Console.ReadLine());
double widthOfTheWall = double.Parse(Console.ReadLine());
double percentOfTottalAreaNoPaiting = double.Parse(Console.ReadLine()) / 100;
string littersOfPaint = Console.ReadLine();

double oneLittreIsPainting = 1;
double area = hightOfTheWall * widthOfTheWall;
double livingRoom = (4 * area) - ((4 * area) * percentOfTottalAreaNoPaiting);
int currentLittersOfPaint = 0;

while (littersOfPaint != "Tired!")
{
    currentLittersOfPaint = int.Parse(littersOfPaint);

    livingRoom -= currentLittersOfPaint;

    if (livingRoom <= 0)
    {
        break;
    }

    littersOfPaint = Console.ReadLine();
}
if (littersOfPaint == "Tired!")
{
    Console.WriteLine($"{livingRoom} quadratic m left.");
}
else if (livingRoom < 0)
{
    Console.WriteLine($"All walls are painted and you have {Math.Abs(livingRoom)} l paint left!"
);
}
else
{
    Console.WriteLine($"All walls are painted! Great job, Pesho!");
}
