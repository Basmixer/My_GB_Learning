// МЕТОДЫ:

double[,] CreateDoubleRandom2dArray(int rows, int columns) // М Е Т О Д к _ЗАДАЧЕ_ 47: генерирует 2D массив из случайных вещественных от 0 до 10
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(0, 9 + 1) + Math.Round(new Random().NextDouble(), 2);
    return array;
}

void Show2dArray(double[,] array) // М Е Т О Д  к _ЗАДАЧЕ 47_: отображает сгенерированный Double массив 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ShowArray(double[] array) // М Е Т О Д  к _ЗАДАЧЕ 52_: отображает сгенерированный Double массив[] 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(array[i] + " ");
        //Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] CreateRandom2dArray() // М Е Т О Д к _ЗАДАЧЕ 50_: создает 2D массив (x,x)
{
    int rows = 4;
    int columns = 5;
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 9 + 1);
    return array;
}

void Show2dIntArray(int[,] array) // М Е Т О Д  к _ЗАДАЧЕ 50_: отображает сгенерированный int массив 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] Copy2dArray(int[,] array) // М Е Т О Д копирует 2D массив
{
    int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            newArray[i, j] = array[i, j];
    return newArray;
}

void FindByIndex(int[,] array, int findI, int findJ) // М Е Т О Д к _ЗАДАЧЕ 50_: возвращает значение из 2D массива по заданному индексу 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            if (i == findI && j == findJ)
            {
                int returnValue = array[i, j];
                Console.WriteLine($"{findI},{findJ} -> {returnValue}");
            }
    }
    if (findI > array.GetLength(0) | findJ > array.GetLength(1))
        Console.WriteLine($"{findI},{findJ} -> index not exist in custom array");
}

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 7,8 -7,1 9

/* // РЕШЕНИЕ задачи 47

Console.Write("Input a number of rows m: ");
int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns n: ");
    int columns = Convert.ToInt32(Console.ReadLine());

double[,] newDoubleArray = CreateDoubleRandom2dArray(rows, columns);
Show2dArray(newDoubleArray);
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> элемента с такими индексами в массиве нет

/* // РЕШЕНИЕ задачи 50

int[,] newArray = CreateRandom2dArray();
Show2dIntArray(newArray);

Console.Write("Input a position (rows) in array: ");
int findI = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a position (columns) in array: ");
int findJ = Convert.ToInt32(Console.ReadLine());

FindByIndex(newArray, findI, findJ);
*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


double[] FindAverageInColumn(int[,] array)
{
    double[] averageResult = new double[array.GetLength(1)];
    double sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
            sum += array[j, i];

        averageResult[i] = Math.Round((sum / array.GetLength(0)), 1);
    }
    return averageResult;
}


int[,] newArray = CreateRandom2dArray();
Show2dIntArray(newArray);

double[] averageArray = FindAverageInColumn(newArray);
Console.Write("average by columns: ");
ShowArray(averageArray);
