// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.
int [] array = new int [10];
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = Random.Shared.Next(-10,10);
    if (i % 2 !=  0)
    {
        sum += array[i];
    }
}

Console.WriteLine(String.Join(", ",array));
Console.WriteLine($"Сумма элементов, стоящих на нечётных индексах = {sum}");

