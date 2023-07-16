// Задача 32: Напишите программу замена элементов массива: положительные элементы замените 
// на соответствующие отрицательные, и наоборот.
// // [-4, -8, 8, 2] -> [4, 8, -8, -2] 


int[] MakeNewRandomArray(int size, int beginValue, int endValue) // новый массив
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(beginValue, endValue);
    }
    return array;
}

int[] array = MakeNewRandomArray(12, -9, 10);

System.Console.Write("[" + string.Join(", ", array) + "]" + " -> ");

for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }

Console.Write("[" + string.Join(", ", array) + "]");

