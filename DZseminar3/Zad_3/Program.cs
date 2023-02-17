Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());
int cube;
if (number >= 1)
{
    ProgramCube(number, out cube);
    Console.WriteLine(cube);
}

else
{
    Console.WriteLine("Ошибка, введите число от 1");
}
void ProgramCube(int a, out int i)
{
    for (i = 1;i <= a; i++) Console.WriteLine(i * i * i);
}