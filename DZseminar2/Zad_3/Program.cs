//Напишите программу, которая принимает на вход 
//цифру, обозначающую день недели, и проверяет, 
//является ли этот день выходным.
Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());
string numberDay;

Program11(number, out numberDay);
Console.WriteLine(numberDay);

static void Program11(int d, out string m)
{
    if ((d >= 1) && (d <= 7))
    {
        if ((d >= 1) && (d <= 5))
        {
            m = "Рабочий";
        }
        else
        {
            m = "ВЫХОДНОЙ!";
        }
    }
    else
    {
        m = "Такого дня недели не существует";
    }
}