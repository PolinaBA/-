// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
const int m = 3;
const int n = 4;

int [,] GetMatrix (int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j ++ )
        { 
            matrix[i,j] = Random.Shared.Next(1,100);

        }
    }
    return matrix;
}

void PrintMatrix(int[,]matrix)
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


double [] AverageColumns (int [,] matrix, int Columns)
{
    double [] array = new double [Columns];
 

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        array[j]  = 0;
        
        for (int i = 0; i < matrix.GetLength(0); i ++ )
        {
            array[j]  +=  matrix[i,j];
        }
    
        array[j]  =  array[j] / matrix.GetLength(0);
    }
   
    return array;
}

 int [,] MyMatrix = GetMatrix(m,n);
 PrintMatrix(MyMatrix);
 double [] Average = AverageColumns(MyMatrix,n);
Console.WriteLine(String.Join(", ", Average));



 
