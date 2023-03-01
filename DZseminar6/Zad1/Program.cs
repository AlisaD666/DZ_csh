//Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

int [] CrateArray(int size)
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
    while(index < len)
    {
        result = result + " " + array[index];
        index++;
    }
    return result;
}

void FillByUser(int[] array)
{
   int size = array.Length;
   int index = 0;
   while(index < size)
   {
        array[index] = GetNumber("Введите " + index + "элемент");
        index++;
    }
}

void CountNumbersPositive(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"{count} чисел больше 0");
}


int size = GetNumber("Введите размер массива ");
int[] numbers = CrateArray(size);
Console.WriteLine(Print(numbers));
FillByUser(numbers);
Console.WriteLine(Print(numbers));
CountNumbersPositive(numbers);