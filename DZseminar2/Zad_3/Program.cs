//Напишите программу, которая принимает на вход 
//цифру, обозначающую день недели, и проверяет, 
//является ли этот день выходным.
Console.WriteLine("Введите номер дня недели ");
int numberDay = int.Parse(Console.ReadLine());
if(numberDay > 5)
{
    Console.WriteLine("Выходной!");
}
else
{
   Console.WriteLine("Рабочий день"); 
} 