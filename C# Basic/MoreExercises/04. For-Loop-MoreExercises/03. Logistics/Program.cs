
int cargoQuantity = int.Parse(Console.ReadLine());



double cargoPrice = 0;
double totalCargo = 0;
double totalMicrobusCargo = 0;
double totalTruckCargo = 0;
double totalTrainCargo = 0;

for (int i = 0; i < cargoQuantity; i++)
{
    int cargoWeight = int.Parse(Console.ReadLine());
    totalCargo += cargoWeight;

    if (cargoWeight <= 3)
    {
        totalMicrobusCargo += cargoWeight;
        cargoPrice = cargoWeight * 200;
    }
    else if (cargoWeight <= 11) 
    {
        totalTruckCargo += cargoWeight;
        cargoPrice += cargoWeight * 175;
    }
    else if (cargoWeight > 11)
    {
        totalTrainCargo += cargoWeight;
        cargoPrice += cargoWeight * 120;
    }
}
double totalCargoPrice = (totalMicrobusCargo * 200) + (totalTruckCargo * 175) + (totalTrainCargo * 120);
double microbusCargoPercent = totalMicrobusCargo / totalCargo * 100;
double truckCargoPercent = totalTruckCargo / totalCargo * 100;
double trainCargoPercent = totalTrainCargo / totalCargo * 100;
double middlePricePerTon = totalCargoPrice / totalCargo;

Console.WriteLine($"{middlePricePerTon:f2}");
Console.WriteLine($"{microbusCargoPercent:f2}%");
Console.WriteLine($"{truckCargoPercent:f2}%");
Console.WriteLine($"{trainCargoPercent:f2}%");