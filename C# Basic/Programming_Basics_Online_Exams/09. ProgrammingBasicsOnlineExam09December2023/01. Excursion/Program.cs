
int peopleCount = int.Parse(Console.ReadLine());
int nightsCountForOnePerson = int.Parse(Console.ReadLine());
int transportCardsForOnePorson =  int.Parse(Console.ReadLine());
int museumTicketsForOnePerson =  int.Parse(Console.ReadLine());

double nightPrice = 20;
double transportCardPrice = 1.60;
double museumTicketPrice = 6;

double tottalNightsPrice = nightsCountForOnePerson * nightPrice;
double tottalTransportCardPrice = transportCardsForOnePorson * transportCardPrice;
double tottalMuseumTicketsPrice = museumTicketsForOnePerson * museumTicketPrice;

double tottalSumForOnePerson = tottalNightsPrice + tottalTransportCardPrice + tottalMuseumTicketsPrice;
double tottalSumForAllGroup = tottalSumForOnePerson * peopleCount;
double tottalSumNeeded = tottalSumForAllGroup * 1.25;

Console.WriteLine($"{tottalSumNeeded:f2}");


