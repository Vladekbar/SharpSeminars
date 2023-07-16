// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();
int GDC(int number)
{
    if (number == 0)
        return 1;

    int count = 0;
    while (number != 0)
    {
        number /= 10;
        count++;
    }
    return count;
}

int Getinfo (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = Getinfo ("Введите число А:");
Console.WriteLine("Количество цифр в числе " + number + " cоставялет " +  (GDC(number)));



// Альтернатива
//string GetInfo(string text)
//{
//    Console.Write(text);
//    return Console.ReadLine();
//}

//string num = GetInfo("Введите число: ");
//int lenght = num.Length;
//Console.WriteLine(lenght);