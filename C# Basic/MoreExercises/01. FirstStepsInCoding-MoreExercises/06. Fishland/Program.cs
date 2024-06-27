double scumriyaBgnPriceForKg = double.Parse(Console.ReadLine());
double cacaBgnPriceForKg = double.Parse(Console.ReadLine());
double palamudQuantity = double.Parse(Console.ReadLine());
double safridQuantity = double.Parse(Console.ReadLine());
double midiQuantity = double.Parse(Console.ReadLine());

double palamudPrice = palamudQuantity * (scumriyaBgnPriceForKg * 1.60);
double safridPrice = safridQuantity * (cacaBgnPriceForKg * 1.80);
double midiPrice = midiQuantity * 7.50;

double totalPrice = palamudPrice + safridPrice + midiPrice;

Console.WriteLine($"{totalPrice:f2}");
