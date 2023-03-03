//Задайте двумерный массив размером m×n, заполненный
//случайными вещественными числами.

int SizeFromUser(string message)
{
    Console.Write(message);
    int size = Convert.ToInt32(Console.ReadLine());
    return size;
}

void PrintArray(double[,] mass)
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

void FillArray(double[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

int m = SizeFromUser("Введите количество строк: ");
int n = SizeFromUser("Введите количество столбцов: ");
double[,] massiv = new double[m, n];

FillArray(massiv);
PrintArray(massiv);
Console.WriteLine();