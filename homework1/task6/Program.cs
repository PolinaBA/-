// Напишите программу, которая на вход принимает число и выдает, является ли число четным.

Console.WriteLine("Введите число");
string A = Console.ReadLine()!;
int numberA = Convert.ToInt32(A);

if (numberA % 2 == 0)
{ 
    Console.WriteLine("Четное");
}

else
{
    Console.WriteLine("Нечетное");
}