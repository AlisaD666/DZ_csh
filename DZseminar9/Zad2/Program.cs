// Задайте значения M и N. Напишите программу, которая
// найдёт сумму натуральных элементов в промежутке от M до N.

int NumberFromUser(string message)
{
    Console.Write(message);
    int numbers = Convert.ToInt32(Console.ReadLine());
    return numbers;
}

int SummaMN(int m, int n)
{
    if (m == n)
        return n;
    return n + SummaMN(m, n - 1);
}

int M = NumberFromUser("Введите число M: ");
int N = NumberFromUser("Введите число N: ");
Console.WriteLine(SummaMN(M, N));