
using System.Transactions;

int customerCount = int.Parse(Console.ReadLine());

double price = 0;
int purchaseCount = 0;
double tottalPrice = 0;


for (int i = 0; i < customerCount; i++)
{
    while (true)
    {
        string purchase = Console.ReadLine();
        
        if (purchase == "Finish")
        {
            if (purchaseCount % 2 == 0)
            {
                price *= 0.80;
            }

            Console.WriteLine($"You purchased {purchaseCount} items for {price:f2} leva.");
            tottalPrice += price;
            price = 0;
            purchaseCount = 0;
            break;
        }

        purchaseCount++;

        switch (purchase)
        {
            case "basket": price += 1.50; break;
            case "wreath": price += 3.80; break;
            case "chocolate bunny": price += 7.00; break;
        }

        
    }
}
double averageBill = tottalPrice / customerCount;

Console.WriteLine($"Average bill per client is: {averageBill:f2} leva.");