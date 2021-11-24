// 50. В двумерном массиве n×k заменить четные элементы на противоположные

int[,] GetTable(int row, int col, int min, int max)
{
    int[,] firstTab = new int[row, col];
    for (int i = 0; i < firstTab.GetLength(0); i++)
    {
        for (int j = 0; j < firstTab.GetLength(1); j++)
        {
            firstTab[i, j] = new Random().Next(min, max + 1);
        }
    }
    return firstTab;
}

int[,] ReplaceEvenToSquare(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] % 2 == 0) array[i, j] = array[i, j] * (-1);
        }
    }
    return array;
}

void PrintTable(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + "  ");
        }
        System.Console.WriteLine();
    }
}

int row = 5;
int col = 10;
int min = 1;
int max = 10;

int[,] firstArray = GetTable(row, col, min, max);
PrintTable(firstArray);
System.Console.WriteLine("-------------");
int[,] replaceArray = ReplaceEvenToSquare(firstArray);
PrintTable(replaceArray);