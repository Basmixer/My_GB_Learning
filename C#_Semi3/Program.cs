/*
//Задача:  по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти (Х и У)

// Выполнаем с помощью метода void (но можно и строкой)

void GetDiapazone(int quadrant)
{
    if(quadrant == 1) Console.WriteLine("x > 0 and y > 0");
    else if(quadrant == 2) Console.WriteLine("x < 0 and y > 0");
    else if(quadrant == 3) Console.WriteLine("x < 0 and y < 0");
    else if(quadrant == 4) Console.WriteLine("x > 0 and y < 0");
    else Console.WriteLine("Wrong input!");
}

Console.Write("Input a number of quadrant: ");
int quadNum = Convert.ToInt32(Console.ReadLine());

GetDiapazone(quadNum);
*/

// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка. (return)
/*
int QuadNum(double x, double y)  // метод, выдающий номер квадранта по заданным координатам точки
{
        if(x > 0 && y > 0) return 1;
        else if (x < 0 && y > 0) return  2;
        else if (x < 0 && y < 0) return  3;
        else if (x > 0 && y < 0) return  4;
        return 0;
}

Console.WriteLine("Input two point coordinates: ");
Console.Write("X = ");
    double x = Convert.ToDouble(Console.ReadLine());

Console.Write("Y = ");
    double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(QuadNum(x,y));

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N. (void)

void NSqTable(int n)
{
    for (int count=1, consoleN=1; count <= n; count++) 
    {
        consoleN=count*count;
        Console.Write($"{consoleN} |");
    }
}

Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());

NSqTable(n);
*/
// Принимает на вход координаты двух точек и находит расстояние между ними в 2D


double Dist (double ax, double ay, double bx, double by)
{
    double xCor = (bx - ax);
    double yCor = (by - ay);
    double dist = Math.Sqrt(xCor*xCor + yCor*yCor);
    return dist;
}

Console.Write("Input x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.Write(Dist(x1,y1,x2,y2));
