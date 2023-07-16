// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


bool SearchNumber(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] == number || array[i] == -number )
            return true;
    return false;
}

int[] MakeNewRandomArray(int size, int beginValue, int endValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(beginValue, endValue);
    }
    return array;
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


int number = GetInfo("Введите разыскиваемое число: ");
int[] array = MakeNewRandomArray(5, -9, 9);

Console.Write($"{number}; массив [{string.Join(",", array)}] -> ");
if (SearchNumber(array, number))
    Console.Write("Да.");
else
    Console.Write("Нет.");
