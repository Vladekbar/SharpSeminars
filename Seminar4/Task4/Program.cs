// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24 
//5 -> 120

Console.Clear();
int GetProduct(int limit)
{
    if (limit < 0)
    {
        limit = -limit;
    }

    int product = 1;
    for (int i = 1; i <= limit; i++)
    {
        product *= i;
    }
    return product;
}

int GetInfo(string text)
{
    Console.Write(text);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int num = GetInfo("Введите число N: ");
Console.WriteLine($"Произведение чисел от 1 до {num} равна {GetProduct(num)}");


