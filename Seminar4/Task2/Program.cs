



int GetSum (int limit)
{
    int sum = 0;
    for (int i = 1; i <= limit; i++)
    {
        sum += i;
    }
    return sum;
}

int Getinfo (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int num = Getinfo ("Введите число А:");

Console.WriteLine("Сумма чисел от 1 до "  + num + " равна " + (GetSum(num)));