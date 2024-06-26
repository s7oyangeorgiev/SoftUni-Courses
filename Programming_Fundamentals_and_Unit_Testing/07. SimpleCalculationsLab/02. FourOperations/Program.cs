double firstNumber = double.Parse(Console.ReadLine());
double secondNumber  = double.Parse(Console.ReadLine());

double addition = firstNumber + secondNumber;
double subtraction = firstNumber - secondNumber;
double multiplication =  secondNumber * firstNumber;
double division =  firstNumber / secondNumber;

Console.WriteLine($"{firstNumber:f2} + {secondNumber:f2} = {addition:f2}");
Console.WriteLine($"{firstNumber:f2} - {secondNumber:f2} = {subtraction:f2}");
Console.WriteLine($"{firstNumber:f2} * {secondNumber:f2} = {multiplication:f2}");
Console.WriteLine($"{firstNumber:f2} / {secondNumber:f2} = {division:f2}");