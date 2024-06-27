
int days = int.Parse(Console.ReadLine());
double tottalWeightOfFood = double.Parse(Console.ReadLine());

double tottalEatedFood = 0;
double tottalCatFood = 0;
double tottalDogFood = 0;
double rewardCookies = 0;

for (int i = 1; i <= days; i++)
{
    int dogFood = int.Parse(Console.ReadLine());
    tottalEatedFood += dogFood;
    tottalDogFood += dogFood;

    int catFood = int.Parse(Console.ReadLine());
    tottalEatedFood += catFood;
    tottalCatFood += catFood;
    

    if (i % 3 == 0)
    {
        rewardCookies += (catFood + dogFood) * 0.10;
    }
}
double percentTottalEatedFood = (tottalEatedFood / tottalWeightOfFood) * 100;
double percentTottalCatFood = (tottalCatFood / tottalEatedFood) * 100;
double percentTottalDogFood = (tottalDogFood / tottalEatedFood) * 100;

Console.WriteLine($"Total eaten biscuits: {Math.Round(rewardCookies)}gr.");
Console.WriteLine($"{percentTottalEatedFood:f2}% of the food has been eaten.");
Console.WriteLine($"{percentTottalDogFood:f2}% eaten from the dog.");
Console.WriteLine($"{percentTottalCatFood:f2}% eaten from the cat.");