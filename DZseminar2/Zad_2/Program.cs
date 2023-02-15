Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());
int thirdNumber = 0;
while(number > 999)
{
    number = number / 10;
}
thirdNumber = number % 10;
Console.WriteLine(thirdNumber);

if(number / 100 == 0)
{
  Console.WriteLine("Третьей цифры нет");  
}