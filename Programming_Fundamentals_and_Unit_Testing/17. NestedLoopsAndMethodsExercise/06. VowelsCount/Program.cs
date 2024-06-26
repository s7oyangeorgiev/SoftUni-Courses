string text = Console.ReadLine();
VowelsLetterCount(text);
static void VowelsLetterCount(string text)
{
    int vowels = 0;

    for (int i = 0; i < text.Length; i++)
    {
        char currentLetter = text[i];
        

        switch (currentLetter)
        {
            case 'a': vowels++; break;
            case 'e': vowels++; break;
            case 'o': vowels++; break;
            case 'i': vowels++; break;
            case 'u': vowels++; break;
            case 'A': vowels++; break;
            case 'E': vowels++; break;
            case 'O': vowels++; break;
            case 'I': vowels++; break;
            case 'U': vowels++; break;
        }
    }
    Console.Write(vowels);
}