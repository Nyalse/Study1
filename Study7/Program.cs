int[] array1 = { 5, 2, 9, 1, 5, 6 };
int[] array2 = { 3, 4, 8, 7 };
SortABC(array1);
SortCBA(array2);
Console.WriteLine("Массив 1 в порядке возрастания: " + string.Join(", ", array1));
Console.WriteLine("Массив 2 в порядке убывания: " + string.Join(", ", array2));
int[] PlusArray = PlusArrays(array1, array2);
Console.WriteLine("Объединенный массив: " + string.Join(", ", PlusArray));
int n = 150;
int S = ABSDIF(n);
Console.WriteLine($"Абсолютная разность между {n} и 123: {S}");
void SortABC(int[] array)
{
    Array.Sort(array);
}
 void SortCBA(int[] array)
{
    Array.Sort(array);
    Array.Reverse(array);
}
 int[] PlusArrays(int[] array1, int[] array2)
{
    int[] PlusArray = new int[array1.Length + array2.Length];
    Array.Copy(array1, PlusArray, array1.Length);
    Array.Copy(array2, 0,PlusArray, array1.Length, array2.Length);
    return PlusArray;
}
 int ABSDIF(int n)
{
    int S = Math.Abs(n - 123);
    if (n > 123)
    {
        return 3 * S;
    }
    return S;
}