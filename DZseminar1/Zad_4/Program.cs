//Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
///5 -> 2, 4
///8 -> 2, 4, 6, 8

int N, i;
Console.WriteLine("Введите число ");
N = int.Parse(Console.ReadLine());

for (i = 1; i <= N; i++)
{
    i = i + 1;
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}