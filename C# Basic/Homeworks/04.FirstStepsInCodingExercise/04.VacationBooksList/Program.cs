int pages = int.Parse(Console.ReadLine());
int pagesPerHour = int.Parse(Console.ReadLine());
int days = int.Parse(Console.ReadLine());

int tottalTimePerBook = pages / pagesPerHour;
int neededHoursPerDay = tottalTimePerBook / days;

Console.WriteLine(neededHoursPerDay);
