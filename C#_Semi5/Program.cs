int[] CreateArray(int size)  // М Е Т О Д  создает массив путем ввода с клавиатуры
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input a {i + 1} element: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int[] CreateRandomArray(int size, int minValue, int maxValue) // М Е Т О Д генерирует случайный массив по заданным аргументам
{
    int[] array = new int[size];
        for(int i = 0; i < size; i++)
             array[i] = new Random().Next(minValue, maxValue+1);
    return array;
}

void ShowArray(int[] array)  // М Е Т О Д отображает сгенерированный массив
    {
        for(int i = 0; i < array.Length ; i++)
            Console.Write(array[i]+" ");
        
        Console.WriteLine();
    }

    /* Console.Write("Input a length of array: "); // НАЧАЛО вызов случайного массива по аргументам
     int length = Convert.ToInt32(Console.ReadLine());
         Console.Write("Input a min posibile Value: ");
             int min = Convert.ToInt32(Console.ReadLine());
                 Console.Write("Input a max posibile Value: ");
                     int max = Convert.ToInt32(Console.ReadLine());

    int[] newArray = CreateRandomArray(length, min, max); 
    ShowArray(newArray); // КОНЕЦ
    */

// ЗАДАЧА СЕМИНАРА: Написать программу, которая определяет сумму отрицательных элементов в массиве. (аналитический метод).

int GetSumOfNegatives(int[] array)  // М Е Т О Д   определяет сумму отрицательных элементов в массиве
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
            if(array[i] < 0)
             sum += array[i];
    return sum;    
}

/* 
Console.Write("Input a length of array: ");   //  НАЧАЛО  вызов программы Задача 1
    int length = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a min posibile Value: ");
            int min = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input a max posibile Value: ");
                    int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(length, min, max); 
ShowArray(newArray);

int result = GetSumOfNegatives(newArray);
Console.WriteLine("Sum of negatives in this array is " + result); // КОНЕЦ
*/



//Задачи на зал: 

// 1. Написать программу, заменяющую положительные элементы массива на отрицательные и наоборот.

int[] ChangeSign(int[] array)  // М Е Т О Д меняет знак элементов массива на противоположный
{
    for(int i = 0; i < array.Length ; i++) array[i]=-array[i];
    return array;        
}

/*
Console.Write("Input a length of array: "); // НАЧАЛО задание аргументов через консоль
     int length = Convert.ToInt32(Console.ReadLine());
         Console.Write("Input a min posibile Value: ");
             int min = Convert.ToInt32(Console.ReadLine());
                 Console.Write("Input a max posibile Value: ");
                     int max = Convert.ToInt32(Console.ReadLine());

    int[] newArray = CreateRandomArray(length, min, max); // вызов метода создания случайного массива на основании аргументов
    ShowArray(newArray);
        Console.WriteLine();
           
           int[] revArray = ChangeSign(newArray); 
                ShowArray(revArray);      // КОНЕЦ
*/


// 2. Написать программу, определяющую, присутствует ли заданное число в массиве.
// можно подумать как ускорить

void SearchNumInArray(int[] array, int num) // М Е Т О Д определяющий наличие заданного числа в массиве
{
    for(int i = 0; i < array.Length; i++)
    
        if(array[i] == num) 
        {
            Console.Write($"Yes your entering NUM defined in array with index {i}");
            Console.WriteLine();
        }  
}

/*
Console.Write("Input a length of array: ");
     int length = Convert.ToInt32(Console.ReadLine());

      int[] newArray = CreateArray(length);

        Console.Write("Input the num to be defined in array: ");
            int defNum = Convert.ToInt32(Console.ReadLine());

                SearchNumInArray(newArray, defNum);
                    
*/

// 3. Задать массив из n элементов, определить кол-во элементов,
// принадлежащих отрезку [a,b].

void CountSectionElementsInArray(int[] array, int A, int B)  // М Е Т О Д считает кол-во элементов в массиве из заданного "отрезка"
{
    int counter = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] >= A && array[i] <= B) counter++;
        }
    Console.Write(counter);
}

/*
Console.Write("Input a length of array: ");
     int length = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a minValue of array: ");
            int min = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input a maxValue of array: ");
                    int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(length, min, max);
ShowArray(newArray);
    Console.WriteLine();

Console.Write("Input the start number of section: ");
     int StartNum = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the finish number of section: ");
            int FinishNum = Convert.ToInt32(Console.ReadLine());

CountSectionElementsInArray(newArray, StartNum, FinishNum);
*/

//ДОМАШНЯЯ РАБОТА
/*
34. 

36. имеем в виду индекс

38. double тип (RandomNextDouble)
*/