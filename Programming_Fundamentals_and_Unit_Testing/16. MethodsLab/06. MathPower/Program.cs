int baseNumber = int.Parse(Console.ReadLine());
int power = int.Parse(Console.ReadLine());
int resut = BaseRaisedToPower(baseNumber, power);
Console.WriteLine(resut);

static int BaseRaisedToPower(int baseNumber, int power)
{
    int result = (int)Math.Pow(baseNumber, power);
    return result;
}