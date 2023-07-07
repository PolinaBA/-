// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

const int row = 2;
int count = 9;

int [,,] GetMatrix (int X, int Y, int Z)


{
    int [,,] matrix3 = new int [row,row,row];
    while (count < 17) 
    {
        for (int i = 0; i < matrix3.GetLength(0); i ++)
        {
            for (int j =0; j < matrix3.GetLength(1); j ++)
            {
                for (int k = 0; k < matrix3.GetLength(2); k ++)
                {
                    matrix3[i,j,k] = count + 1;
                    count ++;
                }
                
            }
        }
    }
    return matrix3;

}

void PrintMatrix( int [,,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j ++ )
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                 Console.Write($"{matrix[i,j,k]}, ({i},{k},{j})\t");
            }
             
        }
    Console.WriteLine();
    }    
}



int [,,] MyMatrix = GetMatrix(row,row,row);
PrintMatrix(MyMatrix);
Console.WriteLine();