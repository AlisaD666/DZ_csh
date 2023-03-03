//Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения
//b1, k1, b2 и k2 задаются пользователем.

double GetBumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToDouble(Console.ReadLine());
}

double StraightLineX(double a1, double c1, double a2, double c2)
{
double x = (-a2 + a1)/(-c1 + c2);
return x;
}

double StraightLineY(double c2, double a2, double x)
{
    double y = c2 * x + a2;
    return y;
}

double b1 = GetBumber("Введите b1");
double k1 = GetBumber("Введите k1");
double b2 = GetBumber("Введите b2");
double k2 = GetBumber("Введите k2");
double X = StraightLineX(b1, k1, b2, k2);
double Y = StraightLineY(k2, b2, X);
Console.WriteLine($"точка пересения двух прямых в координатах Х = {X} и Y = {Y}");

