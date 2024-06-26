int lengthInCm = int.Parse(Console.ReadLine());
int widthInCm =  int.Parse(Console.ReadLine());
int heightInCm =  int.Parse(Console.ReadLine());
double percentage = double.Parse(Console.ReadLine());

double aquariumVolume = lengthInCm * widthInCm * heightInCm;
double litersVolume = aquariumVolume / 1000.00;
double occupiedSpace = percentage / 100;
double requiredLiters = litersVolume * (1 - occupiedSpace);

Console.WriteLine($"{requiredLiters:f2}");