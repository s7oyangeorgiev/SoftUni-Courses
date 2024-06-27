
int rentForHall = int.Parse(Console.ReadLine());

double statuettes = rentForHall * 0.70;
double cattering = statuettes * 0.85;
double sound = cattering * 0.5;

double tottalPrice = rentForHall + statuettes + cattering + sound;

Console.WriteLine($"{tottalPrice:f2}");