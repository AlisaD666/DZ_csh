Console.WriteLine("Введите координату х для 1 точки: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y для 1 точки: ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z для 1 точки: ");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату x для 2 точки: ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y для 2 точки: ");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z для 2 точки: ");
int z2 = int.Parse(Console.ReadLine());

int A = x2 - x1;
int B = y2 - y1;
int C = z2 - z1;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine(length);