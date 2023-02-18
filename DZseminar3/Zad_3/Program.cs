//Напишите программу, которая принимает
//на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число от 1 ");
int number = int.Parse(Console.ReadLine());

if (number >= 1)
{
    ProgramCube(number);
    Console.WriteLine();
}

else
{
    Console.WriteLine("Ошибка, введите число от 1");
}
void ProgramCube(int a)
{
    for (int i = 1;i <= a; i++) 
    {
      Console.WriteLine("Число\tКуб");
      Console.WriteLine("{0}\t{1}", i, Math.Pow(i, 3)); 
    } 
}