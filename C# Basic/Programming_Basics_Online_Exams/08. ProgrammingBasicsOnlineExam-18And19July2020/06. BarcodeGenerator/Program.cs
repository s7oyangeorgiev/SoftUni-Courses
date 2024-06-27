
string start = Console.ReadLine();
string end = Console.ReadLine();

int start1 = start[0] - '0';
int end1 = end[0] - '0';

int start2 = start[1] - '0';
int end2 = end[1] - '0';

int start3 = start[2] - '0';
int end3 = end[2] - '0';

int start4 = start[3] - '0';
int end4 = end[3] - '0';

for (int firstDigit = start1; firstDigit <= end1; firstDigit++)
{
    for (int secondDigit = start2; secondDigit <= end2; secondDigit++)
    {
        for (int thirdDigit = start3; thirdDigit <= end3; thirdDigit++)
        {
            for (int fourthDigit = start4; fourthDigit <= end4; fourthDigit++)
            {
                if (firstDigit % 2 != 0 && secondDigit % 2 != 0 && thirdDigit % 2 != 0 && fourthDigit % 2 != 0)
                {
                    Console.Write($"{firstDigit}{secondDigit}{thirdDigit}{fourthDigit} ");
                }
            }
        }
    }
}