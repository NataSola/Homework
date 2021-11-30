// Являается ли число палинромом

Console.Clear();
System.Console.WriteLine();

System.Console.WriteLine("Введите текст или число:");
string writeTxt = Console.ReadLine();
string txtToCheck = writeTxt.ToLower().Replace(" ",""); // для проверки переводим знаки в нижний регистр и убираем пробелы
int length = txtToCheck.Length;
string result = "не является";

bool IsPalindrome(string p)
{
    int count = 0;
    while (count <= length)
    {
        if (txtToCheck[count] != txtToCheck[length - 1]) return false;
        length--;
        count++;
    }
    return true;
}

if (IsPalindrome(txtToCheck)) result = "является";
Console.WriteLine($"Введенное значение {result} палиндромом");
System.Console.WriteLine();