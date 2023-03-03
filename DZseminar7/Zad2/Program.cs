// Напишите программу, которая на вход принимает позиции
//элемента в двумерном массиве, и возвращает значение этого элемента
//4 или же указание, что такого элемента нет.

int SizeFromUser(string message)
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



int lines = SizeFromUser("Введите количество строк: ");
int columns = SizeFromUser("Введите количество столбцов: ");
int[,] massiv = new int[lines, columns];

FillArray(massiv);
PrintArray(massiv);
