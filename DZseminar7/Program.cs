//Задайте двумерный массив размером m×n, заполненный
//случайными вещественными числами.

int SizeFromUser(string message)
{
    Console.Write(message);
    int size = Convert.ToInt32(Console.ReadLine());
    return size;
}

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

int m = SizeFromUser("Введите количество строк: ");
int n = SizeFromUser("Введите количество столбцов: ");
double[,] matrix = new double[m, n];

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();