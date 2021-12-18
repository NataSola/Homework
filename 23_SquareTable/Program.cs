// 23. Показать таблицу квадратов чисел от 1 до N

Console.Clear();
System.Console.WriteLine();

System.Console.Write($"Введите число:   ");
string writeN = Console.ReadLine();
int N = Convert.ToInt32(writeN);

int[] GetSqrtTable(int N)
{
    int[] SqrtArray = new int[N + 1];
    for (int i = 1; i < SqrtArray.Length; i++)
    {
        SqrtArray[i] = i * i;
    }
    return SqrtArray;
}

void PrintTable(int[] Array)
{
    for (int i = 1; i < Array.Length; i++)
    {
        System.Console.Write($"{i} ^ 2 = ");
        System.Console.WriteLine(Array[i]);
    }
}

int[] SqrtTable = GetSqrtTable(N);
PrintTable(SqrtTable);