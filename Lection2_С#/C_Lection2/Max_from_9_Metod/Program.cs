/*
//Классический СТИХИЙНЫЙ подход решения задачи - каждый этам "решается" следующим шагом програмного кода
// Поиск max из 9 чисел 

int a1 = 15;
int b1 = 21;
int c1 = 45;
int a2 = 4;
int b2 = 8;
int c2 = 98;
int a3 = 456;
int b3 = 23;
int c3 = 47;

int max = a1;
if(b1 > max) max = b1;
if(c1 > max) max = c1;

if(a2 > max) max = a2;
if(b2 > max) max = b2;
if(c2 > max) max = c2;

if(a3 > max) max = a3;
if(b3 > max) max = b3;
if(c3 > max) max = c3;

Console.WriteLine(max);
*/

int Max(int arg1, int arg2, int arg3)  // metod (ищет max из трёх)
{
    int result = arg1; // определяем переменную, в которой будет храниться max
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 15;
int b1 = 21;
int c1 = 45;
int a2 = 4;
int b2 = 8;
int c2 = 111111;
int a3 = 456;
int b3 = 23;
int c3 = 47;
/*
int max1 = Max(a1,b1,c1);
int max2 = Max(a2,b2,c2);
int max3 = Max(a3,b3,c3);
*/
int max = Max(Max(a1,b1,c1), Max(a2, b2, c2), Max(a3, b3, c3)); // Ха! это же РЕКУРСИЯ :) - заменяет предыдущие три строки ОДНОЙ!
/*
int max = Max(max1,max2,max3);
*/
Console.WriteLine(max);