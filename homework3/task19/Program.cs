//  Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, является ли 
// оно палиндромом.

Console.WriteLine("Введите пятизначное число");
int N = Convert.ToInt32(Console.ReadLine());

int Digit5 = N % 10;
int Digit1 = N / 10000;
int Digit2 = (N / 1000) % 10;
int Digit4 = (N / 10) % 10;

if (N > 9999 && N < 100000)
{

    if (Digit5 == Digit1 && Digit2 == Digit4)
    {
        Console.WriteLine("Число является палиндромом");
    }

    else 
    {
        Console.WriteLine("Число не является палиндромом");
    }
}

else 
{
    Console.WriteLine("Вы ввели не пятизначное число");
}