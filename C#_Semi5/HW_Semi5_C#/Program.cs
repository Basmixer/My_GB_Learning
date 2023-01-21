

void ShowArray(int[] array)  // М Е Т О Д ОБЩИЙ : отображает сгенерированный массив 
    {
        for(int i = 0; i < array.Length ; i++)
            Console.Write(array[i]+" ");
        
        Console.WriteLine();
    }

int NumberOfEven(int[] array)  // М Е Т О Д   к _ЗАДАЧЕ 34_ поиска количества чётных элементов массива
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        {
            if (array[i] %2 == 0) count++;
        }
    return count;
}
int[] CreateRandom3digArray(int size, int minLim = 100, int maxLim = 999) // М Е Т О Д  к _ЗАДАЧЕ 34_: генерирует массив заполненный Random 0< трех значными числами 
{
    int[] array = new int[size];
        for(int i = 0; i < size; i++)
             array[i] = new Random().Next(minLim, maxLim+1);
    return array;
}

int GetSumNotEvenIndex(int[] array) // М Е Т О Д  к _ЗАДАЧЕ 36_ сумма элементов нечетных индексов
{
    int sum = 0;
    for(int i = 1; i < array.Length; i += 2)
        {
            sum = sum + array[i];
        }
    return sum;
}
int[] CreateRandomArray(int size, int min = -10, int max = 10) // М Е Т О Д  к _ЗАДАЧЕ 36_ : генерирует случайный массив по заданным аргументам
{
    int[] array = new int[size];
        for(int i = 0; i < size; i++)
             array[i] = new Random().Next(min, max+1);
    return array;
}

void ShowDoubleArray(double[] array)  // М Е Т О Д  к _ЗАДАЧЕ 38_: отображает сгенерированный Double массив 

    {
        for(int i = 0; i < array.Length ; i++)
            Console.Write(array[i]+"  ");
        
        Console.WriteLine();
    }
double[] CreateDoubleArray(int size, int min = -10, int max = 10) // М Е Т О Д  к _ЗАДАЧЕ 38_ : генерирует случайный массив по заданным аргументам
{
    double[] array = new double[size];
        for(int i = 0; i < size; i++)
             array[i] = new Random().Next(min, max+1) + Math.Round(new Random().NextDouble(),3); // округляем double до 1000-х
    return array;
} 

// *Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

/*  // START ТЕЛА 1-й программы:

Console.Write("Input a length of array: ");
     int length = Convert.ToInt32(Console.ReadLine());

        int[] RandomArray = CreateRandom3digArray(length);
            ShowArray(RandomArray);
               
                int result = NumberOfEven(RandomArray);
                    Console.WriteLine($"QTY of even numbers in array, is: " + result);
*/   // STOP

// *Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях (индексах).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

/*  // START ТЕЛА 2-й программы

Console.Write("Input a length of array: ");
     int length = Convert.ToInt32(Console.ReadLine());

        int[] RandomArray = CreateRandomArray(length);
            ShowArray(RandomArray);
                int sum = GetSumNotEvenIndex(RandomArray);
                    Console.WriteLine($"Sum of not Even Index numbers in array, is: " + sum);
*/   // STOP


// *Задача 38: Задайте массив вещественных(double (NextDouble)) чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76  (аналитический метод)

    // START ТЕЛА 3-й программы
        // решено через запись двух отдельных методов нахождения max и min,
        // для их раздельного повторного использования в будущем :)

double FindMax(double[] array) // М Е Т О Д  поиска max[i] 
{
    double max = array[0];
    for(int i = 0; i < array.Length; i++)
        if (array[i] > max) max = array[i];
    Console.WriteLine("Max num in array -> " + max);
    return max;
}

double FindMin(double[] array) // М Е Т О Д  поиска min[i] 
{
    double min = array[0]; 
    for(int i = 0; i < array.Length; i++)
        if (array[i] < min) min = array[i];
    Console.WriteLine("Min num in array -> " + min);
    return min;
}


Console.Write("Input a length of DOUBLE array: ");
     int length = Convert.ToInt32(Console.ReadLine());

        double[] RandomArray = CreateDoubleArray(length);
            ShowDoubleArray(RandomArray);
                double result = FindMax(RandomArray) - FindMin(RandomArray);
                    Console.WriteLine("def of max and min from array is: " + Math.Round(result, 3));
          
                        