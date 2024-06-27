
double inheritedMoney = double.Parse(Console.ReadLine());
int yearToLieve = int.Parse(Console.ReadLine());

int age = 18;
double moneySpent = 0;
int yearBack = 1800;

for (int i = yearBack; i <= yearToLieve; i++)
{
    if (i % 2 == 0)
    {
        moneySpent += 12_000;
        age++;
    }
    else
    {
        moneySpent += 12_000 + (50 * age);
        age++;
    }
}
if (inheritedMoney >= moneySpent)
{
    Console.WriteLine($"Yes! He will live a carefree life and will have {inheritedMoney - moneySpent:f2} dollars left.");
}
else
{
    Console.WriteLine($"He will need {moneySpent - inheritedMoney:f2} dollars to survive.");
}
    