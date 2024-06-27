
string country = Console.ReadLine();
string appliance = Console.ReadLine();

double difficulty = 0;
double strain = 0;

if (country == "Russia")
{
    

    switch (appliance)
    {
        case "ribbon": difficulty = 9.100; strain = 9.400; break;
        case "hoop": difficulty = 9.300; strain = 9.800; break;
        case "rope": difficulty = 9.600; strain = 9.000; break;
    }
}
else if (country == "Bulgaria")
{
    switch (appliance)
    {
        case "ribbon": difficulty = 9.600; strain = 9.400; break;
        case "hoop": difficulty = 9.550; strain = 9.750; break;
        case "rope": difficulty = 9.500; strain = 9.400; break;
    }
}
else if (country == "Italy")
{
    switch (appliance)
    {
        case "ribbon": difficulty = 9.200; strain = 9.500; break;
        case "hoop": difficulty = 9.450; strain = 9.350; break;
        case "rope": difficulty = 9.700; strain = 9.150; break;
    }
}

double totalAssessment = difficulty + strain;
double diffFromMaxAssessment = 20 - totalAssessment;
double diffFromMaxAssessmentPercent = (diffFromMaxAssessment / 20) * 100;

Console.WriteLine($"The team of {country} get {totalAssessment:f3} on {appliance}.");
Console.WriteLine($"{diffFromMaxAssessmentPercent:f2}%");



