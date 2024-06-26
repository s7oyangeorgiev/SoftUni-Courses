
string userName = Console.ReadLine();
string password = Console.ReadLine();

while (true)
{
    string currentPassword = Console.ReadLine();
    
    if (currentPassword == password)
    {
        Console.WriteLine($"Welcome {userName}!");
        break;
    }
}