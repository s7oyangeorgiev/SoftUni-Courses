string fruit = Console.ReadLine();
string dayOfTheWeek = Console.ReadLine();
double quiantuty = double.Parse(Console.ReadLine());

double price = 0;
bool isError = false;

if (dayOfTheWeek == "Monday" || dayOfTheWeek == "Tuesday" || dayOfTheWeek == "Wednesday" || dayOfTheWeek == "Thursday" ||
    dayOfTheWeek == "Friday")
{
    if (fruit == "banana") { price = 2.50; }
    else if (fruit == "apple") { price = 1.20; }
    else if (fruit == "orange") { price = 0.85; }
    else if (fruit == "grapefruit") { price = 1.45; }
    else if (fruit == "kiwi") { price = 2.70; }
    else if (fruit == "pineapple") { price = 5.50; }
    else if (fruit == "grapes") { price = 3.85; }
    else { Console.WriteLine("error"); isError = true; }
}
else if (dayOfTheWeek == "Saturday" || dayOfTheWeek == "Sunday")
{
    if (fruit == "banana") { price = 2.70; }
    else if (fruit == "apple") { price = 1.25; }
    else if (fruit == "orange") { price = 0.90; }
    else if (fruit == "grapefruit") { price = 1.60; }
    else if (fruit == "kiwi") { price = 3.00; }
    else if (fruit == "pineapple") { price = 5.60; }
    else if (fruit == "grapes") { price = 4.20; }
    else { Console.WriteLine("error"); isError = true; }
}
else
{
    Console.WriteLine("error");
    isError = true;
}
if (!isError)
{
    double result = price * quiantuty;
    Console.WriteLine($"{result:f2}"); 
}




