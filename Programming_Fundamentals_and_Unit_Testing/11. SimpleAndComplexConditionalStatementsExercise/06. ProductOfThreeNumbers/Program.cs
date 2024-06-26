int numOne = int.Parse(Console.ReadLine());
int numTwo = int.Parse(Console.ReadLine());
int numThree = int.Parse(Console.ReadLine());

int result = numOne * numTwo * numThree;

if ( result > 0 ) { Console.WriteLine("positive"); }
else if ( result == 0) { Console.WriteLine("zero"); }
else { Console.WriteLine("negative"); }