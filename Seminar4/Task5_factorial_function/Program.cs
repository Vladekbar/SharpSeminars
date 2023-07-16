// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24 
//5 -> 120

Console.Clear();
int FindFaktorial(int num)
{
    int faktorial = 1;
    while (num > 0)
    {
        faktorial = faktorial * num;
        num--;
    }
    return faktorial;
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int num = GetInfo("Введите число N: ");
int faktorial = FindFaktorial(num); 
Console.WriteLine(faktorial);