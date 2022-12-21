/*

УСЛОВИЕ:

Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

    РЕШЕНИЕ:
*/
        Console.Write("Input a first integer number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input a second integer number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        if (number1 < number2) Console.WriteLine($"Your second number_ {number2} - max, Your first number_ {number1} - min");
        else Console.WriteLine($"Your first number_ {number1}- max, Your second number_ {number2} - min");

/*
УСЛОВИЕ:

Задача 4: Напишите программу, которая принимает на вход три числа и 
выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

     РЕШЕНИЕ:

        Console.Write("Input a first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input a second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input a third number: ");
        int number3 = Convert.ToInt32(Console.ReadLine());
        
        int max = number1;

        if (number2 > max) max = number2;
        else max = number1;
        if (number3 > max) max = number3;

        Console.Write($"The number '{max}' is max from three numbers");
        
УСЛОВИЕ:

Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет

     РЕШЕНИЕ:

        Console.Write("Input an Integer number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number % 2 == 0) Console.WriteLine($"Your number {number} is EVEN two");
        else Console.WriteLine($"Your number {number} is NOT even two");

УСЛОВИЕ:

Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8


      РЕШЕНИЕ:

        Console.Write("Input an Integer number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int evennumbers = 1;
        int count = 1;

        Console.Write($"{number} -> ");

                        while (count <= number)
                {
                        if (evennumbers %2 == 0) 
                        Console.Write($"{evennumbers}, ");
                evennumbers = count+1;
                count++;
                }
        
*/