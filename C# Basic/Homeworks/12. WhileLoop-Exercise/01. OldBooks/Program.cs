
//string book = Console.ReadLine();

//int chekedBooks = 0;

//while (true)
//{
//    string currentBook = Console.ReadLine();

//    if (currentBook == "No More Books")
//    {
//        Console.WriteLine("The book you search is not here!");
//        Console.WriteLine($"You checked {chekedBooks} books.");
//        break;
//    }
//    else if (currentBook == book)
//    {
//        Console.WriteLine($"You checked {chekedBooks} books and found it.");
//        break;
//    }
//    else
//    {
//        chekedBooks++;
//    }
//}

string favouriteBook = Console.ReadLine();

int bookCounter = 0;
bool isBookFound = false;

string nextBookName = Console.ReadLine();
while (nextBookName != "No More Books")
{
    if (nextBookName == favouriteBook)
    {
        isBookFound = true;
        break;
    }
    bookCounter++;
    nextBookName = Console.ReadLine();
}
if (isBookFound)
{
    Console.WriteLine($"You checked {bookCounter} books and found it.");
}
else
{
    Console.WriteLine("The book you search is not here!");
    Console.WriteLine($"You checked {bookCounter} books.");
}
