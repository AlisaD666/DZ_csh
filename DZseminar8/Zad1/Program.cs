//Задайте двумерный массив. Напишите программу, которая 
//упорядочит по убыванию элементы каждой строки двумерного массива.

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

void SortingRowElements(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            for (int k = 0; k < mass.GetLength(1) - 1; k++)
            {
                if (mass[i, k] < mass[i, k + 1])
                {
                    int result = mass[i, k + 1];
                    mass[i, k + 1] = mass[i, k];
                    mass[i, k] = result;
                }
            }
        }
    }
}

int lines = SizeFromUser("Введите количество строк: ");
int columns = SizeFromUser("Введите количество столбцов: ");
int[,] massiv = new int[lines, columns];
FillArray(massiv);
PrintArray(massiv);

Console.WriteLine("Отсортированный массив: ");
SortingRowElements(massiv);
PrintArray(massiv);