// 26. Возведите число А в натуральную степень B используя цикл
Console.Clear();
System.Console.WriteLine();

int number = 2;
int exponent = 10;

int GetExponentiation(int number, int exponent)
{
    int count = 1;
    int result = number;
    while (count < exponent)
    {
        result = result * number;
        count++;
    }
    return result;
}

int result = GetExponentiation(number, exponent);
System.Console.WriteLine($"{number} ^ {exponent} = {result}");
System.Console.WriteLine();