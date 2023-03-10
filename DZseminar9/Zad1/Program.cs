// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от N до 1. Выполнить
// с помощью рекурсии.

int NumberFromUser(string message)
{
    Console.Write(message);
    int numbers = Convert.ToInt32(Console.ReadLine());
    return numbers;
}

int NaturalNumbers(int n, int num)
{
    if (n == num)
        return n;
    else
        Console.Write($"{NaturalNumbers(n, num + 1)},");
    return num;
}

int N = NumberFromUser("Введите число от 1: ");
int number = 1;
Console.WriteLine(NaturalNumbers(N, number));


