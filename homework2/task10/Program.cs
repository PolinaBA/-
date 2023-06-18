// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите число");
string A = Console.ReadLine()!;
int numberA = Convert.ToInt32(A);

int midDigit = numberA / 10 % 10;

Console.WriteLine(midDigit);