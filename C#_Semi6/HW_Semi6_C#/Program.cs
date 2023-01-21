// *Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

/* // START тела 1-й задачи

int PositiveNumCounter(int m) // М Е Т О Д считает числа >0 из введенных
{
    int count = 0;
    for(int i = 0; i < m; i++)
    {
        Console.Write($"Input {i+1} number: ");
        if(Convert.ToInt32(Console.ReadLine())> 0) count++;
    }
    return count;
}

Console.Write("Input the count of numbers to be processed: ");  
    int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"It is {PositiveNumCounter(m)} positive numbers in yours input");
*/

// *Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//  b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
//  * !осуществить все проверки: параллельность, совпадение, пересечение!

            // РЕШЕНИЕ: если система уравнений...
            // имеет бесконечное множество решений, то прямые совпадают;
            // не имеет решений, то прямые не пересекаются (прямые параллельны между собой)
            // имеет единственное решение, то прямые пересекаются;
            
void LineCrosingCheck(double k1, double b1, double k2, double b2) // М Е Т О Д нахождения координаты точки пересечения 2-х линий на плоскости
{
    double x = 0;
    double y = 0;
    
    if(k1 == k2 && b1 == b2) Console.Write("There are infinitely many crossing points. The straight lines match.");
        else if(k1 == k2 && b1 != b2) Console.WriteLine("The lines are parallel. No intersection points");
                else
                {
                    x = Math.Round((b2 - b1)/(k1 - k2), 1);
                    y = Math.Round((k2*x + b2), 1);
                    Console.WriteLine($"lines have a point of intersection Ox: {x}, Oy: {y}");
                }
}

Console.Write("Input k1: ");
    double k1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Input b1: ");
            double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input k2: ");
    double k2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Input b2: ");
            double b2 = Convert.ToDouble(Console.ReadLine());

LineCrosingCheck(k1, b1, k2, b2);