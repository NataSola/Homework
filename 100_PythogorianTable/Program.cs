// Таблица Пифагора

Console.Clear();
System.Console.WriteLine();

int[,] GetTable(int row, int col)
{
    int[,] table = new int[row, col];
    for (int i = 1; i < table.GetLength(0); i++)
    {
        for (int j = 1; j < table.GetLength(1); j++)
        {
            table[i, j] = i * j;
        }
    }
    return table;
}

void PrintTable(int[,] tab)
{
    for (int i = 1; i < tab.GetLength(0); i++)
    {
        for (int j = 1; j < tab.GetLength(1); j++)
        {
            if (tab[i, j] > 9) System.Console.Write($"{tab[i, j]}   ");
            else System.Console.Write($" {tab[i, j]}   ");
        }
        System.Console.WriteLine();
    }
}

int row = 10;
int col = 10;
PrintTable(GetTable(row, col));

System.Console.WriteLine();
