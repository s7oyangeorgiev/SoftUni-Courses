int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());
int area = TriangleArea(width, length);
Console.WriteLine(area);

static int TriangleArea(int w, int l)
{
    int areaResult = w * l;
    return areaResult;
}