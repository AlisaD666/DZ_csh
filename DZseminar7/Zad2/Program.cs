// Напишите программу, которая на вход принимает позиции
//элемента в двумерном массиве, и возвращает значение этого элемента
//4 или же указание, что такого элемента нет.

int ValueFromUser(string message)
{
    Console.Write(message);
    int size = Convert.ToInt32(Console.ReadLine());
    return size;
}

void PrintArray(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write(mass[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = new Random().Next(1, 10);
        }
    }
}

void CoordinateCheck(int[,] mass, int lin, int col)
{
    if (lin > mass.GetLength(0) || col > mass.GetLength(1))
    {
        Console.WriteLine("Такого элемента нет в массиве");
    }
    else
    {
        Console.WriteLine($"Значение элемента: {mass[lin - 1, col - 1]}");
    }
}

int[,] massiv = new int[3, 3];
FillArray(massiv);
PrintArray(massiv);

int line = ValueFromUser("Введите координату строки: ");
int column = ValueFromUser("Введите координату стобца: ");
CoordinateCheck(massiv, line, column);