//Задача 10: Напишите программу, которая принимает 
//на вход трёхзначное число и на выходе показывает 
//вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число ");
int value = int.Parse(Console.ReadLine());
int b = (value % 100)/10;
System.Console.WriteLine(b);