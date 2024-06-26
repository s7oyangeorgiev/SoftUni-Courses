string project = Console.ReadLine();
int lines = int.Parse(Console.ReadLine());
int colonies = int.Parse(Console.ReadLine());

double priceproject = 0;

switch (project)
{
    case "Premiere": priceproject = 12.00; break;
    case "Normal": priceproject = 7.50; break;
    case "Discount": priceproject = 5.00; break;
    default: Console.WriteLine("unknown project"); return;
}
double totalPrice = lines * colonies * priceproject;
Console.WriteLine($"{totalPrice:f2} leva");