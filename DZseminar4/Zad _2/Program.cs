// Напишите метод, который принимает на вход
// число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число  ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine($"Сумма цифр в числе {number} = {SumNumber(number)}");

int SumNumber(int num)
{
    int sum = 0;
while (num > 0)
{
    sum = sum + num % 10;
    num = num / 10;
}
return sum;
}