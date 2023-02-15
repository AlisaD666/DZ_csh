//Напишите программу, которая выводит 
//третью цифру заданного числа или сообщает, 
//что третьей цифры нет.
Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());
int thirdNumber = 0;
if(number > 99)
{
while(number > 999)
{
    number = number / 10;
}
thirdNumber = number % 10;
Console.WriteLine(thirdNumber);
}

else
{
  Console.WriteLine("Третьей цифры нет");  
}