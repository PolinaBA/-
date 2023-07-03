// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
const int m = 5;
const int n = 5;

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
 int [,] MyMatrix = GetMatrix(m,n);

PrintMatrix(MyMatrix);

Console.WriteLine("Введите номер строки");
int I = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите номер столбца");
int J = Convert.ToInt32(Console.ReadLine());

if ( I > MyMatrix.GetLength(0) && J > MyMatrix.GetLength(1))
{
    Console.WriteLine("Такого элемента не существует");
}

else
{
    Console.WriteLine(MyMatrix[I-1,J-1]);
}




