/*
Напишите программу, которая переодит десятичное число в двоичное
*/

System.Console.WriteLine("Введите число");
int value = int.Parse(Console.ReadLine());
System.Console.WriteLine(Convert(value));

int Convert(int num)
{
    int result = 0;
    int temp = 1;
    while (num > 0)
    {
        result = result + num % 2 * temp;
        num =num/2;
        temp= temp*10;
    }
    return result;
}