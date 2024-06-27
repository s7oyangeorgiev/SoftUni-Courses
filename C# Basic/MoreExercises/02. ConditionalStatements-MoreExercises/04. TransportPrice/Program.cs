//input
int nKm = int.Parse(Console.ReadLine());
string word = Console.ReadLine();

//calculations + output
if (nKm < 20 && word == "day")
{
    double taxiCoast = 0.70 + nKm * 0.79;
    Console.WriteLine($"{taxiCoast:f2}");
}
else if (nKm < 20 && word == "night")
{
    double taxiCoast = 0.70 + nKm * 0.90;
    Console.WriteLine($"{taxiCoast:f2}");
}
else if (nKm >= 20 && nKm <100)
{
    double busCoast = nKm * 0.09;
    Console.WriteLine($"{busCoast:f2}");
}
else
{
    double trainCoast = nKm * 0.06;
    Console.WriteLine($"{trainCoast:f2}");
}
