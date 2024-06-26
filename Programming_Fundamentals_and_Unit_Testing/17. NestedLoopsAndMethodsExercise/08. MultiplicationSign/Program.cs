int numOne = int.Parse(Console.ReadLine());
int numWto = int.Parse(Console.ReadLine());
int numThree = int.Parse(Console.ReadLine());

string result = "";

if (numOne == 0 || numWto == 0 || numThree == 0)
{
    result = "zero";
}
else if ((numOne < 0 && numWto < 0 && numThree > 0) || (numOne < 0 && numThree < 0 && numWto > 0) || 
    (numWto < 0 && numThree < 0 && numOne >0))
{
    result = "positive";
}
else if (numOne < 0 || numWto < 0 || numThree < 0)
{
    result = "negative";
}
else
{
    result = "positive";
}

Console.WriteLine(result);