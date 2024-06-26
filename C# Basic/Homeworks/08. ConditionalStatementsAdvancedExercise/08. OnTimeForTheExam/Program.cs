using System.Globalization;

int hourOfExam = int.Parse(Console.ReadLine());
int minuteOfExam = int.Parse(Console.ReadLine());
int araivedHour = int.Parse(Console.ReadLine());
int aravedMinutes = int.Parse(Console.ReadLine());

int examTimeInMinutes = hourOfExam * 60 + minuteOfExam;
int araivedTimeOutInMinutes = araivedHour * 60 + aravedMinutes;
int differenceInMinutes = examTimeInMinutes - araivedTimeOutInMinutes;

if (differenceInMinutes > 30)
{
    Console.WriteLine("Early");
    if (differenceInMinutes >= 60)
    {
        int hoursEarly = differenceInMinutes / 60;
        int minutesEarly = differenceInMinutes - (hoursEarly * 60);

        if (minutesEarly >= 10)
        {
            Console.WriteLine($"{hoursEarly}:{minutesEarly} hours before the start");
        }
        else
        {
            Console.WriteLine($"{hoursEarly}:0{minutesEarly} hours before the start");
        }
    }
    else
    {
        Console.WriteLine($"{differenceInMinutes} minutes before the start");
    }
}
else if (differenceInMinutes < 0)
{
    Console.WriteLine("Late");
    differenceInMinutes *= -1;

    if (differenceInMinutes >= 60)
    {
        int hoursEarly = differenceInMinutes / 60;
        int minutesEarly = differenceInMinutes - (hoursEarly * 60);

        if (minutesEarly >= 10)
        {
            Console.WriteLine($"{hoursEarly}:{minutesEarly} hours after the start");
        }
        else
        {
            Console.WriteLine($"{hoursEarly}:0{minutesEarly} hours after the start");
        }
    }
    else
    {
        Console.WriteLine($"{differenceInMinutes} minutes after the start");
    }
}
else
{
    Console.WriteLine("On time");
    if (differenceInMinutes > 0)
    {
        Console.WriteLine($"{differenceInMinutes} minutes before the start");
    }
}
