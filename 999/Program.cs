// Объединить массивы

int[] a = new int[] { 1, 2, 3 };
int[] b = new int[] { 4, 5, 6 };
int[] c = a.Concat(b).ToArray();
System.Console.WriteLine(String.Join(' ', c));

int[] createArray(int[] c)
{
    int[] cd = new int[6];
    for (int i = 0; i < cd.Length; i++)
    {
        cd[i] = c[i] * 2;
    }
    return cd;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
}

// int[] d = createArray(c);
// PrintArray(d);

//Масштабирование

double k = 1.1;                                                          // коэффициент масштабирования
double[] pointA = { 0, 0 };                                            // координаты точек
double[] pointB = { 1, 2 };
double[] pointC = { 4, 2 };
double[] pointD = { 4, 0 };
char[] pointName = { 'A', 'B', 'C', 'D' };

double[] c1 = pointA.Concat(pointB).ToArray();
double[] c2 = c1.Concat(pointC).ToArray();
double[] c3 = c2.Concat(pointD).ToArray();

double[] GerScalingCords(double[] arr, double k)
{
    double[] newCords = new double[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < 2) newCords[i] = arr[i];
        else if (i > 1 && i % 2 == 0) newCords[i] = arr[i] * k - arr[0] * (k-1);
        else if (i > 1 && i % 2 != 0) newCords[i] = arr[i] * k - arr[1] * (k-1);
    }
    return newCords;
}




System.Console.WriteLine();
System.Console.WriteLine("---");
System.Console.WriteLine(String.Join(' ', c3));

System.Console.WriteLine("---");
double[] newCords = GerScalingCords(c3, k);
PrintArray(newCords);



// "copied tasks from the damaged folder and fixed codes after checking by the teacher"

