// 48. Показать двумерный массив размером m×n заполненный целыми числами

Console.Clear();
System.Console.WriteLine();

int[,] GetTable(int row, int col, int min, int max)
{
    int[,] table = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            table[i, j] = new Random().Next(min, max + 1);
        }
    }
    return table;
}

void PrintTable(int[,] tab)
{
    for (int i = 0; i < tab.GetLength(0); i++)
    {
        for (int j = 0; j < tab.GetLength(1); j++)
        {
            System.Console.Write(tab[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int row = new Random().Next(5, 10);
int col = new Random().Next(5, 10);
int min = 1;
int max = 100;

int[,] matrix = GetTable(row, col, min, max);
PrintTable(matrix);