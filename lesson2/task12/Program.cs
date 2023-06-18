// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

Console.WriteLine("Введите первое число");
string A = Console.ReadLine()!;
int numberA = Convert.ToInt32(A);

Console.WriteLine("Введите второе число");
string B = Console.ReadLine()!;
int numberB = Convert.ToInt32(B);

if (numberA % numberB == 0 )
{
Console.WriteLine("Кратно");
}

else 
{
    Console.WriteLine( numberA % numberB);

}
