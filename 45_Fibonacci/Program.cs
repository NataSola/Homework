// 45. Показать числа Фибоначчи

Console.Clear();
System.Console.WriteLine();

int N = new Random().Next(1, 50);
System.Console.WriteLine($"Количество чисел Фибоначчи: {N}");

int[] GetFibonacci(int N)
{
    int prev1 = 1;
    int prev2 = 1;
    int[] fib = new int[N];
    for (int i = 0; i < N; i++)
    {
        fib[i] = prev1 + prev2;
        prev2 = prev1;
        prev1 = fib[i];
    }
    return fib;
}

void PrintArray(int[] arr)
{
    System.Console.Write("1 1 ");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
    System.Console.WriteLine();
}

PrintArray(GetFibonacci(N));
System.Console.WriteLine();