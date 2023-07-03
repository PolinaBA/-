// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
const int m = 3;
const int n = 4;

double [,] GetMatrix (int rows, int columns)
{
    double [,] matrix = new double [rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j ++ )
        { 
            matrix[i,j] = Random.Shared.NextDouble();

        }
    }
    return matrix;
}

void PrintMatrix( double [,]matrix)
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
 double [,] MyMatrix = GetMatrix(m,n);

PrintMatrix(MyMatrix);


