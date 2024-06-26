double depositAmount = double.Parse(Console.ReadLine());   
int termDepositInMounth = int.Parse(Console.ReadLine());
double annualInterestRate = double.Parse(Console.ReadLine());

double accruedInterest = depositAmount * (annualInterestRate / 100);
double interestForMount = accruedInterest / 12;

double tottalSum = depositAmount + termDepositInMounth * interestForMount;

Console.WriteLine(tottalSum);

