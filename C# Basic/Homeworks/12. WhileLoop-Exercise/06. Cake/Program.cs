
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());

int piecesCount = width * height;
int onePiece = 1;

while (piecesCount > 0)
{
    string command = Console.ReadLine();

    if (command == "STOP")
    {
        break;
    }
    else
    {
        int pieces = int.Parse(command);
        piecesCount -= pieces;
    }
}
if (piecesCount > 0)
{
    Console.WriteLine($"{piecesCount} pieces are left.");
}
else
{
    Console.WriteLine($"No more cake left! You need {Math.Abs(piecesCount)} pieces more.");
}