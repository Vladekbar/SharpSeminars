//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21

// Функция принимает четыре параметра: x1 и y1 - координаты первой точки, и x2 и y2 - координаты второй точки. 
// Для вычисления расстояния между точками используется формула, основанная на теореме Пифагора.

//deltaX = x2 - x1 и deltaY = y2 - y1. 
// Затем с помощью этих разностей вычисляется квадрат расстояния между точками: distanceSquared = deltaX * deltaX + deltaY * deltaY. 
// Наконец, находится квадратный корень из полученного значения distanceSquared, что и является итоговым расстоянием между двумя точками.

//distanceSquared = deltaX * deltaX + deltaY * deltaY.
//Distanse2D = Sqrt(distanceSquared)

double Distanse2D(int xPoint1, int yPoint1, int xPoint2, int yPoint2)
{
    int deltaX = (xPoint1 - xPoint2);
    int deltaY = (yPoint1 - yPoint2);
    int distanceSquared = (deltaX * deltaX + deltaY * deltaY);
    double result = Math.Sqrt(distanceSquared);
    return result;
}

int GetInfo(string message)
{
    Console.Write(message);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int xPoint1 = GetInfo("Введите координату X1: "); 
int yPoint1 = GetInfo("Введите координату Y1: "); 
int xPoint2 = GetInfo("Введите координату X2: "); 
int yPoint2 = GetInfo("Введите координату Y2: "); 

Console.WriteLine(Distanse2D(xPoint1, yPoint1, xPoint2, yPoint2));
