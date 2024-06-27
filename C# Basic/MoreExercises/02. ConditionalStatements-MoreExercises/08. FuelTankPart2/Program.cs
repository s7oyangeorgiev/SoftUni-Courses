//input
string tipeOfFuel = Console.ReadLine();
double amauntOfFuel = double.Parse(Console.ReadLine());
string holdingCard = Console.ReadLine();

double priceOfPetrol = 2.22;
double priceOfDiesel = 2.33;
double priceOfGas = 0.93;

double priceOfPetrolWithCard = 2.22 - 0.18;
double priceOfDieselWithCard = 2.33 - 0.12;
double priceOfGasWithCard = 0.93 - 0.08;

if (amauntOfFuel > 25 && tipeOfFuel == "Gas" && holdingCard == "Yes")
{
    double priceOfFuel = (amauntOfFuel * priceOfGasWithCard) * 0.9;
    Console.WriteLine($"{priceOfFuel:f2} lv.");
}
else if (amauntOfFuel > 25 && tipeOfFuel == "Diesel" && holdingCard == "Yes")
{
    double priceOfFuel = (amauntOfFuel * priceOfDieselWithCard) * 0.9;
    Console.WriteLine($"{priceOfFuel:f2} lv.");
}
else if (amauntOfFuel > 25 && tipeOfFuel == "Gasoline" && holdingCard == "Yes")
{
    double priceOfFuel = (amauntOfFuel * priceOfPetrolWithCard) * 0.9;
    Console.WriteLine($"{priceOfFuel:f2} lv.");
}


else if (amauntOfFuel >= 20 && tipeOfFuel == "Gas" && holdingCard == "Yes")
{
    double priceOfFuel = (amauntOfFuel * priceOfGasWithCard) * 0.92;
    Console.WriteLine($"{priceOfFuel:f2} lv.");
}
else if (amauntOfFuel >= 20 && tipeOfFuel == "Diesel" && holdingCard == "Yes")
{
    double priceOfFuel = (amauntOfFuel * priceOfDieselWithCard) * 0.92;
    Console.WriteLine($"{priceOfFuel:f2} lv.");
}
else if (amauntOfFuel >= 20 && tipeOfFuel == "Gasoline" && holdingCard == "Yes")
{
    double priceOfFuel = (amauntOfFuel * priceOfPetrolWithCard) * 0.92;
    Console.WriteLine($"{priceOfFuel:f2} lv.");
}


else if (amauntOfFuel > 25 && tipeOfFuel == "Gas" && holdingCard == "No")
{
    double priceOfFuel = (amauntOfFuel * priceOfGas) * 0.9;
    Console.WriteLine($"{priceOfFuel:f2} lv.");
}
else if (amauntOfFuel > 25 && tipeOfFuel == "Diesel" && holdingCard == "No")
{
    double priceOfFuel = (amauntOfFuel * priceOfDiesel) * 0.9;
    Console.WriteLine($"{priceOfFuel:f2} lv.");
}
else if (amauntOfFuel > 25 && tipeOfFuel == "Gasoline" && holdingCard == "No")
{
    double priceOfFuel = (amauntOfFuel * priceOfPetrol) * 0.9;
    Console.WriteLine($"{priceOfFuel:f2} lv.");
}


else if (amauntOfFuel >= 20 && tipeOfFuel == "Gas" && holdingCard == "No")
{
    double priceOfFuel = (amauntOfFuel * priceOfGas) * 0.92;
    Console.WriteLine($"{priceOfFuel:f2} lv.");
}
else if (amauntOfFuel >= 20 && tipeOfFuel == "Diesel" && holdingCard == "No")
{
    double priceOfFuel = (amauntOfFuel * priceOfDiesel) * 0.92;
    Console.WriteLine($"{priceOfFuel:f2} lv.");
}
else if (amauntOfFuel >= 20 && tipeOfFuel == "Gasoline" && holdingCard == "No")
{
    double priceOfFuel = (amauntOfFuel * priceOfPetrol) * 0.92;
    Console.WriteLine($"{priceOfFuel:f2} lv.");
}


else if (tipeOfFuel == "Gas" && holdingCard == "No")
{
    double priceOfFuel = amauntOfFuel * priceOfGas;
    Console.WriteLine($"{priceOfFuel:f2} lv.");
}
else if (tipeOfFuel == "Diesel" && holdingCard == "No")
{
    double priceOfFuel = amauntOfFuel * priceOfDiesel;
    Console.WriteLine($"{priceOfFuel:f2} lv.");
}
else if (tipeOfFuel == "Gasoline" && holdingCard == "No")
{
    double priceOfFuel = amauntOfFuel * priceOfPetrol;
    Console.WriteLine($"{priceOfFuel:f2} lv.");
}


else if (tipeOfFuel == "Gas" && holdingCard == "Yes")
{
    double priceOfFuel = amauntOfFuel * priceOfPetrolWithCard;
    Console.WriteLine($"{priceOfFuel:f2} lv.");
}
else if (tipeOfFuel == "Diesel" && holdingCard == "Yes")
{
    double priceOfFuel = amauntOfFuel * priceOfDieselWithCard;
    Console.WriteLine($"{priceOfFuel:f2} lv.");
}
else if (tipeOfFuel == "Gasoline" && holdingCard == "Yes")
{
    double priceOfFuel = amauntOfFuel * priceOfGasWithCard;
    Console.WriteLine($"{priceOfFuel:f2} lv.");
}