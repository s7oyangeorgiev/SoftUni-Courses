

int sumTarget = int.Parse(Console.ReadLine());
string price = Console.ReadLine();

double tottalMoney = 0;
double tottalCashMoney = 0;
double tottalCardMoney = 0;
int paymentCashCounter = 0;
int paymentCardCounter = 0;
int paymentCounter = 0;
string paymentMetod = "";

while (price != "End")
{
    double currentPrice = double.Parse(price);
    paymentCounter++;

    if (paymentCounter % 2 == 1)
    {
        paymentMetod = "cash";

        if (currentPrice > 100)
        {
            Console.WriteLine("Error in transaction!");
            tottalMoney += 0;
        }
        else
        {
            Console.WriteLine("Product sold!");
            tottalMoney += currentPrice;
            tottalCashMoney += currentPrice;
            paymentCashCounter++;
        }

    }
    else
    {
        paymentMetod = "card";

        if (currentPrice < 10)
        {
            Console.WriteLine("Error in transaction!");
            tottalMoney += 0;
        }
        else
        {
            Console.WriteLine("Product sold!");
            tottalMoney += currentPrice;
            tottalCardMoney += currentPrice;
            paymentCardCounter++;
        }
    }

    if (tottalMoney >= sumTarget)
    {
        break;
    }

    price = Console.ReadLine();
}
double avarageWhitCash = tottalCashMoney / paymentCashCounter;
double avarageWhitCard = tottalCardMoney / paymentCardCounter;

if (tottalMoney >= sumTarget)
{
    Console.WriteLine($"Average CS: {avarageWhitCash:f2}");
    Console.WriteLine($"Average CC: {avarageWhitCard:f2}");
}
else
{
    Console.WriteLine("Failed to collect required money for charity.");
}

