//Напишите программу, которая на вход принимает два числа 
//и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

int max = 0;
int min = 0;

int a;
Console.WriteLine("Введите число ");
a = int.Parse(Console.ReadLine());

int b;
Console.WriteLine("Введите число ");
b = int.Parse(Console.ReadLine());

if (a > b)
{
    max = a;
    min = b;
}
else
{
    min = a;
    max = b;
}

Console.WriteLine("max = ");
Console.WriteLine(max);
Console.WriteLine("min = ");
Console.WriteLine(min);

