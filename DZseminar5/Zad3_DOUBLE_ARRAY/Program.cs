// Задайте массив вещественных чисел. Найдите разницу
// между максимальным и минимальным элементов массива.

double[] CrateArray(int size)
{
    return new double[size];
}

int GetNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

string Print(double[] array)
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

void FillByRandom(double[] array)
{
    int size = array.Length;
    int index = 0;
    Random rand = new Random();
    while (index < size)
    {
        array[index] = Math.Round(rand.NextDouble() * 100);
        index++;
    }
}

void DifferenceMaxMin(double[] array)
{
    var max = array[0];
    var min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }

    Console.WriteLine($"Разность между макс и мин = {max - min}");
}

int size = GetNumber("Введите размер массива ");
double[] numbers = CrateArray(size);
FillByRandom(numbers);
Console.WriteLine(Print(numbers));
DifferenceMaxMin(numbers);