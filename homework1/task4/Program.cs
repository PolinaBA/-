// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

Console.WriteLine("Введите первое число");
string A = Console.ReadLine()!;
int numberA = Convert.ToInt32(A);


Console.WriteLine("Введите второе число");
string B = Console.ReadLine()!;
int numberB = Convert.ToInt32(B);

Console.WriteLine("Введите третье  число");
string C = Console.ReadLine()!;
int numberC = Convert.ToInt32(C);

int max = numberA;

if (numberB > max)
{
     max = numberB;
}

if(numberC > max)
{
    max = numberC;
}

Console.WriteLine(max);
