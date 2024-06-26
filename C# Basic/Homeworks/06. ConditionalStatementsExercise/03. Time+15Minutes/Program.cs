int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

int tottalMinutes = hours * 60 + minutes + 15;
int newHours = (tottalMinutes / 60) % 24;
int newMinutes = tottalMinutes % 60;

if (newMinutes < 10)
{
    Console.WriteLine($"{newHours}:0{newMinutes}");
}
else
{
    Console.WriteLine($"{newHours}:{newMinutes}");
}

