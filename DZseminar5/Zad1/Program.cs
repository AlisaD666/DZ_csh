//Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет
// количество чётных чисел в массиве.

int[] CrateArray(int size)
{
    return new int[size];
}

int GetNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

string Print(int[] array)
{
    string result = string.Empty;
    int len = array.Length;
    int index = 0;
    while (index < len)
    {
        result = result + " " + array[index];
        index++;
    }
    return result;
}

void FillByRandom(int[] array)
{
    int size = array.Length;
    int index = 0;
    Random rand = new Random();
    while (index < size)
    {
        array[index] = rand.Next(100, 999);
        index++;
    }
}

void EvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            count++;

    Console.WriteLine($"{count} чётных");
}


int size = GetNumber("Введите размер массива ");
int[] numbers = CrateArray(size);
FillByRandom(numbers);
Console.WriteLine(Print(numbers));
EvenNumbers(numbers);
