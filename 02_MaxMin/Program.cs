// 2. Даны два числа. Показать большее и меньшее число 

System.Console.WriteLine();

string[] txtNumber = { "первое", "второе" };
int[] number = new int[2];

for (int i = 0; i < 2; i++)
{
    System.Console.WriteLine($"Введите {txtNumber[i]} число:");
    string writeNumber = Console.ReadLine();
    number[i] = Convert.ToInt32(writeNumber);
}
int max = number.Max();
int min = number.Min();

if (max == min) System.Console.WriteLine("Введённые числа равны");
else 
{
    System.Console.WriteLine($"Большее число {max}, меньшее число {min}");
}
System.Console.WriteLine();

// ИЛЬНАР: эта задача решена немного "нечестно") вы пользуетесь функциями max() и min(), 
// хотя суть задачи в том, чтобы самостоятельно сравнить числа. 
// Но, учитывая весь прочий код этой задачи, у вас не составит труда 
// решить задачу и через обычное сравнение

// решение без функций:

if (number[0] == number[1]) System.Console.WriteLine("Введенные числа равны");
else if (number[0] > number[1]) System.Console.WriteLine($"Большее число {number[0]}, меньшее число {number[1]}");
else System.Console.WriteLine($"Большее число {number[1]}, меньшее число {number[0]}");