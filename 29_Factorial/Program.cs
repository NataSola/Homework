// 29. Написать программу вычисления произведения чисел от 1 до N

Console.Clear();
System.Console.WriteLine();

System.Console.Write("Введите число:   ");
string writeN = Console.ReadLine();
int N = Convert.ToInt32(writeN);

int GetFactorial(int N)
{
    int F = 1;
    for (int num = 1; num <= N; num++)
    {
        F = F * num;
    }
    return F;
}

System.Console.WriteLine($"Произведение чисел от 1 до {N} равно {GetFactorial(N)}");
System.Console.WriteLine();