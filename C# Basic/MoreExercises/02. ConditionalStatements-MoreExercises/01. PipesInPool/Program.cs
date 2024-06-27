double vPoolVolumeInLiters = double.Parse(Console.ReadLine());
double p1 = double.Parse(Console.ReadLine());
double p2 = double.Parse(Console.ReadLine());
double hHoursWorkerMissing = double.Parse(Console.ReadLine());

double firstPipe = hHoursWorkerMissing * p1;
double secondPipe = hHoursWorkerMissing * p2;
double totalFirstAndSecondPipe = firstPipe + secondPipe;
double fullyPoolInPecent = (totalFirstAndSecondPipe / vPoolVolumeInLiters) * 100;
double firstPipePercent = (firstPipe / totalFirstAndSecondPipe) * 100;
double secondPipePercent = (secondPipe / totalFirstAndSecondPipe) * 100;


if (totalFirstAndSecondPipe <= vPoolVolumeInLiters)
{
    Console.WriteLine($"The pool is {fullyPoolInPecent:f2}% full. " + 
        $"Pipe 1: {firstPipePercent:f2}%. Pipe 2: {secondPipePercent:f2}%.");
}
else
{
    Console.WriteLine($"For {hHoursWorkerMissing} " +
        $"hours the pool overflows with {totalFirstAndSecondPipe - vPoolVolumeInLiters:f2} liters.");
}