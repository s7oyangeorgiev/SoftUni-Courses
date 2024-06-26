double depositedAmount = double.Parse(Console.ReadLine());
int depositInMonths = int.Parse(Console.ReadLine());
double interestRate =  double.Parse(Console.ReadLine());

double accumulatedInterest = depositedAmount * interestRate / 100;
double interestForOneMonth = accumulatedInterest / 12;
double amount = depositedAmount + depositInMonths * interestForOneMonth;

Console.WriteLine($"{amount:f2}");