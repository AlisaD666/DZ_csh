//Напишите метод, который задаёт
//массив из N элементов и выводит их на экран.

//Создание массива
int [] CrateArray(int size)
{
    return new int[size];
}

//Ввод числа
int GetNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

//Печать массива 
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

//Заполнение массива (рандом)
void FillByRandom(int[] array)
{
    int size = array.Length;
    int index = 0;
    Random rand = new Random();
    while(index < size)
    {
        array[index] = rand.Next(1, 10);
        index++;
    }
}

//Заполнение массива(руками)
//void FillByUser(int[] array)
//{
   // int size = array.Length;
   // int index = 0;
   // while(index < size)
   // {
   //     array[index] = GetNumber("Введите " + index + "элемент");
   //     index++;
   // }
//}


int size = GetNumber("Введите размер массива ");
int[] numbers = CrateArray(size);
Console.WriteLine(Print(numbers));

FillByRandom(numbers);
Console.WriteLine(Print(numbers));