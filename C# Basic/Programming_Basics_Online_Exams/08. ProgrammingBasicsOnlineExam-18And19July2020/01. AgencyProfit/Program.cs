
string company = Console.ReadLine();
int ticketsQuantityForAdults = int.Parse(Console.ReadLine());
int ticketsQuantityForChildrens = int.Parse(Console.ReadLine());
double ticketPriceForAdultNeto =  double.Parse(Console.ReadLine());
double taxForService = double.Parse(Console.ReadLine());

double ticketPriceForChildren = (ticketPriceForAdultNeto * 0.30) + taxForService;
double ticketPriceForAdult = ticketPriceForAdultNeto + taxForService;

double tottalPriceFOrAdults = ticketPriceForAdult * ticketsQuantityForAdults;
double tottalPriceFOrChildren = ticketPriceForChildren * ticketsQuantityForChildrens;

double moneyForCompany = (tottalPriceFOrAdults + tottalPriceFOrChildren) * 0.20;

Console.WriteLine($"The profit of your agency from {company} tickets is {moneyForCompany:f2} lv.");
