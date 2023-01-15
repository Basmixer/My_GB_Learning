/*
//ЗАДАЧА: написать программу, которая на входе получает число А и выдаёт сумму чисел от 1 до А
// СУММА от 1 > A

int GetSum(int num)     // МЕТОД получения суммы от 1 до вводимого чилсла
{
    //выделить заранее память
    int sum = 0;
        
        //если в логике программы мы будем прибегать к выделенной перемеенной в цикле,
        //которая вне цикла не используется, то используем цикл "for{}"

    for(int current = 1; current <= num; current++)
        sum += current;

    return sum;
}

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = GetSum(a);
// Console.WriteLine(GetSum(a)); //второй вариант вывода через консоль
Console.WriteLine(result);


//ЗАДАЧА: написать программу, которая принимает на вход число N и выдаёт произведение чесел от 1 до N
// * 1 > N

int GetFactorial(int num) // метод получения произведения от 1 до N
{
    int factorial = 1;
    for(int current = 1; current <= num; current++)
        factorial *= current;

    return factorial;
}

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = GetFactorial(a);
Console.WriteLine(result);


//ЗАДАЧА: написать программу выдающую количество цифр вводимого числа

int GetDigits(int num) // Метод считает разряды заданного числа
{
    int count = 0;
    
    while (num != 0)
    {
        num = num / 10;
        count++;
    }

    return count;
}

Console.Write("Input a number: ");
    int a = Convert.ToInt32(Console.ReadLine());
        int count = GetDigits(a);
Console.WriteLine($"it's {count} digits in your number");

*/