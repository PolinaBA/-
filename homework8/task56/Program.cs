// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
const int m = 6;
const int n = 2;
int z = 0;

int [,] GetMatrix(int rows, int columns)
{
    int [,] matrix = new int [rows, columns];
    for (int i = 0; i < matrix.GetLength(0);  i ++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = Random.Shared.Next(1,10);
        }
    }
    return matrix;
}

void PrintMatrix( int [,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j ++ )
        {
             Console.Write($"{matrix[i,j]}\t");
        }
    Console.WriteLine();
    }    
}


void SumOfRow (int [,] matrix)
{
    int sum1 = 0;
    int sumRow = 0;
    
    for (int j = 0; j < matrix.GetLength(1);  j ++)
    {
        
       sum1 = sum1 + matrix[0,j];

    }
    for (int i = 1; i < matrix.GetLength(0);  i ++)
    {
        sumRow = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRow = sumRow + matrix[i,j];

        }
        if (sumRow < sum1)
        {
            sum1 = sumRow;
            z = i+1;
        }

    }
}


int [,] MyMatrix = GetMatrix(m,n);
PrintMatrix(MyMatrix);
Console.WriteLine();
SumOfRow(MyMatrix);


Console.WriteLine($"Номер строки с минимальной суммой элементов = {z} ");
