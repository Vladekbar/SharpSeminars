// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

void DefSqr (int num)
{
    Console.Write($"{num} - > ");
    for (int i = 1; i < num; i++)
    {
      Console.Write((int)Math.Pow(i, 2) + ", ");  
    }
    Console.WriteLine((int)Math.Pow(num, 2) + ".");
}


int Getinfo (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int num = Getinfo("Введите число: ");
DefSqr(num);