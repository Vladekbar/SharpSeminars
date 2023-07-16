//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

void Quarter(int numQuarter)
{
    if (numQuarter == 1) Console.Write("Диапазон X: (> 0), Диапазон Y: (> 0)");
    if (numQuarter == 2) Console.Write("Диапазон X: (< 0), Диапазон Y: (> 0)");
    if (numQuarter == 3) Console.Write("Диапазон X: (< 0), Диапазон Y: (< 0)");
    if (numQuarter == 4) Console.Write("Диапазон X: (> 0), Диапазон Y: (< 0)");
    else
    {
        Console.Write("Такой четверти не существует.");
    }   
}

int GetInfo(string message)
{
    Console.Write(message);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int numQuarter = GetInfo("Введите четверть: "); 
Quarter(numQuarter);