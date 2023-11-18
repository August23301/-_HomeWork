/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Clear();

int SummDigits(int start, int end)
{
    if (start > end)
    {
        return 0;
    }
    else
    {
        return start + SummDigits(start+1, end);
    }
}

int result = SummDigits(1, 2);
System.Console.WriteLine(result);