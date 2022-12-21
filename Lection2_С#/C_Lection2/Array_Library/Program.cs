void FillArray(int[] collection)    // метод заполнения массива void metod -ничего не возвращающий метод
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)          // метод вывода элементов заполненного массива
    {
        int count = col.Length;
        int position = 0;
        while (position < count)
        {
            Console.WriteLine(col[position]);
            position++;
        }
    }

int IndexOf(int[] collection, int find) // метод нахождения позции(ИНДЕКС) нужного элемента из массива
{

    int count = collection.Length;
    int index =0;
    int position = -1;          // "-1" специально возвращает, если зададим поиск не существующего элемента в массиве
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;                      // остановка цикла сразу по нахождении числа в первом из индексов
        }
        index++;
    }
    return position;    // после отработки цикла ожидаем возврат позиции элемента
}

int[] array = new int[10]; //создаём новый массив, в котором будет 10 элементов (по умоляанию наполнен "0" нулями)

FillArray(array);       // вызываем метод заполнения массива
array[4] = 4;
array[7] = 4;

PrintArray(array);      // вызываем метод вывода элементов массива в консоль
Console.WriteLine();

int pos = IndexOf(array, 4); // вызываем метод нахождения элемента из массива array, ищем ИНДЕКС числа "4" - по месту последнего вхождения в массив
Console.WriteLine(pos);
