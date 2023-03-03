//Задайте двумерный массив из целых чисел. Найдите 
//среднее арифметическое элементов в каждом столбце.

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

void AverageElementColumns(int [,] mass, int colum)
{
    for (int j = 0; j < mass.GetLength(1); j++)
{
    double result = 0;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        result = (result + mass[i, j]);
    }
    result = result / colum;
    Console.Write(result + "  ");
}
}

int lines = SizeFromUser("Введите количество строк: ");
int columns = SizeFromUser("Введите количество столбцов: ");
int[,] massiv = new int[lines, columns];

FillArray(massiv);
PrintArray(massiv);

AverageElementColumns(massiv, columns);