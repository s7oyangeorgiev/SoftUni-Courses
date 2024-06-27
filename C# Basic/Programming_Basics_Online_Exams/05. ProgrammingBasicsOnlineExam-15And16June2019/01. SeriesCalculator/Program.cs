
string nameOfSerial = Console.ReadLine();
int seasonQuantity = int.Parse(Console.ReadLine());
int episodeQuantity = int.Parse(Console.ReadLine());
double tomeOfNormalEpisodeWithoutAdvertisement =  double.Parse(Console.ReadLine());

double AdvertisementForOneEpisode = tomeOfNormalEpisodeWithoutAdvertisement * 0.20;
double timeOfEpisodeWithAdvertisement = tomeOfNormalEpisodeWithoutAdvertisement + AdvertisementForOneEpisode;
double extraTimeFromSpecialEpisode = seasonQuantity * 10;

double tottalTimeForWathing = timeOfEpisodeWithAdvertisement * episodeQuantity * seasonQuantity + extraTimeFromSpecialEpisode;

Console.WriteLine($"Total time needed to watch the {nameOfSerial} series is {Math.Round(tottalTimeForWathing)} minutes.");