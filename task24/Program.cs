/*
24. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

System.Console.Write("Введи переменную ");
int number = int.Parse(Console.ReadLine());
int result = Summ(number);
System.Console.WriteLine(result);

int Summ(int num)
{
    int summa = 0;
    for (int i = 1; i <= num; i++)
    {
        summa = summa + i;
    }
    return (summa);
}
