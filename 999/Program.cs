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

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
}

int[] d = createArray(c);
PrintArray(d);