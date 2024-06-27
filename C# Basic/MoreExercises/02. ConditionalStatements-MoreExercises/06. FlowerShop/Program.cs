//input
int numbersOfMagnolias = int.Parse(Console.ReadLine());
int numbersOfZiumbiuli = int.Parse(Console.ReadLine());
int numbersOfRoses = int.Parse(Console.ReadLine());
int numbersOfCactus = int.Parse(Console.ReadLine());
double priceOfPresent = double.Parse(Console.ReadLine());

double priceOfMagnolias = 3.25;
double priceOfZiumbiuli = 4.00;
double priceOfRoses = 3.50;
double priceOfCactus = 8.00;

//calculations
double price = (numbersOfMagnolias * priceOfMagnolias) + (numbersOfZiumbiuli * priceOfZiumbiuli) +
    (numbersOfRoses * priceOfRoses) + (numbersOfCactus * priceOfCactus);
double tax = price * 0.05;
double profit = price - tax;

//output
if (priceOfPresent > profit)
{
    double lack = priceOfPresent - profit;
    Console.WriteLine($"She will have to borrow {Math.Ceiling(lack)} leva.");
}
else
{
    double lack = profit - priceOfPresent;
    Console.WriteLine($"She is left with {Math.Floor(lack)} leva.");
}
