
int studentQantity = int.Parse(Console.ReadLine());

double studentBetween2And3 = 0;
double studentBetween3And4 = 0;
double studentBetween4And5 = 0;
double studentUp5 = 0;
double sumOfGrade = 0;



for (int i = 0; i < studentQantity; i++)
{
    double examGrade = double.Parse(Console.ReadLine());

    if (examGrade >= 2.00 && examGrade <= 2.99)
    {
        studentBetween2And3 += 1;
        sumOfGrade += examGrade;
    }
    else if (examGrade >= 3.00 && examGrade <= 3.99)
    {
        studentBetween3And4 += 1;
        sumOfGrade += examGrade;
    }
    else if (examGrade >= 4.00 && examGrade <= 4.99)
    {
        studentBetween4And5 += 1;
        sumOfGrade += examGrade;
    }
    else if (examGrade >= 5.00)
    {
        studentUp5 += 1;
        sumOfGrade += examGrade;
    }
}
double middleGrade = sumOfGrade / studentQantity;

Console.WriteLine($"Top students: {studentUp5 / studentQantity * 100:f2}%");
Console.WriteLine($"Between 4.00 and 4.99: {studentBetween4And5 / studentQantity * 100:f2}%");
Console.WriteLine($"Between 3.00 and 3.99: {studentBetween3And4 / studentQantity * 100:f2}%");
Console.WriteLine($"Fail: {studentBetween2And3 / studentQantity * 100:f2}%");
Console.WriteLine($"Average: {middleGrade:f2}");