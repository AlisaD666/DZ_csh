//Напишите программу, которая принимает на вход
//три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22


int max = 0;
int a;
Console.WriteLine("Введите число ");
a = int.Parse(Console.ReadLine());

int b;
Console.WriteLine("Введите число ");
b = int.Parse(Console.ReadLine());

int c;
Console.WriteLine("Введите число ");
c = int.Parse(Console.ReadLine());

if (a > max)
{
    max = a;
}
if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}


Console.WriteLine("max = ");
Console.WriteLine(max);