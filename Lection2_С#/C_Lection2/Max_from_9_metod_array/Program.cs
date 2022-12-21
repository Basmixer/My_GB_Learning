
int Max(int arg1, int arg2, int arg3)  // metod (ищет max из трёх)
{
    int result = arg1; // определяем переменную, в которой будет храниться max
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
//            0 1  2   3  4 5  6  7 8
int[] array ={1,2,343,44,55,6,57,78,9}; // определение массива
array[0]=12;                            // обращение к элементу массива и принудительное задание числа 12

int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);

Console.WriteLine(max);



