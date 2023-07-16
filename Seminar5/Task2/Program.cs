// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

Console.Clear();

int GetPosOrNegativeSum(int[] array, bool posOrNegative) // Суммирует пои отр знач.
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (posOrNegative)
        {
            if (array[i] > 0)
            {
                result += array[i];
            }            
        }            
        else
        {
            if (array[i] < 0)
            {
                result += array[i];
            }                   
        }
    }
    return result;
}

int[] MakeNewRandomArray(int size, int beginValue, int endValue) // Печатает рандомный массив
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(beginValue, endValue);
    return array;
}

int[] array = MakeNewRandomArray(12, -9, 9);

Console.WriteLine("[" + string.Join(",", array) + "]");
Console.WriteLine($"сумма положительных чисел равна {GetPosOrNegativeSum(array, true)}");
Console.WriteLine($"сумма отрицательных чисел равна {GetPosOrNegativeSum(array, false)}");