// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int [] array = new int [10];
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = Random.Shared.Next(100, 1000);
    if (array[i] % 2 == 0)
    {
        count++;
    }
}

Console.WriteLine(String.Join(", ",array));
Console.WriteLine($"Количество четных чисел в массиве = {count}");


