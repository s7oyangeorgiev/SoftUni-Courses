string password = Console.ReadLine();

if (!CheckPassBetweenSixAndTenCharacters(password))
{
    Console.WriteLine("Password must be between 6 and 10 characters");
}

if (!CheckPassIsContainOnlyLettersAndDigits(password))
{
    Console.WriteLine("Password must consist only of letters and digits");
}
if (!CheckPassIsContainAtleastTwoDigits(password))
{
    Console.WriteLine("Password must have at least 2 digits");
}
if (CheckPassBetweenSixAndTenCharacters(password) &&
    CheckPassIsContainOnlyLettersAndDigits(password) &&
    CheckPassIsContainAtleastTwoDigits(password))
{
    Console.WriteLine("Password is valid");
}

static bool CheckPassBetweenSixAndTenCharacters(string pass)
{
    if (pass.Length >= 6 && pass.Length <= 10)
    {
        return true;
    }
    return false;
}

static bool CheckPassIsContainOnlyLettersAndDigits(string pass)
{
    for (int i = 0; i < pass.Length; i++)
    {
        char currentLetter = pass[i];

        if (!char.IsLetterOrDigit(currentLetter))
        {
            return false;
        }
    }
    return true;
}

static bool CheckPassIsContainAtleastTwoDigits(string pass)
{
    int digitCounter = 0;

    for (int i = 0; i < pass.Length; i++)
    {
        char currentLetter = pass[i];

        if (char.IsDigit(currentLetter))
        {
            digitCounter++;
        }

        if (digitCounter >= 2)
        {
            return true;
        }
    }
    return false;
}

