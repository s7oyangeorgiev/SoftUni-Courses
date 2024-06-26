string typeOfMovie = Console.ReadLine();
int countOfRows = int.Parse(Console.ReadLine());
int countOfSeatsPerRow =  int.Parse(Console.ReadLine());

double pricePerSeat = 0;

if (typeOfMovie == "Premiere")
{
    pricePerSeat += 12.00;
}
else if (typeOfMovie == "Normal")
{
    pricePerSeat += 7.50;
}
else if (typeOfMovie == "Discount")
{
    pricePerSeat += 5.00;
}

double totalSeats = countOfRows * countOfSeatsPerRow;
double totalPriceForAllSeats = totalSeats * pricePerSeat;

Console.WriteLine($"{totalPriceForAllSeats:f2}");