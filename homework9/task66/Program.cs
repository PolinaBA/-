// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int N  = 1;
int M = 15;

int Sum ( int numberFirst, int numberLast)
{
    if (numberLast == numberFirst) return numberFirst;
    {
        return numberLast +  Sum (numberFirst, numberLast - 1);
    }
   
}
Console.Write(Sum(N,M));
