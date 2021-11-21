// 41. Выяснить являются ли три числа сторонами треугольника

Console.Clear();
System.Console.WriteLine();

int A = 15;
int B = 25;
int C = 12;

bool triangle = (A + B > C && A + C > B && B + C > A);

if (triangle) System.Console.WriteLine("Из заданных отрезков можно составить треугольник");
else System.Console.WriteLine("Из заданных отрезков составить треугольник невозможно");