int centuries = int.Parse(Console.ReadLine());

int centuriesToYears = centuries * 100;
double yearsToDays = Math.Floor(centuriesToYears * 365.2422);
double daysToHours = yearsToDays * 24;
double hoursToMinutes = daysToHours * 60;

Console.WriteLine($"{centuries} centuries = {centuriesToYears} years = " +
    $"{yearsToDays} days = {daysToHours} hours = {hoursToMinutes} minutes");