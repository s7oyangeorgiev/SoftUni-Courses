string month = Console.ReadLine();
int numberOfNights = int.Parse(Console.ReadLine());

double studioPrice = 0;
double apartmentPrice = 0;

if (month == "May" || month == "October")
{
    if (numberOfNights > 7 && numberOfNights <= 14)
    {
        studioPrice = (numberOfNights * 50) - ((numberOfNights * 50) * 0.05);
        apartmentPrice = numberOfNights * 65;
    }
    else if (numberOfNights > 14)
    {
        studioPrice = (numberOfNights * 50) - ((numberOfNights * 50) * 0.30);
        apartmentPrice = (numberOfNights * 65) - ((numberOfNights * 65) * 0.10);
    }
    else
    {
        studioPrice = numberOfNights * 50;
        apartmentPrice = numberOfNights * 65;
    }

}
else if (month == "June" || month == "September")
{
    if (numberOfNights > 14)
    {
        studioPrice = (numberOfNights * 75.20) - ((numberOfNights * 75.20) * 0.20);
        apartmentPrice = (numberOfNights * 68.70) - ((numberOfNights * 68.70) * 0.10);
    }
    else
    {
        studioPrice = numberOfNights * 75.20;
        apartmentPrice = numberOfNights * 68.70;
    }
}
else if (month == "July" || month == "August")
{
    if (numberOfNights > 14)
    {
        studioPrice = numberOfNights * 76;
        apartmentPrice = (numberOfNights * 77) - ((numberOfNights * 77.00) * 0.10);
    }
    else
    {
        studioPrice = numberOfNights * 76;
        apartmentPrice = numberOfNights * 77;
    }
}

Console.WriteLine($"Apartment: {apartmentPrice:f2} lv.");
Console.WriteLine($"Studio: {studioPrice:f2} lv.");
