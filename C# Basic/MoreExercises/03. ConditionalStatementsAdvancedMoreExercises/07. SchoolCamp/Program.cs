//Сезонът – текст - “Winter”, “Spring” или “Summer”;
//Видът на групата – текст - “boys”, “girls” или “mixed”;
//Брой на учениците – цяло число в интервала [1 … 10000] ;
//Брой на нощувките – цяло число в интервала [1 … 100].


string season = Console.ReadLine();
string groupTipe = Console.ReadLine();
int studentCount = int.Parse(Console.ReadLine());
int nightCount = int.Parse(Console.ReadLine());

double pricePerNightForGirls = 0;
double pricePerNightForBoys = 0;
double pricePerNightForGirlsAndBoys = 0;
string sportForGirls = "";
string sportForBoys = "";
string sportForGirlsANdBoys = "";
double totalPrice = 0;
string sport = "";

switch (season)
{
    case "Winter":
    pricePerNightForGirls = 9.60;
    pricePerNightForBoys = 9.60;
    pricePerNightForGirlsAndBoys = 10;
        break;
    case "Spring":
    pricePerNightForGirls = 7.20;
    pricePerNightForBoys = 7.20;
    pricePerNightForGirlsAndBoys = 9.50;
        break;
    default:
    pricePerNightForGirls = 15;
    pricePerNightForBoys = 15;
    pricePerNightForGirlsAndBoys = 20;
        break;
}
switch (studentCount)
{
    case >= 50: pricePerNightForGirlsAndBoys *= 0.50; pricePerNightForGirls *= 0.50; pricePerNightForBoys *= 0.50; break;
    case >= 20 and < 50: pricePerNightForGirlsAndBoys *= 0.85; pricePerNightForGirls *= 0.85; pricePerNightForBoys *= 0.85; break;
    case >= 10 and < 20: pricePerNightForGirlsAndBoys *= 0.95; pricePerNightForGirls *= 0.95; pricePerNightForBoys *= 0.95; break;
}
switch (season)
{
    case "Winter":
        if (groupTipe == "girls")
        {
            sport = "Gymnastics";
        }
        else if (groupTipe == "boys")
        {
            sport = "Judo";
        }
        else
        {
            sport = "Ski";
        }
            break;
    case "Spring":
        if (groupTipe == "girls")
        {
            sport = "Athletics";
        }
        else if (groupTipe == "boys")
        {
            sport = "Tennis";
        }
        else
        {
            sport = "Cycling";
        }
        break;
    default:
        if (groupTipe == "girls")
        {
            sport = "Volleyball";
        }
        else if (groupTipe == "boys")
        {
            sport = "Football";
        }
        else
        {
            sport = "Swimming";
        }
        break;
}
switch (groupTipe)
{
    case "girls": totalPrice = (studentCount * nightCount * pricePerNightForGirls); break;
    case "boys": totalPrice = (studentCount * nightCount * pricePerNightForBoys); break;
    case "mixed": totalPrice = (studentCount * nightCount * pricePerNightForGirlsAndBoys); break;
}
Console.WriteLine($"{sport} {totalPrice:f2} lv.");