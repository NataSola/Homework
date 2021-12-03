// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.Clear();
System.Console.WriteLine();

int Number1 = 50;
int Number2 = 8;
int result = 0;

int MultipleNumber()
{
    result = Number1 % Number2;
    return result;
}

MultipleNumber();

System.Console.WriteLine();
if (result == 0) System.Console.WriteLine($"Число {Number1} кратно числу {Number2}");
else
{
    Console.WriteLine($"Число {Number1} не кратно числу {Number2}, остаток от деления равен {Number1 % Number2}");
}
System.Console.WriteLine();