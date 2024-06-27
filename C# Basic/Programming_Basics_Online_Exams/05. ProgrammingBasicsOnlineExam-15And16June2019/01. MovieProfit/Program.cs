
string nameOfTheMovie = Console.ReadLine();
int daysQuantity = int.Parse(Console.ReadLine());
int ticketsQuantity = int.Parse(Console.ReadLine());
double ticketPrice =  double.Parse(Console.ReadLine());
int cinemaPercent =  int.Parse(Console.ReadLine());

double priceForTicketsForOneDay = ticketsQuantity * ticketPrice;
double moneyFromAllPeriod = priceForTicketsForOneDay * daysQuantity;
double percentForCinema = moneyFromAllPeriod * (cinemaPercent / 100.00);

double moneyFormMovie = moneyFromAllPeriod - percentForCinema;

Console.WriteLine($"The profit from the movie {nameOfTheMovie} is {moneyFormMovie:f2} lv.");

