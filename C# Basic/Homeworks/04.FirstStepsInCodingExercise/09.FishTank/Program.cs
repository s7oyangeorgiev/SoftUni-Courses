int lengthInSantimeters = int.Parse(Console.ReadLine());
int widthInSantimeters = int.Parse(Console.ReadLine());
int heightInSantimeters = int.Parse(Console.ReadLine());
double percent = double.Parse(Console.ReadLine());

double aquariumVolume = lengthInSantimeters * widthInSantimeters * heightInSantimeters;
double volumeInLitters = aquariumVolume * 0.001;
double percentOccupied = percent / 100;
double litersNeeded = volumeInLitters * (1 - percentOccupied);

Console.WriteLine(litersNeeded);


