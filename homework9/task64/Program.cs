// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии

int N = 10;
int count = 1;

void Perechislenie (int Number, int Count)
{
    if (Number < Count ) return;
    Perechislenie(Number, Count  +  1 );
    Console.Write(Count + " ");
}
Perechislenie(N,count);


