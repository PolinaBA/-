// Напишите программу, которая на вход принимает число N, а на выходе показывает все четные числа от 1 до N.

Console.WriteLine("Введите число");
string N = Console.ReadLine()!;
int numberN = Convert.ToInt32(N);

for (int i = 2; i<= numberN; i++)
    if (i % 2 == 0)
    { 
        Console.WriteLine(i);
    }
