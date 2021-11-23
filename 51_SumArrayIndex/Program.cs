// 51. Задать двумерный массив следующим правилом: Aₘₙ = m+n

int[,] GetMatrix(int row, int col)
{
    int[,] matr = new int[row, col];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = i + j + 2;
        }
    }
    return matr;
}

void PrintTable(int[,] tab)
{
    for (int i = 0; i < tab.GetLength(0); i++)
    {
        for (int j = 0; j < tab.GetLength(1); j++)
        {
            System.Console.Write(tab[i, j] + "   ");
        }
        System.Console.WriteLine();
    }
}

int row = new Random().Next(5, 11);
int col = new Random().Next(10, 16);

int[,] table = GetMatrix(row, col);
PrintTable(table);