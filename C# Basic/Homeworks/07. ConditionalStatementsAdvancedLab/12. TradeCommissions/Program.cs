string city = Console.ReadLine();
double sales = double.Parse(Console.ReadLine());

double comission = 0;
bool isTrue = false;

if (city == "Sofia")
{
    if (sales >= 0 && sales <= 500) {  comission = sales * 0.05; }
    else if ( sales > 500 && sales <= 1000) { comission = sales * 0.07; }
    else if (sales > 1_000 && sales <= 10_000) { comission = sales * 0.08; }
    else if (sales > 10_000) { comission = sales * 0.12; }
    else { Console.WriteLine("error"); isTrue = true; }
}
else if (city == "Varna")
{
    if (sales >= 0 && sales <= 500) { comission = sales * 0.045; }
    else if (sales > 500 && sales <= 1000) { comission = sales * 0.075; }
    else if (sales > 1_000 && sales <= 10_000) { comission = sales * 0.10; }
    else if (sales > 10_000) { comission = sales * 0.13; }
    else { Console.WriteLine("error"); isTrue = true; }
}
else if (city == "Plovdiv")
{
    if (sales >= 0 && sales <= 500) { comission = sales * 0.055; }
    else if (sales > 500 && sales <= 1000) { comission = sales * 0.08; }
    else if (sales > 1_000 && sales <= 10_000) { comission = sales * 0.12; }
    else if (sales > 10_000) { comission = sales * 0.145; }
    else { Console.WriteLine("error"); isTrue = true; }
}
else
{
    Console.WriteLine("error");
    isTrue = true;
}
if (!isTrue)
{
    Console.WriteLine($"{comission:f2}");
}