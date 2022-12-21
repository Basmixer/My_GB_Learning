int[] array = {1,2,3,4,5,6,7,8};

int n = array.Length; // возвращает длину или количесвто элементов массива
int find = 8;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;      // для остановки цикла на первом искомом элементе массива (в случае его дублирования)
    }
    index++;
}