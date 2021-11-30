// Найти произведение побочной диагонали

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

void PrintArray(int[,] array)
{
    System.Console.WriteLine();
    System.Console.WriteLine("Матрица:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] >= 10) System.Console.Write($"{array[i, j]}  ");
            else System.Console.Write($" {array[i, j]}  ");
        }
        System.Console.WriteLine();
    }
}

int GetProductSideDiagonal(int[,] array)
{
    int product = 1;
    for (int i = array.GetLength(0) - 1; i >= 0; i--)
    {
        product = product * array[i, array.GetLength(0) - i - 1];
    }
    return product;
}

void PrintSideDiagonal(int[,] array)
{
    System.Console.Write("Элементы побочной диагонали:  ");
    for (int i = array.GetLength(0) - 1; i >= 0; i--)
    {
        System.Console.Write(array[i, array.GetLength(0) - i - 1] + "  ");
    }
    System.Console.WriteLine();
}


int row = 5;
int col = 7;
int min = 1;
int max = 10;

int[,] matrix = GetMatrix(row, col, min, max);
int product = GetProductSideDiagonal(matrix);
PrintArray(matrix);
System.Console.WriteLine();
PrintSideDiagonal(matrix);
System.Console.WriteLine($"Произведение элементов побочной диагонали: {product}");
System.Console.WriteLine();