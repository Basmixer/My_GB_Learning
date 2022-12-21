// Семинар 1.

// Задача 1. Напишите программу, которая принимает на вход два числа и проверяет, является ли первое число квадратом второго
/*
Console.Write("Input a first namber: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second namber: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad2 = num2 * num2;

if( num1 == quad2) Console.WriteLine("Yes!");
else Console.WriteLine("No!");
*/

// Задача 2. Напишите программу, которая принимает на вход одно число (N), а на выходе показывает все ЦЕЛЫЕ числа в промежутке от -N до N

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = -number;

while (current <= number)
{
    Console.Write(current + " ");
    current = current + 1; // current += 1;  current++
}