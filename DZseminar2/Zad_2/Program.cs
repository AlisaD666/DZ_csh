//Напишите программу, которая выводит 
//третью цифру заданного числа или сообщает, 
//что третьей цифры нет.
Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());
int thirdNumber;
if (number > 99)
{
    Program13(number, out thirdNumber);
    Console.WriteLine(thirdNumber);
}

else
{
    Console.WriteLine("Третьей цифры нет");
}
static void Program13(int a, out int f)
{
    while (a > 999)
    {
        a = a / 10;
    }
    f = a % 10;
}