//input
double xHeightOfTheHouse = double.Parse(Console.ReadLine());
double ySidewallLength = double.Parse(Console.ReadLine());
double hTriangularWallOfTheEaves = double.Parse(Console.ReadLine());

//calculation
//walls
double sideWallArea = xHeightOfTheHouse * ySidewallLength;
double windowArea = 1.5 * 1.5;
double bothSides = (2 * sideWallArea) - (2 * windowArea);
double backWall = xHeightOfTheHouse * xHeightOfTheHouse;
double entryDoor = 1.2 * 2;
double totalBackAndEntry = (2 * backWall) - entryDoor;
double totalAreaWalls = bothSides + totalBackAndEntry;
double greenPaint = totalAreaWalls / 3.4;
//eaves
double bothRectangleOfTheEaves = 2 * (xHeightOfTheHouse * ySidewallLength);
double bothTriangleOfTheEaves = 2 * (xHeightOfTheHouse * hTriangularWallOfTheEaves / 2);
double totalAreaEaves = bothRectangleOfTheEaves + bothTriangleOfTheEaves;
double redPaint = totalAreaEaves / 4.3;

//output
Console.WriteLine($"{greenPaint:f2}");
Console.WriteLine($"{redPaint:f2}");
    