Queue<int> player1 = new Queue<int>(Array.ConvertAll(Console.ReadLine()
    .Split(" "), int.Parse));
Queue<int> player2 = new Queue<int>(Array.ConvertAll(Console.ReadLine()
    .Split(" "), int.Parse));

while (player1.Count > 0 && player2.Count > 0)
{
    int card1 = player1.Dequeue();
    int card2 = player2.Dequeue();

    if (card1 > card2)
    {
        player1.Enqueue(card1);
        player1.Enqueue(card2);
    }
    else if (card2 > card1)
    {
        player2.Enqueue(card2);
        player2.Enqueue(card1);
    }
}

if (player1.Count > 0)
{
    int sum = CalculateSum(player1);
    Console.WriteLine($"First player wins! Sum: {sum}");
}
else if (player2.Count > 0)
{
    int sum = CalculateSum(player2);
    Console.WriteLine($"Second player wins! Sum: {sum}");
}
else
{
    Console.WriteLine("No winner");
}
    static int CalculateSum(Queue<int> queue)
{
    int sum = 0;
    foreach (int card in queue)
    {
        sum += card;
    }
    return sum;
}