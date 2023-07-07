// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
const int m = 3;
const int n = 2;

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



int [,] MultMatrix (int [,] matrix, int [,] matrix2)
{
    int [,] matrixNew = new int [matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i ++ )
    {
        for (int j = 0; j < matrix.GetLength(1); j ++)
        {
            matrixNew[i,j] = matrix[i,j] * matrix2[i,j];
        }
    }
    return matrixNew;
}

int [,] MyMatrix = GetMatrix(m,n);
PrintMatrix(MyMatrix);
Console.WriteLine();

int [,] MyMatrix2 = GetMatrix(m,n);
PrintMatrix(MyMatrix2);
Console.WriteLine();
int [,] MyMatrix3 = MultMatrix(MyMatrix,MyMatrix2);
PrintMatrix(MyMatrix3);




