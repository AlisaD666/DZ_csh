//Задача 10: Напишите программу, которая принимает 
//на вход трёхзначное число и на выходе показывает 
//вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число ");
int value = int.Parse(Console.ReadLine());
int b;
if((value >= 100) && (value <= 999))
{
   Program10(value, out b);
   Console.WriteLine(b);
}
else
{
   Console.WriteLine("Ошибка, введите трехзначное число"); 
}
static void Program10(int a, out int result)
{
result = (a % 100)/10; 
}