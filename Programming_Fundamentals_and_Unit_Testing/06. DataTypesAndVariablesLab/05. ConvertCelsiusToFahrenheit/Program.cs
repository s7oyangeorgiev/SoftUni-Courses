double temperaturInCelsiu = double.Parse(Console.ReadLine());

double temperatureInFahrenheit = temperaturInCelsiu * 1.8 + 32;

Console.WriteLine($"{temperatureInFahrenheit:f2}");