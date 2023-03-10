// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, 
//добавляя индексы каждого элемента.

int SizeFromUser(string message)
{
    Console.Write(message);
    int size = Convert.ToInt32(Console.ReadLine());
    return size;
}

void PrintArray(int[,,] massTreeD)
{
    for (int i = 0; i < massTreeD.GetLength(0); i++)
    {
        for (int j = 0; j < massTreeD.GetLength(1); j++)
        {
            for (int k = 0; k < massTreeD.GetLength(2); k++)
            {
                Console.WriteLine($"{massTreeD[i, j, k] + " "} ({i}, {k}, {j})");
            }
        }
        Console.WriteLine();
    }
}

void FillArray(int[,,] massTreeD)
{
    for (int i = 0; i < massTreeD.GetLength(0); i++)
    {
        for (int j = 0; j < massTreeD.GetLength(1); j++)
        {
            for (int k = 0; k < massTreeD.GetLength(2); k++)
            {
                massTreeD[i, j, k] = new Random().Next(10, 100);
            }
        }
    }
}


int lines = SizeFromUser("Введите количество строк: ");
int columns = SizeFromUser("Введите количество столбцов: ");
int sheets = SizeFromUser("Введите количество листов: ");
int[,,] massivTreeD = new int[lines, columns, sheets];

FillArray(massivTreeD);
PrintArray(massivTreeD);