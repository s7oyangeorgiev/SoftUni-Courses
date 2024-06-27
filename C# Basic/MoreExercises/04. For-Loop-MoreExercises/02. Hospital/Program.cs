
int periodForCalculations = int.Parse(Console.ReadLine());

int doctors = 7;
int unreviewedPatients = 0;
int reviewedPatients = 0;
int checkedDay = 0;

for (int i = 0; i < periodForCalculations; i++)
{
    int patientsForDay = int.Parse(Console.ReadLine());
    checkedDay += 1;

    if (checkedDay % 3 == 0 && reviewedPatients < unreviewedPatients)
    {
        doctors += 1;
    }
    if (doctors <= patientsForDay)
    {
        unreviewedPatients += patientsForDay - doctors;
        reviewedPatients += doctors;
        
    }
    else
    {
        if (patientsForDay == doctors)
        {
            reviewedPatients += doctors;
            
        }
        else if (patientsForDay < doctors)
        {
            reviewedPatients += patientsForDay;
            
        }
    }
}

Console.WriteLine($"Treated patients: {reviewedPatients}.");
Console.WriteLine($"Untreated patients: {unreviewedPatients}.");