 //Задайте одномерный массив, заполненный случайными числами. 
 //Найдите сумму элементов, стоящих на нечётных позициях.

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
        array[index] = rand.Next(1, 10);
        index++;
    }
}

void SumNotEvenNumbers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 1)
            sum += array[i];

    Console.WriteLine($"сумма нечетных {sum}");
}


int size = GetNumber("Введите размер массива ");
int[] numbers = CrateArray(size);
FillByRandom(numbers);
Console.WriteLine(Print(numbers));
SumNotEvenNumbers(numbers);