int plasticNeeded = int.Parse(Console.ReadLine());
int paintNeeded = int.Parse(Console.ReadLine());
int thinnerNeeded = int.Parse(Console.ReadLine());
int workingHours = int.Parse(Console.ReadLine());

double plasticPrice = 1.50;
double paintPrice = 14.50;
double thinnerPrice = 5.00;
double bagPrice = 0.40;

double sumForPlastic = (plasticNeeded + 2) * plasticPrice;
double sumForPaint = (paintNeeded * 1.1) * paintPrice;
double sumForThinner = thinnerNeeded * thinnerPrice;
double tottalSumForMaterials = sumForPlastic + sumForPaint + sumForThinner + bagPrice;
double sumForWorkersPerHour = tottalSumForMaterials * 0.30;
double sumForWorkersPerDay = sumForWorkersPerHour * workingHours;

double tottalMoneyNeeded = tottalSumForMaterials + sumForWorkersPerDay;

Console.WriteLine(tottalMoneyNeeded);

