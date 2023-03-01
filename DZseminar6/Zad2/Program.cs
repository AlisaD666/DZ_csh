Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

void CoordinateIntersection(double a1, double c1, double a2, double c2)
{
double X = (-a2 + a1)/(-c1 + c2);
double Y = c2 * x + a2;

Console.WriteLine($"точка пересечения двух прямых X: {X}, Y: {Y}");
}

CoordinateIntersection(b1, k1, b2, k2);

