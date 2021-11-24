// 54. В матрице чисел найти сумму элементов главной диагонали

Console.Clear();
System.Console.WriteLine();

int[,] GetMatrix(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }
    return matrix;
}

int FindSumMainDiagonal(int[,] matr)
{
    int sum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == j) sum = sum + matr[i, j];
        }
    }
    return sum;
}

void PrintMatrix(int[,] matr)
{
    System.Console.WriteLine();
    System.Console.WriteLine("Матрица:");
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] > 100) System.Console.Write($"{matr[i, j]}   ");
            else if (matr[i, j] > 10) System.Console.Write($" {matr[i, j]}   ");
            else if (matr[i, j] > 0) System.Console.Write($"  {matr[i, j]}   ");
        }
        System.Console.WriteLine();
    }
}

void PrintMainDiagonal(int[,] matrix)
{
    System.Console.WriteLine();
    System.Console.WriteLine("Главная диагональ:");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j) System.Console.Write(matrix[i, j]);
            else System.Console.Write("      ");
        }
        System.Console.WriteLine();
    }
}

int row = 7;
int col = 10;
int min = 1;
int max = 1000;

int[,] matrix = GetMatrix(row, col, min, max);
PrintMatrix(matrix);
PrintMainDiagonal(matrix);
int sumDiagonal = FindSumMainDiagonal(matrix);
System.Console.WriteLine();
System.Console.WriteLine($"Сумма элементов главной диагонали матрицы составляет: {sumDiagonal}");
System.Console.WriteLine();