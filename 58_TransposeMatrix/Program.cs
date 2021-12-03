// 58. Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно

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

void TransposeMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            int tmp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = tmp;
        }
    }
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}  ");
        }
        System.Console.WriteLine("");
    }
}

int row = 4;
int col = 4;
int min = 10;
int max = 100;

int[,] matrix = GetMatrix(row, col, min, max);
PrintMatrix(matrix);
System.Console.WriteLine("---");
if (matrix.GetLength(0) == matrix.GetLength(1))
{
    TransposeMatrix(matrix);
    PrintMatrix(matrix);
}
else System.Console.WriteLine("Данную матрицу транспонировать невозможно!" + "\n");
