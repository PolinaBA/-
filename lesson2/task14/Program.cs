// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.WriteLine("Введите первое число");
string A = Console.ReadLine()!;
int numberA = Convert.ToInt32(A);

if (numberA % 7 == 0 &&  numberA % 23 == 0)
{
    Console.WriteLine("Кратно");
}

else 
{
    Console.WriteLine("Некратно");
}