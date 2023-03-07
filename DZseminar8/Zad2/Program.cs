// Задайте прямоугольный двумерный массив. Напишите 
//программу, которая будет находить строку с наименьшей 
//суммой элементов.

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

int MinimumLineAmount(int[,] mass)
{
    int result = 0;
    int minsum = 0;
    for (int i = 0; i < 4; i++)
    {
        minsum = minsum + mass[0, i];
    }

    for (int i = 1; i < 4; i++)
    {
        int sum = 0;
        for (int j = 0; j < 4; j++)
        {
            sum = sum + mass[i, j];
        }
        if (minsum > sum)
        {
            minsum = sum;
            result = i;
        }
    }
    return result;
}


int[,] massiv = new int[4, 4];
FillArray(massiv);
PrintArray(massiv);

Console.WriteLine($"C наименьшей суммой элементов: {MinimumLineAmount(massiv)} строка");