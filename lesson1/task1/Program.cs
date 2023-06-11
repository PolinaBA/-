//  Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3, b = 9 -> нет

Console.WriteLine("Введите первое число");
string a = Console.ReadLine()!;

Console.WriteLine("Введите второе число");
string b = Console.ReadLine()!;

int numberA = Convert.ToInt32(a);
int numberB = Convert.ToInt32(b);

if (numberA == numberB * numberB)
{
    Console.WriteLine("Yes");
}
else 
{
    Console.WriteLine("No");
}
