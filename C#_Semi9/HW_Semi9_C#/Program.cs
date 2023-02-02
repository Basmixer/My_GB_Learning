// Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/*
void ShowNum(int num)
{
    Console.Write(num + " ");
    if(num > 1) ShowNum(num - 1);
}

Console.Write("Input a natural number: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNum(n);
*/

// Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/*
int FindSum(int m, int n)
{
    if(m < n) return m + FindSum(m + 1, n);
    if(m > n) return m + FindSum(m - 1, n);
    else return m;
}

Console.WriteLine(FindSum(4, 8));
*/


// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// Akker(m, n) = :
// n + 1, if m = 0
// Akker(m-1, 1), if m > 0 and n = 0
// Akker(m-1, Akker(m, n-1)), if m > 0 and n > 0

int Akkerman(int m, int n)
{
    if(m == 0) return n + 1;
    if(m > 0 && n == 0) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.WriteLine(Akkerman(2, 3));  // при Akker(4, 1) уже перегрузка 
