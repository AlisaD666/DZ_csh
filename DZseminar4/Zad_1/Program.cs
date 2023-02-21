//Напишите метод, который принимает на вход два числа (A и B)
//и возводит число A в натуральную степень B.

Console.WriteLine("Введите число A ");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B ");
int numberB = int.Parse(Console.ReadLine());

if (numberB > 0)
{   
    Console.WriteLine($"Число {numberA} в степени {numberB} = {ProgramDegree(numberA, numberB)}");
}

else Console.WriteLine("Введите число B, которое больше 0");

int ProgramDegree(int A, int B)
{
    int result = 1;
    for (int i = 1; i < B; i++)
    {
        result = result * A;
    }
    return result;
}