// 4. Найти максимальное из трех чисел 

int[] numbers = { 145, 78, 68 };

int GetMaxNumber(int[] array)
{
    int max = 0;
    for (int i = 0; i < 3; i++)
    {
        if (numbers[i] > max) max = numbers[i];
    }
    return max;
}

System.Console.WriteLine();
int maxNumber = GetMaxNumber(numbers);
System.Console.WriteLine($"Максимальное число: {maxNumber}");
System.Console.WriteLine();