/*
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

void DigitDiaposon(int digit, int end = 1)
{
    if (digit < 1)
    {
        return;
    }

    else
    {
        System.Console.Write(digit + " ");
        DigitDiaposon(digit-1,end);
    }
}
DigitDiaposon(8);