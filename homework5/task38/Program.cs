// Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива. (не использовать стандартные функции/методы)
int [] GetArray ()
{
    int[] Array = new int[10];
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = Random.Shared.Next(0, 100);
    }
    return Array;
}

int [] Array = GetArray();
Console.WriteLine(String.Join(", ",Array));

int  max = Array[0];
int Maximum()
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


int min = Array[0]; 
int Minimum()
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

int A = Maximum();
int B = Minimum();
int dif = A -B;

Console.WriteLine($"Разница между минимальным и максимальным элементом = {dif}");

