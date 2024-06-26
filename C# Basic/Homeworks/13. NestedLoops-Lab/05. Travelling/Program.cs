
string destination = Console.ReadLine();

while (destination != "End")
{
    double budget = double.Parse(Console.ReadLine());
    double savingMoney = 0;
    
    while (savingMoney < budget)
    {
        double currentMoney = double.Parse(Console.ReadLine());
        savingMoney += currentMoney;
    }

    Console.WriteLine($"Going to {destination}!");


    destination = Console.ReadLine();
}
    

