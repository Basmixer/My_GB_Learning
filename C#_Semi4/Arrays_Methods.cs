int[] CreateRandomArray(int size, int minValue, int maxValue) // Метод генерирует массив (одномерный)
    {
        int[] array = new int[size];  // тут выделяем память для массива: new - специальный опреатор для выделения памяти для массива с размером "size" 
                                      //{хранятся нули}
            for(int i=0; i < size; i++)  // с массивами ТОЛЬКО цикл "for"
                array[i]=new Random().Next(minValue, maxValue + 1);
            return array; // только имя! без скобок!
    } 

    void ShowArray(int[] array)  // метод отображает сгенерированный массив

    {
        for(int i = 0; i < array.Length; i++)
            Console.Write(array[i] + " ");
        
        Console.WriteLine();
    }

    Console.Write("Input a length of array: ");
    int length = Convert.ToInt32(Console.ReadLine());

      Console.Write("Input a min possible value: ");
      int min = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input a max possible value: ");
            int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(length, min, max);

ShowArray(newArray);