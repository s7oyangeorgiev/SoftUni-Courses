
int bitcoins = int.Parse(Console.ReadLine());
double chineesUana = double.Parse(Console.ReadLine());
double commission = double.Parse(Console.ReadLine());

double bitcoinsSum = (bitcoins * 1168.00) / 1.95;
double uanaSum = ((chineesUana * 0.15) * 1.76) / 1.95;

double Sum = bitcoinsSum + uanaSum;
double commisionSum = Sum * (commission / 100);

double tottalSum = Sum - commisionSum;

Console.WriteLine($"{tottalSum:f2}");

