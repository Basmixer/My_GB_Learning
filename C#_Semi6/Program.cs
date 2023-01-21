
int[] CreateRandomArray(int size) // М Е Т О Д генерирует случайный массив (от -1000 до 1000)
{
    int[] array = new int[size];
        for(int i = 0; i < size; i++)
             array[i] = new Random().Next(-1000, 999+1);
    return array;
}

void ReversArray(int[] array) // М Е Т О Д симметрично центра переставляет элементы массива
{
   for(int i = 0, j = array.Length -1; i < j; i++, j--)
   {
         int temp = array[i];
         array[i] = array[j];
         array[j] = temp;
   }
}

void ShowArray(double[] array)  // М Е Т О Д отображает сгенерированный double массив
    {
        for(int i = 0; i < array.Length ; i++)
            Console.Write(array[i]+" ");
        
        Console.WriteLine();
    }

void ShowIntArray(int[] array)  // М Е Т О Д отображает сгенерированный Int массив
    {
        for(int i = 0; i < array.Length ; i++)
            Console.Write(array[i]+" ");
        
        Console.WriteLine();
    }

/* // ТЕЛО проргаммы 0:
Console.Write("Input a size of array: ");            
   int size = Convert.ToInt32(Console.ReadLine());
      Console.Write("Input a min posibile Value: ");
             int min = Convert.ToInt32(Console.ReadLine());
                 Console.Write("Input a max posibile Value: ");
                     int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max);
ShowArray(newArray);
ReversArray(newArray);
ShowArray(newArray);   
*/

// Задача 1: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// (проверить каждое чилсо меньше суммы двух других) bool

/* // ТЕЛО проргаммы 1:
 bool TriangleCheck(int a, int b, int c)  // М Е Т О Д определяет возможен ли треугольник с заданными сторонами
 {
   return (a + b > c) && (b + c > a) && (c + a > b);
 }

Console.Write("Input a side of Triangle a: ");            
   int a = Convert.ToInt32(Console.ReadLine());
      Console.Write("Input a side of Triangle b: ");
             int b = Convert.ToInt32(Console.ReadLine());
                 Console.Write("Input a side of Triangle c: ");
                     int c = Convert.ToInt32(Console.ReadLine());

if(TriangleCheck(a, b, c)) Console.WriteLine("Triangle with specifided sides can REALised");
   else Console.WriteLine("Treangle triangle does not exist!");
*/

// Задача 2: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
// 11235813...
// сформировать массив на n чисел

/* // ТЕЛО проргаммы 2:
void FibonacciN(int N, int a, int b, double[] array) // М Е Т О Д формирует массив цифр Фибоначи размером N с первых заданных двух чисел
{
   array[0] = a;
   array[1] = b;

   for(int i = 2; i < array.Length; i++) array[i] = array[i-1] + array[i -2];
}

Console.Write("Input N - length of Fibonacci nums array: ");            
   int N = Convert.ToInt32(Console.ReadLine());
      Console.Write("Input a - first Fibonacci num: ");
             int a = Convert.ToInt32(Console.ReadLine());
                 Console.Write("Input b - second Fibonacci num: ");
                     int b = Convert.ToInt32(Console.ReadLine());

double[] array = new double[N];
FibonacciN(N, a,b, array);
ShowArray(array);
*/

//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

// ТЕЛО проргаммы 3:

int[] CopyArray(int[] array)
{
   int[] newArray = new int[array.Length];

   for(int i=0; i < array.Length; i++) newArray[i] = array[i];
   return newArray;
}

Console.Write("Input a size of array: ");            
   int size = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size);
ShowIntArray(newArray);

   int[] copyArray = CopyArray(newArray);

   newArray[0] = 100500;
   ShowIntArray(newArray);
   ShowIntArray(copyArray); // для проверки обращения к ссылке/не к ссылке



