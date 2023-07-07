// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.



const int m = 5;
const int n = 5;

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



void MatrixMaxToMin (int [,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j ++)
        {
        
  
            for (int z = 0; z < matrix.GetLength(0) - 1 ; z++) 
             
            
                {
                     if (matrix[i,z+1] > matrix[i,z] )
                    {
                        int temp = matrix[i,z];
                        matrix[i,z] = matrix[i,z+1];
                        matrix[i,z+1] = temp;
                    }
                
                
                }
        }
 
    }
}       
    
int [,] MyMatrix = GetMatrix(m,n);
PrintMatrix(MyMatrix);
Console.WriteLine();
MatrixMaxToMin(MyMatrix);
PrintMatrix(MyMatrix);