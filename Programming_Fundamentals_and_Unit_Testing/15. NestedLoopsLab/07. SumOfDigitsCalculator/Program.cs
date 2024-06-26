string num = "";

while ( num != "End")
{
    string currentNum = Console.ReadLine();
    
    if (currentNum == "End")
    {
        Console.WriteLine("Goodbye");
        break;
    }
    int digitsNum = int.Parse(currentNum);
    
    int sum = currentNum.ToString().Select(digit => int.Parse(digit.ToString())).ToArray().Sum();
    Console.WriteLine($"Sum of digits = {sum}");
}



//while (true)
//{
//    string currentNum = Console.ReadLine();

//    if (currentNum == "End")
//    {
//        Console.WriteLine("Goodbye");
//        break;
//    }
//    int digitsNum = int.Parse(currentNum);

//    int sum = currentNum.ToString().Select(digit => int.Parse(digit.ToString())).ToArray().Sum();
//    Console.WriteLine($"Sum of digits = {sum}");
//}