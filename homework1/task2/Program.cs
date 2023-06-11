// Напишите программу, которая на вход принимает два числа и выдает, какое число больее, а какое меньшее

Console.WriteLine("Введите первое число");
string A = Console.ReadLine()!;
int numberA = Convert.ToInt32(A);

Console.WriteLine("Введите второе число");
string B = Console.ReadLine()!;
int numberB = Convert.ToInt32(B);

if (numberA > numberB)
{

    Console.WriteLine($"max ={numberA}, min = {numberB}");
}

if ( numberA == numberB)
{
    Console.WriteLine("Числа равны");
}

if (numberB > numberA)
{
    Console.WriteLine($"max ={numberB}, min = {numberA}");
}
