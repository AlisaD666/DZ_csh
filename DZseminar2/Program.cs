Console.WriteLine("Введите трехзначное число ");
int value = int.Parse(Console.ReadLine());
int b = (value % 100)/10;
System.Console.WriteLine(b);