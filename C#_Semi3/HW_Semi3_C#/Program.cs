// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// при этом проигнорировать ограничение по 5-тизначности. Принимать и проверять в рамках int.

void checkPalindrome(int checkNum)
{
    int revNumber = 0;
    while (checkNum > revNumber)
    {
        revNumber = checkNum % 10 + revNumber * 10;
        checkNum = checkNum / 10;
    }
    // Console.WriteLine($"{revNumber} - revNumber");
    // Console.WriteLine($"{checkNum} - checkNum");

      if(checkNum == revNumber/10) Console.WriteLine($"Yes! it' PALINDROME");
          else Console.WriteLine($"No! it's not a PALINDROME");
}

Console.Write("Input a Int number and I'll check if it's palindrome: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0 || (number %10 ==0 && number != 0)) Console.WriteLine("Bad input"); // число не должно начинаться со знака "-" не заканчиваться/начинаться "0"

checkPalindrome(number); // вызов метода проверки