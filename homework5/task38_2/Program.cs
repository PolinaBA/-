//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


double [] Array = {2.5,3.12,4.48,5.56,77.5,67.4,87.3};


double  max = Array[0];
double Maximum()
{
    
    for (int i = 1; i < Array.Length; i++)
    {
     if (Array[i] > max)
     {
        max = Array[i];
     }
    }
    return max;
}


double min = Array[0]; 
double Minimum()
{
    for (int i = 1; i < Array.Length; i++)
    {
     if (Array[i] < min)
     {
        min = Array[i];
     }
    }
    return min;
}

double A = Maximum();
double B = Minimum();
double dif = A -B;

Console.WriteLine($"Разница между минимальным и максимальным элементом = {dif}");