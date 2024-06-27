
int boughtFood = int.Parse(Console.ReadLine());
string command = Console.ReadLine();

double boughtFoodInGrams = boughtFood * 1_000;
double tottalEatedFood = 0;

while (command != "Adopted")
{
    int eatedFood = int.Parse(command);
    tottalEatedFood += eatedFood;

    command = Console.ReadLine();
}
if (tottalEatedFood <= boughtFoodInGrams)
{
    Console.WriteLine($"Food is enough! Leftovers: {boughtFoodInGrams - tottalEatedFood} grams.");
}
else
{
    Console.WriteLine($"Food is not enough. You need {tottalEatedFood - boughtFoodInGrams} grams more.");
}