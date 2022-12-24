// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
int digitTest(int testNumber)    // метод, выдающий вторую цифру из трёхзначного числа
    {
    int dec = testNumber / 10;   // убрал правую единицу **_
    int ed = dec % 10;           // от полученного числа выделил младший разряд *(*) в переменную
    return ed;                   // вернул результат как значение переменной *
    }

int digitCount(int testNum)      // метод, считающий итерации деления на 10 вводимого числа (по сути: считает разряды int чисел)
{
    int dcount=0;      
    int digit = testNum;
    while(digit > 0)
    { digit /= 10;
    dcount++;}
    return dcount;
}

Input:                           // метка для возврата на строку кода через goto

Console.Write("Input a 3digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int digiCountResult = digitCount(number);

    if (digiCountResult == 3)
    {
        int metodResult = digitTest(number);              // вызов метода digiTest на обработку введенного пользователем числа, переданного в переменную number
        Console.WriteLine($"{number} -> {metodResult}");  //вывод результата в консоль
    }           
             else 
             {Console.WriteLine("You entered not a three-digit number!"); 
             goto Input; 
             }



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сооббщает, что третьей цифры нет.
*/
/*
int thirdNum(int testNumber)    // метод, выдающий третью цифру из трехзначного числа
    {   
    int ed = testNumber % 10;           
    return ed;                   
    }

int digitCount(int testNum)      // метод, считающий итерации деления на 10 вводимого числа (по сути: считает разряды int чисел)
{
    int dcount=0;      
    int digit = testNum;
    while(digit > 0)
    { digit /= 10;
    dcount++;}
    return dcount;
}


Input:
Console.WriteLine("Input an Integer number and I'll show You third num from it (or - how deep is rabbit hole): ");
int number = Convert.ToInt32(Console.ReadLine());

int CountResult = digitCount(number);
int thirdnum = thirdNum(number);

if (CountResult == 3) Console.WriteLine($"{number} -> {thirdnum}");
else if (CountResult < 3)
    {
        Console.WriteLine($"{number} -> there NO third num in Your number");
        goto Input;
    }
        else        // случай когда разрядов больше 3х
        {
        int degree = (CountResult - 3);            //определяю степень в которую нужно возвести деление на 10 для достижения остатка из 3х разрядов числа
            double fix4midle = Math.Pow(10, degree);  // 
            int fix4midle2 = Convert.ToInt32(fix4midle); 
        int midlenumber = number/ fix4midle2;
        int thirdnumX = thirdNum(midlenumber);
        Console.WriteLine($"{number} -> {thirdnumX}");
        goto Input;
        }
    
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool holidayCheck(int weekDay) // проверка по номеру дня недели выходной он или нет
    {
    if (weekDay == 6 || weekDay == 7) 
        return true;
    else
        return false;
    }

Input:
Console.WriteLine("Enter the number of the day of the week and I will tell you if it is a holiday: ");
int number = Convert.ToInt32(Console.ReadLine());

bool checkResult = holidayCheck(number);    //вызываем метод проверки выходной/рабочий
int result = Convert.ToInt32(checkResult);  //конвертируем bool значение результата проверки в int (true=1)

if (result == 1) Console.WriteLine($"{number} -> is a holiday");
    else Console.WriteLine($"{number} -> is a working day");
        goto Input;

