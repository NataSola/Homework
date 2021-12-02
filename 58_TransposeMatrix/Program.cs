// 58. Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно

Console.Clear();
int[,] GetMatrix(int row, int col, int min, int max)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}


int[,] TransposeMatrix(int[,] array)
{
    int[,] transMatrix = new int[array.GetLength(1), array.GetLength(0)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int k = i;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            int m = j;
            transMatrix[k, m] = array[j, i];
        }
    }
    return transMatrix;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int row = 5;
int col = 7;
int min = 10;
int max = 100;

int[,] matrix = GetMatrix(row, col, min, max);
PrintMatrix(matrix);
System.Console.WriteLine("---");
int[,] transMatrix = TransposeMatrix(matrix);
PrintMatrix(transMatrix);