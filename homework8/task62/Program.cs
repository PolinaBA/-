// Напишите программу, которая заполнит спирально массив 4 на 4.

int row = 4;
int num  = 1;




int [,] GetMatrixSpiral (int rows, int columns)
{
    int[,] matrix = new int [row, row];

    for (int delta = 0; delta < row - 2; delta ++)
    {

        for (int j = delta; j < matrix.GetLength(1) - delta; j++)
        {
            matrix[delta,j] = num;
            num++;
        }
        num--;

        for (int i = delta; i < matrix.GetLength(0) - delta; i++)
        {
            matrix[i,row - 1  - delta] = num;
            num ++;
        }
       num--;

        for (int j = matrix.GetLength(1) - 1 - delta; j >= delta; j--)
        {
            matrix[row - 1  - delta,j] = num;
            num++;
        }
        num--;

        for (int i = matrix.GetLength(0) - 1 - delta; i >= 1 + delta; i --)
        {
            matrix[i,delta] = num;
            num++;
        } 
        num--;
      num++;
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

int [,] MyMatrix = GetMatrixSpiral(row,row);
PrintMatrix(MyMatrix);
