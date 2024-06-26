int packsOfPens = int.Parse(Console.ReadLine());
int packsOfMarkers = int.Parse(Console.ReadLine());
int chalkBoardCleanerInLitters = int.Parse(Console.ReadLine());
int discoundPercent = int.Parse(Console.ReadLine()); //100

double priceOfPacksOfPens = packsOfPens * 5.80;
double priceOfPacksOfMarkers = packsOfMarkers * 7.20;
double priceOfChalkBoardCleanerInLitters = chalkBoardCleanerInLitters * 1.20;

double priceOfAllMaterials = priceOfPacksOfPens + priceOfPacksOfMarkers + priceOfChalkBoardCleanerInLitters;
double discount = priceOfAllMaterials * discoundPercent / 100;

Console.WriteLine(priceOfAllMaterials - discount);

