int numberOfPages = int.Parse(Console.ReadLine());
int pagesReadForOneHour =  int.Parse(Console.ReadLine());
int daysCount =  int.Parse(Console.ReadLine());

int totalReadingTime = numberOfPages / pagesReadForOneHour;
int requiredHoursPerDay = totalReadingTime / daysCount;

Console.WriteLine(requiredHoursPerDay);