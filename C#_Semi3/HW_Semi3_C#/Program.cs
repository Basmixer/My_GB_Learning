/*
// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// при этом проигнорировать ограничение по 5-тизначности. Принимать и проверять в рамках int.

void checkPalindrome(int checkNum) // метод, проверяющий число int на палиндром
{
    int revNumber = 0;
    while (checkNum > revNumber)
    {
        revNumber = checkNum % 10 + revNumber * 10;
        checkNum = checkNum / 10;
    }
    // Console.WriteLine($"{revNumber} - revNumber");
    // Console.WriteLine($"{checkNum} - checkNum");

      if(checkNum == revNumber/10) Console.WriteLine($"Yes! it' PALINDROME");
          else Console.WriteLine($"No! it's not a PALINDROME");
}

Console.Write("Input a Int number and I'll check if it's palindrome: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0 || (number %10 ==0 && number != 0)) Console.WriteLine("Bad input"); // число не должно начинаться со знака "-" не заканчиваться/начинаться "0"

checkPalindrome(number); // вызов метода проверки
*/

// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

/*
double DistanceIn3D(double x1, double y1, double z1, double x2, double y2, double z2) // Метод вычисления расстояния между 2-мя точками в 3D по заданным координатам
{
    double dist = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
    return dist;
}

Console.WriteLine("Input coordinates for 3 point in x,y,z");
Console.Write("x1: ");
double corX1 = Convert.ToDouble(Console.ReadLine());
Console.Write("y1: ");
double corY1 = Convert.ToDouble(Console.ReadLine());
Console.Write("z1: ");
double corZ1 = Convert.ToDouble(Console.ReadLine());

Console.Write("x2: ");
Double corX2 = Convert.ToDouble(Console.ReadLine());
Console.Write("y2: ");
Double corY2 = Convert.ToDouble(Console.ReadLine());
Console.Write("z2: ");
Double corZ2 = Convert.ToDouble(Console.ReadLine());

double distIn3D = DistanceIn3D(corX1, corY1, corZ1, corX2, corY2, corZ2);
Console.WriteLine($"Distance in 3D betwin two input points in 3D = {distIn3D}");

*/
/*
//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int TablePow3 (int N) // Метод выведения таблицы кубов числа N
{
    int count = 1;
    while (count <= N)
    {
    int resPow = Convert.ToInt32(Math.Pow(count, 3));
    Console.Write(resPow + " ");
    count++;
    }
    return count;
}

Console.WriteLine("Input a Int N and I'll display a table of cubes from 1 to N: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = TablePow3(number);