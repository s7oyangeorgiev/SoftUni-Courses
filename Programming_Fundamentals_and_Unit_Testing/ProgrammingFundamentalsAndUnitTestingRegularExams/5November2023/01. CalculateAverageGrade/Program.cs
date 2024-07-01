int countOfStudents = int.Parse(Console.ReadLine());

double[] grades = new double[countOfStudents];
double sum = 0;

for (int i = 0; i < countOfStudents; i++)
{
    grades[i] = double.Parse(Console.ReadLine());
    sum += grades[i];
}

double average = sum / countOfStudents;

Console.WriteLine($"{average:F2}");