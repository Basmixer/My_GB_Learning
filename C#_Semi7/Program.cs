int[,] CreateRandom2dArray()

{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

/*
int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);

*/

// ЗАДАЧА 1: Задайте двумерный массив размер m на n, каждый элемент в массиве находится по формуле:
// Aij = i+j. Вывести полученный массив на экран.

/*
 int[,] CreateNM2dIArray(int m, int n)
{
    int [,] array = new int [m, n];
    for(int i=0; i < m; i++)
        for(int j = 0; j < n; j++)
        {
            array[i,j] = i + j;
        }
        return array;
}


Console.Write("Input a number of rows m: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns n: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] newNMArray = CreateNM2dIArray(rows, columns);

Show2dArray(newNMArray);
*/

// ЗАДАЧА 2: Задайте двумерный массив. Найдите элементы,
// у которых оба индекса чётные, и замените эти элементы на их квадраты.

int[,] CheckNum(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i += 2)
        for (int j = 0; j < array.GetLength(1); j += 2)
            array[i, j] *= array[i, j];
    return array;
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
CheckNum(newArray);
Show2dArray(newArray);

// ЗАДАЧА 3: Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0);(1;1) и т.д.

/*
int sumArray(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
        sum += array[i, i];
    return sum;
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
int sum = sumArray(newArray);
Console.WriteLine(sum);
*/