int[] MakeNewRandomArray(int size, int beginValue, int endValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(beginValue, endValue);
    }
    return array;
}

int[] ReversArray (int []arr)
{
int[] arrayNew = new int[arr.Length];
for (int i = 0; i < arr.Length; i++)
{
    arrayNew[i] = arr[i] * -1;
}
return arrayNew;
}
int[] array = MakeNewRandomArray(12, -9, 9);
int[] arrayNew = ReversArray(array);

Console.WriteLine($"[{string.Join(",", array)}]");
Console.WriteLine($"[{string.Join(",", arrayNew)}]");