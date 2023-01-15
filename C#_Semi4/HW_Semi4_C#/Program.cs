/*
//Задача 25: Напишите *метод с использованием* цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetDegree(int num, int degr)
{
    int count = 0;
    int res = 1;
   
    while(count < degr)
    {
        res=res*num;
        count++;
    }
    return res;
}
input:
Console.Write("Input the first number: ");
    int A = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the number that will be the degree of the first number: ");
            int B = Convert.ToInt32(Console.ReadLine());

        int result = GetDegree(A, B);
Console.WriteLine($"{A}, {B} -> {result}");
goto input;

// * * * * * * * * * * * * * * * * * * * * * * * * 


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetSumNum(int num)
{
    int sum = 0;
        while (num > 0)
        {
           sum += num % 10;
           num /= 10;
        }
        return sum;
}

input:
Console.Write("Input an int number: ");
    int n = Convert.ToInt32(Console.ReadLine());
        int result = GetSumNum(n);
Console.WriteLine($"{n} -> {result}");
goto input;

// * * * * * * * * * * * * * * * * * * * * * * * * 
*/
// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateCustomArray(int size) // Метод генерирует одномерный массив из заданных пользователем чисел
{
     int[] array = new int[size];  // выделяем память для массива: new - специальный опреатор для выделения памяти для массива с размером "size" 
               
            for(int i = 0; i < size; i++)
            {
                Console.Write("Enter the i-number of array: ");
                int element = Convert.ToInt32(Console.ReadLine());
                array[i] = element;
            }
            return array; 
}

void ShowArray(int[] array)  // метод отображает сгенерированный массив
    {
        for(int i = 0; i < array.Length ; i++)
            Console.Write(array[i]+" ");
        
        Console.WriteLine();
    }

Console.Write("Enter the number of array elements: ");
    int s = Convert.ToInt32(Console.ReadLine());
                    
int[] CustomArray = CreateCustomArray(s);
    ShowArray(CustomArray);