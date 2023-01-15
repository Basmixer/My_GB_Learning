// 153 ->  1 3 -> 13 :Обрабатвает случайное 3х значное число и складывает крайние цифры числа

int CutNumber(int number)         // метод удаления второго числа из 3х значного числа и сложения первого с третьим
{
    int sot = number / 100;
    int ed = number % 10;
    int result = sot*10 + ed;
    return result;
}

int randNumber = new Random().Next(100, 1000); //генератор случайных чисел в мтеоде Next от 100 до 1000 (1000 не включается)
int newNumber = CutNumber(randNumber); // вызов работы метода: необходимо задать переменную того же типа и передать в нее результат метода

Console.WriteLine($"New version of a number {randNumber} is {newNumber}");


