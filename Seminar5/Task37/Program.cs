// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21





int[] NewRandomArray(int size, int beginValue, int endValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(beginValue, endValue);
    return array;
}

int[] DefCount(int[] array)
{   
    int size = array.Length/2;
    if (array.Length % 2 ==1 ) size ++;
    int[] arrayNew = new int[size];
    for (int i = 0; i < array.Length/2; i++)
    {
        arrayNew[i] = array[i] * array[array.Length - i - 1];
    }
    if (array.Length % 2 == 1) arrayNew[size - 1] = array[array.Length / 2];
    return arrayNew;
}

int[] array = NewRandomArray(4, -9, 9); 
int[] arrayNew = DefCount(array);
Console.WriteLine("[" + string.Join(", ", array) + "]" + " -> " +  string.Join(", ", arrayNew));