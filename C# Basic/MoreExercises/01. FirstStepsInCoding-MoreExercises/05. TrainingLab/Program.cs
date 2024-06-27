double lenght = double.Parse(Console.ReadLine()) * 100;
double width  = double.Parse(Console.ReadLine()) * 100;

double deskInRow = Math.Floor((width - 100) / 70);
double rows = Math.Floor(lenght / 120);
double totalPlaces = Math.Floor(deskInRow * rows) - 3;

Console.WriteLine(totalPlaces);