
int[,] CreateRandom2dArray() // М Е Т О Д : создает 2D массив (x,y) <- задать параметр можно в теле данного метода
{
    int rows = 4;
    int columns = 4;
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 9 + 1);
    return array;
}

void Show2dIntArray(int[,] array) // М Е Т О Д  отображает сгенерированный int массив 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MaxMinSorting(int[,] array) // М Е Т О Д  _К задаче 54_ сортировка по убыванию каждой строки массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++) // сортировка по убыванию
            {
                int min = array[i, j];
                if (array[i, k] < min)
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
    return array;
}

void CheckForSquareness(int[,] array) // М Е Т О Д _К задаче 56_ квадратный или прямоугольный массив
{
    if (array.GetLength(0) == array.GetLength(1))
        Console.WriteLine("The array is square");
    else Console.WriteLine("The array is rectangular");
}

void ShowArray(int[] array)  // М Е Т О Д отображает сгенерированный int массив
{
    for (int i = 0; i < array.Length; i++)
        Console.WriteLine(array[i]);

    Console.WriteLine();
}

int[] SumByStrings(int[,] array) // М Е Т О Д  _К задаче 56_ находит сумму элементов построчно
{

    int[] sumByStrings = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        sumByStrings[i] = sum;
    }
    return sumByStrings;
}

void MinSumString(int[] array) // М Е Т О Д  _К задаче 56_ находит строку с наименьшей суммой элементов
{
    int min = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] < array[min]) min = i;
    Console.WriteLine($"String with minSum of elements has an {min} index");
    Console.WriteLine($"You see it like string with #{min + 1}");
}

// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

/* // ТЕЛО решения Задачи 54 ----------------------------------------------------

int[,] newArray = CreateRandom2dArray();
Show2dIntArray(newArray);

int[,] resultArray = MaxMinSorting(newArray);
Show2dIntArray(resultArray);
*/

// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

/* // ТЕЛО решения задачи 56 ----------------------------------------------------

int[,] newArray = CreateRandom2dArray();
Show2dIntArray(newArray);
CheckForSquareness(newArray);

int[] sumArray = SumByStrings(newArray);
ShowArray(sumArray);
MinSumString(sumArray);
*/

// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

/* // ТЕЛО решения задачи 58 ----------------------------------------------------

bool CheckForAgreedMatrix(int[,] array1, int[,] array2)  // Произведение двух матриц АВ имеет смысл только в том случае, 
                                                         // когда число столбцов матрицы А совпадает с числом строк матрицы В .
{
    return array1.GetLength(1) == array2.GetLength(0);   // для проверки работоспособности изменить значение строк/столбцов в методе CreateRandom2dArray()
}

int[,] FindMultiMatrix(int[,] array1, int[,] array2)     // В произведении матриц АВ число строк равно числу строк матрицы А,
                                                         // а число столбцов равно числу столбцов матрицы В .
{
    int[,] matrix = new int[array1.GetLength(0), array2.GetLength(1)];
    if (CheckForAgreedMatrix(array1, array2))
    {
        Console.WriteLine("Matrices are agreed");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = 0; k < array1.GetLength(1); k++)
                    matrix[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    else
    {
        Console.WriteLine("Matrices aren't agreed! Result of these matrices does not exist");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = 100500;
            }
        }
    }
    return matrix;
}

int[,] newMatrix1 = CreateRandom2dArray();
Show2dIntArray(newMatrix1);
    int[,] newMatrix2 = CreateRandom2dArray();
    Show2dIntArray(newMatrix2);
        int[,] multiMatrix = FindMultiMatrix(newMatrix1, newMatrix2);
        Show2dIntArray(multiMatrix);

*/

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//  Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

/* // ТЕЛО решения задачи 60 ----------------------------------------------------

int[,,] Create3dIntArray()
{
    int matrixLength = 2;
    int matrixWidth = 2;
    int matrixHight = 2;

    int[,,] array = new int[matrixLength, matrixWidth, matrixHight];

    for (int i = 0; i < matrixLength; i++)
    {
        for (int j = 0; j < matrixWidth; j++)
        {
            for (int k = 0; k < matrixHight; k++)
            {
                Console.Write($"Input DIFFERENT elements ({i},{j},{k}) in range(10, 100): ");
                array[i, j, k] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
    return array;
}
   
void Show3dArray(int[,,] array) // реализация через мета-матрицу: в каждой ячейке матрицы находится 2d-матрица
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    Console.Write($"{array[i, j, k]}({j}, {k}, {i})" + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

int[,,] newArray = Create3dIntArray();
Show3dArray(newArray);
*/

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// ТЕЛО решения задачи 62 ----------------------------------------------------

int[,] CreateSpiraleIntArray(int row, int column)
{
    int[,] array = new int[row, column];
    int runner = 1, i = 0, j = 0, iUp = 0, iDown = 0, jLeft = 0, jRight = 0;

    while (runner <= row * column)      // реализация по алгоритму "заполнение пространства"
    {
        array[i, j] = runner;
        if (i == iUp && j < column - 1 - jRight) j++;
        else if (j == column - 1 - jRight && i < row - 1 - iDown) i++;
        else if (i == row - 1 - iDown && j > jLeft) j--;
        else i--;

        if ((i == iUp + 1) && (j == jLeft) && (jLeft != column - 1 - jRight))
        {
            iUp++;
            iDown++;
            jLeft++;
            jRight++;
        }
        runner++;
    }
    return array;
}

Console.Write("Input a row number: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a column number: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] newSpiraleArray = CreateSpiraleIntArray(row, column);
Show2dIntArray(newSpiraleArray);