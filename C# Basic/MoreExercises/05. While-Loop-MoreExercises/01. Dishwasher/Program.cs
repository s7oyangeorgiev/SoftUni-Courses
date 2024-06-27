
int dishDetergentCount = int.Parse(Console.ReadLine());
string dishCountForWashing = Console.ReadLine();

double tottalDishDetergent = dishDetergentCount * 750;
double detergentNeeded = 0;
int washingReloadCounter = 0;
string dishesInTheWashing = "";
double tottalDetergentForDishes = 0;
double tottalDetergentForPots = 0;
int tottalDishes = 0;
int tottalPots = 0;


while (dishCountForWashing != "End")
{
    int currentDishCountForWashing = int.Parse(dishCountForWashing);
    washingReloadCounter++;
    if (washingReloadCounter % 3 == 0)
    {
        dishesInTheWashing = "pots";
        tottalDetergentForPots += (double)currentDishCountForWashing * 15;
        tottalPots += currentDishCountForWashing;
    }
    else
    {
        dishesInTheWashing = "dishes";
        tottalDetergentForDishes += (double)currentDishCountForWashing * 5;
        tottalDishes += currentDishCountForWashing;
    }
    if ((tottalDetergentForDishes + tottalDetergentForPots) > tottalDishDetergent)
    {
        break;
    }

    dishCountForWashing = Console.ReadLine();
}
if ((tottalDetergentForDishes + tottalDetergentForPots) <= tottalDishDetergent)
{
    Console.WriteLine("Detergent was enough!");
    Console.WriteLine($"{tottalDishes} dishes and {tottalPots} pots were washed.");
    Console.WriteLine($"Leftover detergent {tottalDishDetergent - (tottalDetergentForDishes + tottalDetergentForPots)} ml.");
}
else
{
    Console.WriteLine($"Not enough detergent, {(tottalDetergentForDishes + tottalDetergentForPots) - tottalDishDetergent} ml. more necessary!");
}
