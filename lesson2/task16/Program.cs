// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
Console.WriteLine("Введите первое число");
string A = Console.ReadLine()!;
int numberA = Convert.ToInt32(A);

Console.WriteLine("Введите второе число");
string B = Console.ReadLine()!;
int numberB = Convert.ToInt32(B);

if ( numberB == numberA * numberA || numberA == numberB * numberB)
{
    Console.WriteLine("Одно число является квадратом первого");
}

else 
{
    Console.WriteLine("Одно число не является квадратом первого");
}