
int mounth = int.Parse(Console.ReadLine());

double totalSumFOrElectricity = 0;
double sumForWater = 0;
double sumForInternet = 0;
double sumForOthers = 0;
for (int i = 0; i < mounth; i++)
{
    double recieveForElectricity = double.Parse(Console.ReadLine());
    totalSumFOrElectricity += recieveForElectricity;
    sumForWater += 20;
    sumForInternet += 15;
    sumForOthers = (totalSumFOrElectricity + sumForWater + sumForInternet) * 120 / 100;
}
double middleForMounth = (totalSumFOrElectricity + sumForWater + sumForInternet + sumForOthers) / mounth;

Console.WriteLine($"Electricity: {totalSumFOrElectricity:f2} lv");
Console.WriteLine($"Water: {sumForWater:f2} lv");
Console.WriteLine($"Internet: {sumForInternet:f2} lv");
Console.WriteLine($"Other: {sumForOthers:f2} lv");
Console.WriteLine($"Average: {middleForMounth:f2} lv");