//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// для любых двух строк (ввод пользователем)

void ChangeRows(int[,] array, int r1, int r2)
{
    if (r1 >= 0 && r1 < array.GetLength(0) &&
       r2 >= 0 && r2 < array.GetLength(0) &&
       r1 != r2)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[r1, j];
            array[r1, j] = array[r2, j];
            array[r2, j] = temp;
        }
    }
}

/*
int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);

Console.Write("Input a number of first row to change: ");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of second row to change: ");
int row2 = Convert.ToInt32(Console.ReadLine());

ChangeRows(newArray, row1, row2);
Show2dArray(newArray);
*/


//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. (транспонирование) (проверить на квадратность)

int[,] CreateRandom2dArray() // М Е Т О Д : создает 2D массив (x,x)
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

void ChangeRowsColumns(int[,] array) // М Е Т О Д меняет элементы строк с элементами столбцов массива местами (транспонирование)
{
    if (array.GetLength(0) == array.GetLength(1))  // проверка на квадратность
    {
        for (int i = 0; i < array.GetLength(0) - 1; i++)
        {
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                int temp = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = temp;
            }
        }
    }
}

/*
int[,] newArray = CreateRandom2dArray();
Show2dIntArray(newArray);

ChangeRowsColumns(newArray);
Show2dIntArray(newArray);
*/

//Из двумерного массива целых чисел удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент.(создаем новый массив)

int[] MinArrayIndex(int[,] mas)
{
    int[] indexes = new int[2];
    indexes[0] = 0;
    indexes[1] = 0;
    for (int i = 0; i < mas.GetLength(0); i++)
        for (int j = 1; j < mas.GetLength(1); j++)
        {
            if (mas[i, j] < mas[indexes[0], indexes[1]])
            {
                indexes[0] = i;
                indexes[1] = j;
            }
        }
    return indexes;
}

int[,] RemoveMinIndexes(int[] indexes, int[,] mas)
{
    int[,] resmas = new int[mas.GetLength(0) - 1, mas.GetLength(1) - 1];
    int i2 = 0;
    int j2 = 0;
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        if (i != indexes[0])
        {
            for (int j = 0; j < mas.GetLength(1); j++)
            {
                if (j != indexes[1])
                {
                    resmas[i2, j2] = mas[i, j];
                    j2++;
                }
            }
            j2 = 0;  // крайне важно 
            i2++;
        }
    }
    return resmas;
}

int[,] RemoveArray(int[,] array, int[] Position)
{
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newArray[i - Convert.ToInt32((i >= Position[0] + 1)), j - Convert.ToInt32((j >= Position[1] + 1))] = array[i, j];
        }
    }
    return newArray;
}

int[,] mas = CreateRandom2dArray();
Show2dIntArray(mas);

int[,] mas2 = RemoveMinIndexes(MinArrayIndex(mas), mas);
Show2dIntArray(mas2);